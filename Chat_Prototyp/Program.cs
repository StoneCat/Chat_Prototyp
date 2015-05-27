using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Chat_Prototyp
{
    class cUser
    {
        private int id;
        private string username;
        private string firstname;
        private string lastname;
        private string status;

        public void setid(int inewid)
        {
            this.id = inewid;
        }

        public int getid() { return this.id; }

        public void setusername(string snewusername)
        {
            this.username = snewusername;
        }

        public string getusername() { return this.username; }

        public void setfirstname(string snewfirstname)
        {
            this.firstname = snewfirstname;
        }

        public string getfirstname() { return this.firstname; }

        public void setlastname(string snewlastname)
        {
            this.lastname = snewlastname;
        }

        public string getlastname() { return this.lastname; }

        public void setstatus(string snewstatus)
        {
            this.status = snewstatus;
        }

        public string getstatus() { return this.status; }
    }

    class cMainUser : cUser
    {
        private string password;
        private List<cUser> friendlist;

        public string getpassword() { return this.password; }

        public void setpassword(string snewpassword)
        {
            this.password = snewpassword;
        }
    }

    class cLoginWindow : LoginForm
    {
        public cLoginWindow()
        {
        }

        public string getUsernameText()
        {
            return this.TextBoxUsername.Text.ToString();
        }

        public string getPasswordText()
        {
            return this.TextBoxPassword.Text.ToString();
        }

        public void showme()
        {
            this.Show();
        }

        public void closeme()
        {
            this.Close();
        }

        public void hideme()
        {
            this.Hide();
        }
    }

    class cRegisterWindow : RegisterForm
    {
        public cRegisterWindow()
        {
        }

        public void showme()
        {
            this.Show();
        }

        public void closeme()
        {
            this.Close();
        }

        public void hideme()
        {
            this.Hide();
        }
    }

    class cBuddyListWindow : BuddyListForm
    {
        public cBuddyListWindow()
        {

        }

        public void changeLabel(string stext)
        {
            this.HeaderLabel.Text = stext;
        }

        public void showme()
        {
            this.Show();
        }

        public void closeme()
        {
            this.Close();
        }

        public void hideme()
        {
            this.Hide();
        }
    }

    class cSingleChatWindow : SingleChatForm
    {
        public void changeLabel(string stext)
        {
            this.ChatInfoLabel.Text= stext;
        }

        public void showme()
        {
            this.Show();
        }

        public void closeme()
        {
            this.Close();
        }

        public void hideme()
        {
            this.Hide();
        }
    }

    class cMainController
    {
        private cMainUser mainuser = new cMainUser();
        private cLoginWindow loginwindow;
        private cRegisterWindow registerwindow;
        private DatabaseSQLite DB;
        private cBuddyListWindow buddywindow;
        private List<cSingleChatWindow> ListChats;
        private int openChatWindows = -1;

        public cMainController()
        {
            this.DB = new DatabaseSQLite("Data Source=ChatDatabase.sqlite;Version=3;");
            this.loginwindow = new cLoginWindow();
            this.registerwindow = new cRegisterWindow();
            this.buddywindow = new cBuddyListWindow();
            this.ListChats = new List<cSingleChatWindow>() { new cSingleChatWindow(), new cSingleChatWindow(), new cSingleChatWindow(), new cSingleChatWindow(), new cSingleChatWindow(), new cSingleChatWindow() };
            this.loginwindow.LoginDelegat += this.checkLogin;
            this.loginwindow.RegisterDelegat += this.startRegWindow;
            this.registerwindow.doRegistUser += this.DB.insertUser;
            this.registerwindow.doOnCancel += this.closeRegWindow;
            this.buddywindow.openChatApplication += this.startChatWindow;
            this.loginwindow.showme();
            Application.Run();
        }

        private string SplitString(string stoSplit, char cSplitItem, int ipoint)
        {
            string result = "";
            int i = 0;
            string[] words = stoSplit.Split(cSplitItem);
            foreach (string word in words)
            {
                if (ipoint == i)
                {
                    result = word;
                }
                i++;
            }
            return result;
        }

        private void doLoginAsUser(int userid)
        {
            this.mainuser.setid(userid);
            //TODO Füge Username anstatt ID ein
            this.buddywindow.changeLabel("Sie sind online als: " + this.mainuser.getid());
            this.loginwindow.hideme();
            this.buddywindow.showme();
        }

        public void checkLogin()
        {
            if (this.DB.Open())
            {
                this.DB.Execute("select id from Chatuser where username = '" + this.loginwindow.getUsernameText() + "' AND userpassword = '" + this.loginwindow.getPasswordText() + "'");
            }
            if (this.DB.ResultSet.Count() != 0)
            {
                this.doLoginAsUser(Convert.ToInt32(this.DB.ResultSet[0][0]));
            }
            else
            {
                MessageBox.Show("Benutzername oder Passwort sind falsch!", "Anmelden fehlgeschlagen");
            }
        }

        public void startRegWindow()
        {
            this.loginwindow.hideme();
            this.registerwindow.showme();
        }

        public void closeRegWindow()
        {
            this.registerwindow.hideme();
            this.loginwindow.showme();
        }

        public void startChatWindow(string username)
        {
            this.openChatWindows++;
            this.ListChats[this.openChatWindows].changeLabel("Sie chatten mit " + username);
            this.ListChats[this.openChatWindows].showme();
        }
    }


    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            cMainController Einstieg = new cMainController();
        }
    }
}
