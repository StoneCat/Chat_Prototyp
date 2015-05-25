namespace Chat_Prototyp
{
    partial class RegisterForm
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.FirstPasswordLabel = new System.Windows.Forms.Label();
            this.FirstPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SecondPasswordLabel = new System.Windows.Forms.Label();
            this.SecondPasswordTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(13, 13);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(181, 13);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Bitte füllen sie alle Informationen aus.";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 46);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Location = new System.Drawing.Point(13, 74);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(49, 13);
            this.FirstnameLabel.TabIndex = 3;
            this.FirstnameLabel.Text = "Vorname";
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Location = new System.Drawing.Point(16, 90);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(171, 20);
            this.FirstnameTextBox.TabIndex = 4;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(13, 118);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(75, 13);
            this.UsernameLabel.TabIndex = 5;
            this.UsernameLabel.Text = "Benutzername";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(16, 134);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(171, 20);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // FirstPasswordLabel
            // 
            this.FirstPasswordLabel.AutoSize = true;
            this.FirstPasswordLabel.Location = new System.Drawing.Point(13, 162);
            this.FirstPasswordLabel.Name = "FirstPasswordLabel";
            this.FirstPasswordLabel.Size = new System.Drawing.Size(50, 13);
            this.FirstPasswordLabel.TabIndex = 7;
            this.FirstPasswordLabel.Text = "Passwort";
            // 
            // FirstPasswordTextBox
            // 
            this.FirstPasswordTextBox.Location = new System.Drawing.Point(16, 178);
            this.FirstPasswordTextBox.Name = "FirstPasswordTextBox";
            this.FirstPasswordTextBox.PasswordChar = '*';
            this.FirstPasswordTextBox.Size = new System.Drawing.Size(171, 20);
            this.FirstPasswordTextBox.TabIndex = 8;
            // 
            // SecondPasswordLabel
            // 
            this.SecondPasswordLabel.AutoSize = true;
            this.SecondPasswordLabel.Location = new System.Drawing.Point(13, 206);
            this.SecondPasswordLabel.Name = "SecondPasswordLabel";
            this.SecondPasswordLabel.Size = new System.Drawing.Size(110, 13);
            this.SecondPasswordLabel.TabIndex = 9;
            this.SecondPasswordLabel.Text = "Passwort wiederholen";
            // 
            // SecondPasswordTextBox
            // 
            this.SecondPasswordTextBox.Location = new System.Drawing.Point(16, 222);
            this.SecondPasswordTextBox.Name = "SecondPasswordTextBox";
            this.SecondPasswordTextBox.PasswordChar = '*';
            this.SecondPasswordTextBox.Size = new System.Drawing.Size(171, 20);
            this.SecondPasswordTextBox.TabIndex = 10;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(16, 249);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Abbrechen";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(98, 249);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(89, 23);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Registrieren";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 279);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SecondPasswordTextBox);
            this.Controls.Add(this.SecondPasswordLabel);
            this.Controls.Add(this.FirstPasswordTextBox);
            this.Controls.Add(this.FirstPasswordLabel);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.FirstnameTextBox);
            this.Controls.Add(this.FirstnameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.InfoLabel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);

        }

        #endregion

        protected System.Windows.Forms.Label InfoLabel;
        protected System.Windows.Forms.Label nameLabel;
        protected System.Windows.Forms.TextBox nameTextBox;
        protected System.Windows.Forms.Label FirstnameLabel;
        protected System.Windows.Forms.TextBox FirstnameTextBox;
        protected System.Windows.Forms.Label UsernameLabel;
        protected System.Windows.Forms.TextBox UsernameTextBox;
        protected System.Windows.Forms.Label FirstPasswordLabel;
        protected System.Windows.Forms.TextBox FirstPasswordTextBox;
        protected System.Windows.Forms.Label SecondPasswordLabel;
        protected System.Windows.Forms.TextBox SecondPasswordTextBox;
        protected System.Windows.Forms.Button CancelButton;
        protected System.Windows.Forms.Button RegisterButton;
    }
}