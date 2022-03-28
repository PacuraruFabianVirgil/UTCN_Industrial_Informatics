namespace TemaLab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.checkPassword = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.Label();
            this.wrongPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose a password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rewrite password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(141, 17);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 23);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(141, 51);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 23);
            this.password.TabIndex = 4;
            // 
            // checkPassword
            // 
            this.checkPassword.Location = new System.Drawing.Point(141, 87);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.PasswordChar = '*';
            this.checkPassword.Size = new System.Drawing.Size(100, 23);
            this.checkPassword.TabIndex = 5;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(32, 162);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 23);
            this.date.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose your birthdate:";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(96, 200);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 9;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // age
            // 
            this.age.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.age.Location = new System.Drawing.Point(0, 226);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(267, 38);
            this.age.TabIndex = 10;
            this.age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wrongPassword
            // 
            this.wrongPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wrongPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wrongPassword.Location = new System.Drawing.Point(0, 124);
            this.wrongPassword.Name = "wrongPassword";
            this.wrongPassword.Size = new System.Drawing.Size(267, 102);
            this.wrongPassword.TabIndex = 11;
            this.wrongPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 264);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.date);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wrongPassword);
            this.Controls.Add(this.age);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private TextBox password;
        private TextBox checkPassword;
        private DateTimePicker date;
        private Label label4;
        private Button register;
        private Label age;
        private Label wrongPassword;
    }
}