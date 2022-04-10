namespace Ex2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facultatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iI_Lab3_DBDataSet = new Ex2.II_Lab3_DBDataSet();
            this.iILab3DBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultatiTableAdapter = new Ex2.II_Lab3_DBDataSetTableAdapters.FacultatiTableAdapter();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.universitatiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universitatiTableAdapter = new Ex2.II_Lab3_DBDataSetTableAdapters.UniversitatiTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.numeFacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iI_Lab3_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iILab3DBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitatiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.numeFacDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facultatiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(345, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // facultatiBindingSource
            // 
            this.facultatiBindingSource.DataMember = "Facultati";
            this.facultatiBindingSource.DataSource = this.iI_Lab3_DBDataSet;
            // 
            // iI_Lab3_DBDataSet
            // 
            this.iI_Lab3_DBDataSet.DataSetName = "II_Lab3_DBDataSet";
            this.iI_Lab3_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iILab3DBDataSetBindingSource
            // 
            this.iILab3DBDataSetBindingSource.DataSource = this.iI_Lab3_DBDataSet;
            this.iILab3DBDataSetBindingSource.Position = 0;
            // 
            // facultatiTableAdapter
            // 
            this.facultatiTableAdapter.ClearBeforeFill = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(225, 228);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save Changes";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(48, 228);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(115, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete selected row";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // universitatiBindingSource
            // 
            this.universitatiBindingSource.DataMember = "Universitati";
            this.universitatiBindingSource.DataSource = this.iILab3DBDataSetBindingSource;
            // 
            // universitatiTableAdapter
            // 
            this.universitatiTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.DataSource = this.universitatiBindingSource;
            this.codeDataGridViewTextBoxColumn.DisplayMember = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeDataGridViewTextBoxColumn.ValueMember = "Code";
            // 
            // numeFacDataGridViewTextBoxColumn
            // 
            this.numeFacDataGridViewTextBoxColumn.DataPropertyName = "NumeFac";
            this.numeFacDataGridViewTextBoxColumn.HeaderText = "NumeFac";
            this.numeFacDataGridViewTextBoxColumn.Name = "numeFacDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 263);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultatiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iI_Lab3_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iILab3DBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universitatiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iILab3DBDataSetBindingSource;
        private II_Lab3_DBDataSet iI_Lab3_DBDataSet;
        private System.Windows.Forms.BindingSource facultatiBindingSource;
        private II_Lab3_DBDataSetTableAdapters.FacultatiTableAdapter facultatiTableAdapter;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.BindingSource universitatiBindingSource;
        private II_Lab3_DBDataSetTableAdapters.UniversitatiTableAdapter universitatiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeFacDataGridViewTextBoxColumn;
    }
}

