namespace Chat_Prototyp
{
    partial class SingleChatForm
    {
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
            this.ChatInfoLabel = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChatInfoLabel
            // 
            this.ChatInfoLabel.AutoSize = true;
            this.ChatInfoLabel.Location = new System.Drawing.Point(13, 13);
            this.ChatInfoLabel.Name = "ChatInfoLabel";
            this.ChatInfoLabel.Size = new System.Drawing.Size(86, 13);
            this.ChatInfoLabel.TabIndex = 0;
            this.ChatInfoLabel.Text = "Sie chatten mit...";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(13, 272);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(278, 52);
            this.MessageTextBox.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(298, 272);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(117, 52);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Senden";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendMessage);
            // 
            // MessageBox
            // 
            this.MessageBox.AcceptsReturn = true;
            this.MessageBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MessageBox.Location = new System.Drawing.Point(13, 30);
            this.MessageBox.Multiline = true;
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.ReadOnly = true;
            this.MessageBox.Size = new System.Drawing.Size(402, 236);
            this.MessageBox.TabIndex = 4;
            this.MessageBox.Text = "SYSTEM: Chat gestarten...";
            // 
            // SingleChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 336);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.ChatInfoLabel);
            this.Name = "SingleChatForm";
            this.Text = "SingleChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label ChatInfoLabel;
        protected System.Windows.Forms.TextBox MessageTextBox;
        protected System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox MessageBox;
    }
}