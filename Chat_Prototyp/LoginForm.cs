using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chat_Prototyp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            this.LoginDelegat();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            this.RegisterDelegat();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }
}
