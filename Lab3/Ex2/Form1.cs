using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        private II_Lab3_DBEntities entities = new II_Lab3_DBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iI_Lab3_DBDataSet.Universitati' table. You can move, or remove it, as needed.
            this.universitatiTableAdapter.Fill(this.iI_Lab3_DBDataSet.Universitati);
            // TODO: This line of code loads data into the 'iI_Lab3_DBDataSet.Facultati' table. You can move, or remove it, as needed.
            this.facultatiTableAdapter.Fill(this.iI_Lab3_DBDataSet.Facultati);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < entities.Facultatis.Count(); i++)
            {
                entities.Facultatis.Remove(entities.Facultatis.ToArray()[i]);
            }
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                var facultate = new Facultati
                {
                    Id = (int)dataGridView1[0, i].Value,
                    Code = (int)dataGridView1[1, i].Value,
                    NumeFac = (String)dataGridView1[2, i].Value
                };
                if(entities.Universitatis.Find(facultate.Code) != null)
                {
                    entities.Facultatis.Add(facultate);
                }
            }
            entities.SaveChanges();
        }
    }
}
