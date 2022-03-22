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
    public partial class Form2 : Form
    {
        public Form2(String username)
        {
            InitializeComponent();
            label1.Text = "Hello " + username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
