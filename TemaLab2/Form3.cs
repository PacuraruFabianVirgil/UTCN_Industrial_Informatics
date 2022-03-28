using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaLab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void register_Click(object sender, EventArgs e)
        {
            DateTime dayOfBirth = date.Value;
            DateTime currentDay = DateTime.Now;
            Boolean pass = false;
            if (currentDay.Year - dayOfBirth.Year > 18)
            {
                pass = true;
            } else if (currentDay.Year == dayOfBirth.Year)
            {
                if (currentDay.Month > dayOfBirth.Month)
                {
                    pass = true;
                } else if (currentDay.Month == dayOfBirth.Month)
                {
                    if (currentDay.Day >= dayOfBirth.Day)
                    {
                        pass = true;
                    }
                }
            }
            if((password.Text == checkPassword.Text) && (pass))
            {
                StreamWriter writer = new StreamWriter("login.txt", true);
                writer.WriteLine();
                writer.Write(username.Text+" "+password.Text);
                writer.Close();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            } else
            {
                if(password.Text != checkPassword.Text)
                {
                    wrongPassword.Text = "The passwords do not match";
                } else wrongPassword.Text = "";
                if (!pass)
                {
                    age.Text = "You're not old enough";
                } else age.Text = "";
            }
            
        }
    }
}
