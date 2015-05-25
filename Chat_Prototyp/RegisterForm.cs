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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
                Application.Exit();
        }

        private void RegisterButton_Click(object sender, System.EventArgs e)
        {
            bool b = false;
            b = this.doRegistUser(this.FirstnameTextBox.Text.ToString(), this.nameTextBox.Text.ToString(),
                this.UsernameTextBox.Text.ToString(), this.FirstPasswordTextBox.Text.ToString());
            if (b == false)
            {
                MessageBox.Show("Etwas hat nicht funktioniert, bitte versuchen Sie es erneut...", "Registrierung fehlgeschlagen");
            }
            else
            {
                this.doOnCancel();
            }
        }

        private void onTextBoxChange(object sender, System.EventArgs e)
        {
            if(this.nameTextBox.Text != "" &&
                this.FirstnameTextBox.Text != "" &&
                this.UsernameTextBox.Text != "" &&
                this.FirstPasswordTextBox.Text != "" &&
                this.SecondPasswordTextBox.Text != "")
            {
                if (this.FirstPasswordTextBox.Text == this.SecondPasswordTextBox.Text)
                {
                    this.RegisterButton.Enabled = true;
                }
            }
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.doOnCancel();
        }
    }
}
