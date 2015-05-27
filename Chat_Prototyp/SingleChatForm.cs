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
    public partial class SingleChatForm : Form
    {
        public SingleChatForm()
        {
            InitializeComponent();
        }

        private void SendMessage(object sender, System.EventArgs e)
        {
            this.MessageBox.Text = this.MessageTextBox.Text + "\r\n" + this.MessageBox.Text;
        }
    }
}
