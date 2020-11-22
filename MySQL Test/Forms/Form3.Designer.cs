namespace MySQL_Test.Forms
{
    partial class Form3
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
            this.Username = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.YourUsername = new System.Windows.Forms.Label();
            this.YourEmail = new System.Windows.Forms.Label();
            this.Phones = new System.Windows.Forms.Label();
            this.PhonesPictures = new System.Windows.Forms.PictureBox();
            this.PhonesList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PhonesPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(12, 22);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 17);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(12, 50);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            this.Email.Click += new System.EventHandler(this.label2_Click);
            // 
            // YourUsername
            // 
            this.YourUsername.AutoSize = true;
            this.YourUsername.Location = new System.Drawing.Point(108, 22);
            this.YourUsername.Name = "YourUsername";
            this.YourUsername.Size = new System.Drawing.Size(0, 17);
            this.YourUsername.TabIndex = 2;
            // 
            // YourEmail
            // 
            this.YourEmail.AutoSize = true;
            this.YourEmail.Location = new System.Drawing.Point(108, 50);
            this.YourEmail.Name = "YourEmail";
            this.YourEmail.Size = new System.Drawing.Size(0, 17);
            this.YourEmail.TabIndex = 3;
            // 
            // Phones
            // 
            this.Phones.AutoSize = true;
            this.Phones.Location = new System.Drawing.Point(218, 78);
            this.Phones.Name = "Phones";
            this.Phones.Size = new System.Drawing.Size(56, 17);
            this.Phones.TabIndex = 4;
            this.Phones.Text = "Phones";
            // 
            // PhonesPictures
            // 
            this.PhonesPictures.Location = new System.Drawing.Point(249, 98);
            this.PhonesPictures.Name = "PhonesPictures";
            this.PhonesPictures.Size = new System.Drawing.Size(229, 164);
            this.PhonesPictures.TabIndex = 5;
            this.PhonesPictures.TabStop = false;
            // 
            // PhonesList
            // 
            this.PhonesList.FormattingEnabled = true;
            this.PhonesList.ItemHeight = 16;
            this.PhonesList.Location = new System.Drawing.Point(12, 98);
            this.PhonesList.Name = "PhonesList";
            this.PhonesList.Size = new System.Drawing.Size(220, 164);
            this.PhonesList.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 274);
            this.Controls.Add(this.PhonesList);
            this.Controls.Add(this.PhonesPictures);
            this.Controls.Add(this.Phones);
            this.Controls.Add(this.YourEmail);
            this.Controls.Add(this.YourUsername);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Username);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.PhonesPictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label YourUsername;
        private System.Windows.Forms.Label YourEmail;
        private System.Windows.Forms.Label Phones;
        private System.Windows.Forms.PictureBox PhonesPictures;
        private System.Windows.Forms.ListBox PhonesList;
    }
}