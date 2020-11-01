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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.WrongName = new System.Windows.Forms.Label();
            this.WrongEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(34, 52);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(73, 17);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(34, 118);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 17);
            this.email.TabIndex = 3;
            this.email.Text = "email";
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(96, 187);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 394);
            this.Controls.Add(this.WrongEmail);
            this.Controls.Add(this.WrongName);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Label WrongName;
        private System.Windows.Forms.Label WrongEmail;
    }
}