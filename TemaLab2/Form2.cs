﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.png;*.jpg;*.jpeg;)|*.png;*.jpg;*.jpeg";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "yes")
            {
                label.Visible = true;
                newName.Visible = true;
            } else
            {
                newName.Text = "";
                newName.PlaceholderText = "";
                label.Visible = false;
                newName.Visible = false;
            }
        }

        private void store_Click(object sender, EventArgs e)
        {
            if(pictureBox1.Image == pictureBox1.InitialImage)
            {
                succes.ForeColor = Color.Red;
                succes.Text = "Choose a picture";
            } else if(newName.Visible == false)
            {
                succes.ForeColor = Color.Green;
                succes.Text = "Picture Stored";
            } else if (newName.Text == "")
            {
                newName.PlaceholderText = "don't leave empty";
                succes.ForeColor = Color.Red;
                succes.Text = "Picture Not Stored";
            } else
            {
                succes.ForeColor = Color.Green;
                succes.Text = "Picture Stored";
            }     
        }
    }
}
