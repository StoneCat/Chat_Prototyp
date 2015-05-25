using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Chat_Prototyp
{
    class cUser
    {
        protected string username;
        protected string firstname;
        protected string lastname;
        protected string status;
    }

    class cMainUser : cUser
    {
        private string password;
        private List<cUser> friendlist;

        public cMainUser()
        {
            
        }
    }

    class LoginWindow : LoginForm
    {
        public LoginWindow()
        {
        }

        public void changeLabel(string text)
        {
            this.LabelUsername.Text = text;
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

    class RegisterWindow : RegisterForm
    {
        public RegisterWindow()
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

    class cMainController
    {
        private cMainUser mainuser = new cMainUser();
        private LoginWindow loginwindow;
        private RegisterWindow registerwindow;
        private cSQLiteConnection localDB;

        public cMainController()
        {
            this.localDB = new cSQLiteConnection();
            this.loginwindow = new LoginWindow();
            this.registerwindow = new RegisterWindow();
            this.loginwindow.LoginDelegat += this.checkLogin;
            this.loginwindow.RegisterDelegat += this.startRegWindow;
            this.registerwindow.doRegistUser += this.localDB.insertUser;
            this.registerwindow.doOnCancel += this.closeRegWindow;
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

        public void checkLogin()
        {
            List<string> items = this.localDB.selectDB("select id from Chatuser where username = '" + this.loginwindow.getUsernameText() + "' AND userpassword = '" + this.loginwindow.getPasswordText() + "'");
            if (items.Count() != 0)
            {
                this.loginwindow.changeLabel("Erfolgreich als User " + items[0]);
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
