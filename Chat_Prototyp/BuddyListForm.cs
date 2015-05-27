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
    public partial class BuddyListForm : Form
    {
        public BuddyListForm()
        {
            InitializeComponent();
        }

        private void BuddyListForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FriendListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.FriendListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                this.openChatApplication(this.FriendListBox.SelectedItem.ToString());
            }
        }
    }
}
