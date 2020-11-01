namespace MySQL_Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SELECT = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SELECT
            // 
            this.SELECT.Location = new System.Drawing.Point(163, 171);
            this.SELECT.Name = "SELECT";
            this.SELECT.Size = new System.Drawing.Size(132, 84);
            this.SELECT.TabIndex = 2;
            this.SELECT.Text = "enter";
            this.SELECT.UseVisualStyleBackColor = true;
            this.SELECT.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(611, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 426);
            this.textBox2.TabIndex = 3;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(160, 123);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(127, 17);
            this.login.TabIndex = 4;
            this.login.Text = "Username or email";
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(163, 277);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(132, 84);
            this.SignUp.TabIndex = 5;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.SELECT);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SELECT;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Button SignUp;
    }
}

