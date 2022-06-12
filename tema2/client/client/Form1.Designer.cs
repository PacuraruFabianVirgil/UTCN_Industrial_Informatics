namespace client
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
            this.Name_Value = new System.Windows.Forms.TextBox();
            this.Description_Value = new System.Windows.Forms.TextBox();
            this.Players_Value = new System.Windows.Forms.TextBox();
            this.Trophies_Value = new System.Windows.Forms.TextBox();
            this.Value_Value = new System.Windows.Forms.TextBox();
            this.Description_Check = new System.Windows.Forms.CheckBox();
            this.Players_Check = new System.Windows.Forms.CheckBox();
            this.Trophies_Check = new System.Windows.Forms.CheckBox();
            this.Value_Check = new System.Windows.Forms.CheckBox();
            this.Add_Team = new System.Windows.Forms.Button();
            this.Update_Team = new System.Windows.Forms.Button();
            this.See_Teams = new System.Windows.Forms.Button();
            this.Delete_Team = new System.Windows.Forms.Button();
            this.Teams = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_Value
            // 
            this.Name_Value.Location = new System.Drawing.Point(79, 192);
            this.Name_Value.Name = "Name_Value";
            this.Name_Value.Size = new System.Drawing.Size(202, 20);
            this.Name_Value.TabIndex = 0;
            // 
            // Description_Value
            // 
            this.Description_Value.Location = new System.Drawing.Point(79, 227);
            this.Description_Value.Name = "Description_Value";
            this.Description_Value.Size = new System.Drawing.Size(294, 20);
            this.Description_Value.TabIndex = 1;
            // 
            // Players_Value
            // 
            this.Players_Value.Location = new System.Drawing.Point(79, 262);
            this.Players_Value.Name = "Players_Value";
            this.Players_Value.Size = new System.Drawing.Size(202, 20);
            this.Players_Value.TabIndex = 2;
            // 
            // Trophies_Value
            // 
            this.Trophies_Value.Location = new System.Drawing.Point(79, 298);
            this.Trophies_Value.Name = "Trophies_Value";
            this.Trophies_Value.Size = new System.Drawing.Size(202, 20);
            this.Trophies_Value.TabIndex = 3;
            // 
            // Value_Value
            // 
            this.Value_Value.Location = new System.Drawing.Point(79, 334);
            this.Value_Value.Name = "Value_Value";
            this.Value_Value.Size = new System.Drawing.Size(202, 20);
            this.Value_Value.TabIndex = 4;
            // 
            // Description_Check
            // 
            this.Description_Check.AutoSize = true;
            this.Description_Check.Location = new System.Drawing.Point(294, 195);
            this.Description_Check.Name = "Description_Check";
            this.Description_Check.Size = new System.Drawing.Size(79, 17);
            this.Description_Check.TabIndex = 5;
            this.Description_Check.Text = "Description";
            this.Description_Check.UseVisualStyleBackColor = true;
            // 
            // Players_Check
            // 
            this.Players_Check.AutoSize = true;
            this.Players_Check.Location = new System.Drawing.Point(294, 265);
            this.Players_Check.Name = "Players_Check";
            this.Players_Check.Size = new System.Drawing.Size(60, 17);
            this.Players_Check.TabIndex = 6;
            this.Players_Check.Text = "Players";
            this.Players_Check.UseVisualStyleBackColor = true;
            // 
            // Trophies_Check
            // 
            this.Trophies_Check.AutoSize = true;
            this.Trophies_Check.Location = new System.Drawing.Point(294, 301);
            this.Trophies_Check.Name = "Trophies_Check";
            this.Trophies_Check.Size = new System.Drawing.Size(67, 17);
            this.Trophies_Check.TabIndex = 7;
            this.Trophies_Check.Text = "Trophies";
            this.Trophies_Check.UseVisualStyleBackColor = true;
            // 
            // Value_Check
            // 
            this.Value_Check.AutoSize = true;
            this.Value_Check.Location = new System.Drawing.Point(294, 337);
            this.Value_Check.Name = "Value_Check";
            this.Value_Check.Size = new System.Drawing.Size(53, 17);
            this.Value_Check.TabIndex = 8;
            this.Value_Check.Text = "Value";
            this.Value_Check.UseVisualStyleBackColor = true;
            // 
            // Add_Team
            // 
            this.Add_Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Team.Location = new System.Drawing.Point(397, 114);
            this.Add_Team.Name = "Add_Team";
            this.Add_Team.Size = new System.Drawing.Size(75, 51);
            this.Add_Team.TabIndex = 9;
            this.Add_Team.Text = "Add Team";
            this.Add_Team.UseVisualStyleBackColor = true;
            this.Add_Team.Click += new System.EventHandler(this.Add_Team_Click);
            // 
            // Update_Team
            // 
            this.Update_Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Team.Location = new System.Drawing.Point(397, 211);
            this.Update_Team.Name = "Update_Team";
            this.Update_Team.Size = new System.Drawing.Size(75, 51);
            this.Update_Team.TabIndex = 10;
            this.Update_Team.Text = "Update Team";
            this.Update_Team.UseVisualStyleBackColor = true;
            this.Update_Team.Click += new System.EventHandler(this.Update_Team_Click);
            // 
            // See_Teams
            // 
            this.See_Teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.See_Teams.Location = new System.Drawing.Point(397, 21);
            this.See_Teams.Name = "See_Teams";
            this.See_Teams.Size = new System.Drawing.Size(75, 51);
            this.See_Teams.TabIndex = 11;
            this.See_Teams.Text = "See Teams";
            this.See_Teams.UseVisualStyleBackColor = true;
            this.See_Teams.Click += new System.EventHandler(this.See_Teams_Click);
            // 
            // Delete_Team
            // 
            this.Delete_Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Team.Location = new System.Drawing.Point(397, 303);
            this.Delete_Team.Name = "Delete_Team";
            this.Delete_Team.Size = new System.Drawing.Size(75, 51);
            this.Delete_Team.TabIndex = 12;
            this.Delete_Team.Text = "Delete Team";
            this.Delete_Team.UseVisualStyleBackColor = true;
            this.Delete_Team.Click += new System.EventHandler(this.Delete_Team_Click);
            // 
            // Teams
            // 
            this.Teams.Location = new System.Drawing.Point(12, 12);
            this.Teams.Multiline = true;
            this.Teams.Name = "Teams";
            this.Teams.ReadOnly = true;
            this.Teams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Teams.Size = new System.Drawing.Size(361, 162);
            this.Teams.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Players";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trophies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 368);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.Delete_Team);
            this.Controls.Add(this.See_Teams);
            this.Controls.Add(this.Update_Team);
            this.Controls.Add(this.Add_Team);
            this.Controls.Add(this.Value_Check);
            this.Controls.Add(this.Trophies_Check);
            this.Controls.Add(this.Players_Check);
            this.Controls.Add(this.Description_Check);
            this.Controls.Add(this.Value_Value);
            this.Controls.Add(this.Trophies_Value);
            this.Controls.Add(this.Players_Value);
            this.Controls.Add(this.Description_Value);
            this.Controls.Add(this.Name_Value);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_Value;
        private System.Windows.Forms.TextBox Description_Value;
        private System.Windows.Forms.TextBox Players_Value;
        private System.Windows.Forms.TextBox Trophies_Value;
        private System.Windows.Forms.TextBox Value_Value;
        private System.Windows.Forms.CheckBox Description_Check;
        private System.Windows.Forms.CheckBox Players_Check;
        private System.Windows.Forms.CheckBox Trophies_Check;
        private System.Windows.Forms.CheckBox Value_Check;
        private System.Windows.Forms.Button Add_Team;
        private System.Windows.Forms.Button Update_Team;
        private System.Windows.Forms.Button See_Teams;
        private System.Windows.Forms.Button Delete_Team;
        private System.Windows.Forms.TextBox Teams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

