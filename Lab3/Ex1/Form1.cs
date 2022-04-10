using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
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

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            var universitate = new Universitati
            {
                Id = int.Parse(Id.Text),
                NameUniv = NameUniv.Text,
                City = City.Text,
                Code = int.Parse(Code.Text)
            };
            if (entities.Universitatis.Find(universitate.Code)==null)
            {
                entities.Universitatis.Add(universitate);
                entities.SaveChanges();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var code = int.Parse(Code.Text);
            var universitate = entities.Universitatis.Find(code);
            if (universitate != null)
            {
                entities.Universitatis.Remove(universitate);
                entities.SaveChanges();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var code = int.Parse(Code.Text);
            var universitate = entities.Universitatis.Find(code);
            if (universitate != null)
            {
                if (Update_Id.Checked) universitate.Id = int.Parse(Id.Text);
                if (Update_Name.Checked) universitate.NameUniv = NameUniv.Text;
                if (Update_City.Checked) universitate.City = City.Text;
                entities.SaveChanges();
            }
        }
    }
}