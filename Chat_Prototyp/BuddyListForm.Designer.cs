namespace Chat_Prototyp
{
    partial class BuddyListForm
    {
        public delegate void onFriendListClick(string username);
        public onFriendListClick openChatApplication;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.FriendLabel = new System.Windows.Forms.Label();
            this.FriendListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(13, 13);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(100, 13);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Sie sind online als...";
            // 
            // FriendLabel
            // 
            this.FriendLabel.AutoSize = true;
            this.FriendLabel.Location = new System.Drawing.Point(13, 39);
            this.FriendLabel.Name = "FriendLabel";
            this.FriendLabel.Size = new System.Drawing.Size(49, 13);
            this.FriendLabel.TabIndex = 1;
            this.FriendLabel.Text = "Freunde:";
            // 
            // FriendListBox
            // 
            this.FriendListBox.FormattingEnabled = true;
            this.FriendListBox.Location = new System.Drawing.Point(16, 56);
            this.FriendListBox.Name = "FriendListBox";
            this.FriendListBox.Size = new System.Drawing.Size(120, 95);
            this.FriendListBox.TabIndex = 2;
            this.FriendListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FriendListBox_MouseDoubleClick);
            // 
            // BuddyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(154, 165);
            this.Controls.Add(this.FriendListBox);
            this.Controls.Add(this.FriendLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "BuddyListForm";
            this.Text = "BuddyListForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuddyListForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label HeaderLabel;
        protected System.Windows.Forms.Label FriendLabel;
        protected System.Windows.Forms.ListBox FriendListBox;
    }
}
