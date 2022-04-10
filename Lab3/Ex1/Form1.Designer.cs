namespace Ex1
{
    partial class Form1
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
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.NameUniv = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Update_Name = new System.Windows.Forms.CheckBox();
            this.Update_City = new System.Windows.Forms.CheckBox();
            this.Update_Id = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(116, 154);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(57, 183);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(99, 25);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update selected";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // NameUniv
            // 
            this.NameUniv.Location = new System.Drawing.Point(91, 81);
            this.NameUniv.Name = "NameUniv";
            this.NameUniv.Size = new System.Drawing.Size(100, 20);
            this.NameUniv.TabIndex = 0;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(91, 114);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(100, 20);
            this.City.TabIndex = 1;
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(91, 14);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(100, 20);
            this.Code.TabIndex = 2;
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(15, 154);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Code";
            // 
            // Update_Name
            // 
            this.Update_Name.AutoSize = true;
            this.Update_Name.Location = new System.Drawing.Point(57, 84);
            this.Update_Name.Name = "Update_Name";
            this.Update_Name.Size = new System.Drawing.Size(15, 14);
            this.Update_Name.TabIndex = 9;
            this.Update_Name.UseVisualStyleBackColor = true;
            // 
            // Update_City
            // 
            this.Update_City.AutoSize = true;
            this.Update_City.Location = new System.Drawing.Point(57, 117);
            this.Update_City.Name = "Update_City";
            this.Update_City.Size = new System.Drawing.Size(15, 14);
            this.Update_City.TabIndex = 10;
            this.Update_City.UseVisualStyleBackColor = true;
            // 
            // Update_Id
            // 
            this.Update_Id.AutoSize = true;
            this.Update_Id.Location = new System.Drawing.Point(57, 51);
            this.Update_Id.Name = "Update_Id";
            this.Update_Id.Size = new System.Drawing.Size(15, 14);
            this.Update_Id.TabIndex = 11;
            this.Update_Id.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(91, 48);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 220);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_Id);
            this.Controls.Add(this.Update_City);
            this.Controls.Add(this.Update_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.NameUniv);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Code);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox NameUniv;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Update_Name;
        private System.Windows.Forms.CheckBox Update_City;
        private System.Windows.Forms.CheckBox Update_Id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
    }
}

