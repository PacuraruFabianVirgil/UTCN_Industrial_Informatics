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
            Boolean agePass = false;
            if (currentDay.Year - dayOfBirth.Year > 18)
            {
                agePass = true;
            } else if (currentDay.Year - dayOfBirth.Year == 18)
            {
                if (currentDay.Month > dayOfBirth.Month)
                {
                    agePass = true;
                } else if (currentDay.Month == dayOfBirth.Month)
                {
                    if (currentDay.Day >= dayOfBirth.Day)
                    {
                        agePass = true;
                    }
                }
            }
            StreamReader reader = new StreamReader("login.txt");
            String line, user = "", pass = "";
            Boolean userExists = false;
            while ((line = reader.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ' ')
                    {
                        user = line.Substring(0, i);
                    }
                }
                if (user == username.Text)
                {
                    userExists = true;
                }
            }
            reader.Close();
            if ((password.Text == checkPassword.Text) && (password.Text != "") && 
                (username.Text != "") && agePass && (!userExists))
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
                if(username.Text == "")
                {
                    username.PlaceholderText = "don't leave empty";
                }
                if(password.Text == "")
                {
                    password.PlaceholderText = "don't leave empty";
                }
                if(checkPassword.Text == "")
                {
                    checkPassword.PlaceholderText = "don't leave empty";
                }
                if(userExists)
                {
                    wrongPassword.Text = "The user already exists";
                } else if (password.Text != checkPassword.Text)
                {
                    wrongPassword.Text = "The passwords do not match";
                } else wrongPassword.Text = "";
                if (!agePass)
                {
                    age.Text = "You're not old enough";
                } else age.Text = "";
            }
            
        }
    }
}
