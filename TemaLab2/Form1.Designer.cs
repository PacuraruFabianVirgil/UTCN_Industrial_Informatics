namespace TemaLab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.feedback = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(34, 28);
            this.username.Name = "username";
            this.username.PlaceholderText = "Username";
            this.username.Size = new System.Drawing.Size(100, 23);
            this.username.TabIndex = 1;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(169, 28);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderText = "Password";
            this.password.Size = new System.Drawing.Size(100, 23);
            this.password.TabIndex = 2;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // feedback
            // 
            this.feedback.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.feedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.feedback.Location = new System.Drawing.Point(0, 70);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(304, 75);
            this.feedback.TabIndex = 4;
            this.feedback.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // signin
            // 
            this.signin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signin.Location = new System.Drawing.Point(115, 104);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(75, 28);
            this.signin.TabIndex = 5;
            this.signin.Text = "Sign In";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // register
            // 
            this.register.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.register.Location = new System.Drawing.Point(0, 145);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(304, 51);
            this.register.TabIndex = 6;
            this.register.TabStop = true;
            this.register.Text = "Register if you don\'t have an account";
            this.register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(304, 196);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox username;
        private TextBox password;
        private Label feedback;
        private Button signin;
        private LinkLabel register;
    }
}