using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        ServiceReference1.WebService1SoapClient server = new ServiceReference1.WebService1SoapClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void See_Teams_Click(object sender, EventArgs e)
        {
            List<String> teams = server.GetElements();
            Teams.Clear();
            foreach (String team in teams)
            {
                Teams.AppendText(team+"\r\n");
            }
        }

        private void Add_Team_Click(object sender, EventArgs e)
        {
            server.Add(Name_Value.Text, Description_Value.Text, Int32.Parse(Players_Value.Text),
                Int32.Parse(Trophies_Value.Text), (long)Convert.ToDouble(Value_Value.Text));
        }

        private void Update_Team_Click(object sender, EventArgs e)
        {
            if (Description_Check.Checked)
            {
                server.ModifyDescription(Name_Value.Text, Description_Value.Text);
            }
            if (Players_Check.Checked)
            {
                server.ModifyPlayers(Name_Value.Text, Int32.Parse(Players_Value.Text));
            }
            if (Trophies_Check.Checked)
            {
                server.ModifyTrophies(Name_Value.Text, Int32.Parse(Trophies_Value.Text));
            }
            if(Value_Check.Checked)
            {
                server.ModifyValue(Name_Value.Text, (long)Convert.ToDouble(Value_Value.Text));
            }
        }

        private void Delete_Team_Click(object sender, EventArgs e)
        {
            server.Delete(Name_Value.Text);
        }
    }
}
