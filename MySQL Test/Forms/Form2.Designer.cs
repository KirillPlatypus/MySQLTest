namespace MySQL_Test
{
    partial class Form2
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
            this.EnterName = new System.Windows.Forms.TextBox();
            this.EnterEmail = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.WrongName = new System.Windows.Forms.Label();
            this.WrongEmail = new System.Windows.Forms.Label();
            this.PhoneName = new System.Windows.Forms.Label();
            this.phoneEnterName = new System.Windows.Forms.TextBox();
            this.WrongPhoneName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterName
            // 
            this.EnterName.Location = new System.Drawing.Point(133, 52);
            this.EnterName.Name = "EnterName";
            this.EnterName.Size = new System.Drawing.Size(100, 22);
            this.EnterName.TabIndex = 0;
            this.EnterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EnterEmail
            // 
            this.EnterEmail.Location = new System.Drawing.Point(133, 113);
            this.EnterEmail.Name = "EnterEmail";
            this.EnterEmail.Size = new System.Drawing.Size(100, 22);
            this.EnterEmail.TabIndex = 1;
            this.EnterEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(17, 52);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 17);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(17, 118);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 17);
            this.email.TabIndex = 3;
            this.email.Text = "email";
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(97, 313);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(99, 40);
            this.SignUp.TabIndex = 4;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // WrongName
            // 
            this.WrongName.AutoSize = true;
            this.WrongName.Location = new System.Drawing.Point(133, 77);
            this.WrongName.Name = "WrongName";
            this.WrongName.Size = new System.Drawing.Size(0, 17);
            this.WrongName.TabIndex = 5;
            // 
            // WrongEmail
            // 
            this.WrongEmail.AutoSize = true;
            this.WrongEmail.Location = new System.Drawing.Point(133, 137);
            this.WrongEmail.Name = "WrongEmail";
            this.WrongEmail.Size = new System.Drawing.Size(0, 17);
            this.WrongEmail.TabIndex = 6;
            // 
            // PhoneName
            // 
            this.PhoneName.AutoSize = true;
            this.PhoneName.Location = new System.Drawing.Point(17, 193);
            this.PhoneName.Name = "PhoneName";
            this.PhoneName.Size = new System.Drawing.Size(90, 17);
            this.PhoneName.TabIndex = 7;
            this.PhoneName.Text = "Phone Name";
            // 
            // phoneEnterName
            // 
            this.phoneEnterName.Location = new System.Drawing.Point(133, 190);
            this.phoneEnterName.Name = "phoneEnterName";
            this.phoneEnterName.Size = new System.Drawing.Size(100, 22);
            this.phoneEnterName.TabIndex = 8;
            this.phoneEnterName.TextChanged += new System.EventHandler(this.phoneEnterName_TextChanged);
            // 
            // WrongPhoneName
            // 
            this.WrongPhoneName.AutoSize = true;
            this.WrongPhoneName.Location = new System.Drawing.Point(133, 215);
            this.WrongPhoneName.Name = "WrongPhoneName";
            this.WrongPhoneName.Size = new System.Drawing.Size(0, 17);
            this.WrongPhoneName.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 394);
            this.Controls.Add(this.WrongPhoneName);
            this.Controls.Add(this.phoneEnterName);
            this.Controls.Add(this.PhoneName);
            this.Controls.Add(this.WrongEmail);
            this.Controls.Add(this.WrongName);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.EnterEmail);
            this.Controls.Add(this.EnterName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterName;
        private System.Windows.Forms.TextBox EnterEmail;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label WrongName;
        private System.Windows.Forms.Label WrongEmail;
        private System.Windows.Forms.Label PhoneName;
        private System.Windows.Forms.TextBox phoneEnterName;
        private System.Windows.Forms.Label WrongPhoneName;
    }
}