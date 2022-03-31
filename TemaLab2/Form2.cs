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
    public partial class Form2 : Form
    {
        String user;
        String fileName;
        String fileExtension;
        String[] imagePaths;
        public Form2(String user)
        {
            this.user = user;
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
                String path = opnfd.FileName;
                for(int i = path.Length-1; i >= 0; i--)
                {
                    if(path[i] == '.')
                    {
                        fileExtension = path.Substring(i);
                    }
                    if(path[i] == '\\')
                    {
                        fileName = path.Substring(i+1);
                        break;
                    }
                }
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
            String folder;
            if (see.Checked)
            {
                folder = user + "/";
            }
            else folder = "general/";
            if(pictureBox1.Image == pictureBox1.InitialImage)
            {
                succes.ForeColor = Color.Red;
                succes.Text = "Choose a picture";
            } else if(newName.Visible == false)
            {
                pictureBox1.Image.Save(folder + fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                succes.ForeColor = Color.Green;
                succes.Text = "Picture Stored";
            } else if (newName.Text == "")
            {
                newName.PlaceholderText = "don't leave empty";
                succes.ForeColor = Color.Red;
                succes.Text = "Picture Not Stored";
            } else
            {
                pictureBox1.Image.Save(folder + newName.Text + fileExtension, System.Drawing.Imaging.ImageFormat.Jpeg);
                succes.ForeColor = Color.Green;
                succes.Text = "Picture Stored";
            }     
        }

        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            pictures.Items.Clear();
            string[] generalFilePaths = Directory.GetFiles("general");
            string[] privateFilePaths = Directory.GetFiles(user);
            imagePaths = new string[generalFilePaths.Length + privateFilePaths.Length];
            for (int i = 0; i < privateFilePaths.Length; i++)
            {
                int end = 0;
                for (int j = privateFilePaths[i].Length - 1; j >= 0; j--)
                {
                    if (privateFilePaths[i][j] == '.')
                    {
                        end = j;
                    }
                    if (privateFilePaths[i][j] == '\\')
                    {
                        pictures.Items.Add(privateFilePaths[i].Substring(j + 1, Math.Min(end - j - 1, 18)));
                        imagePaths[i] = user + "/" + privateFilePaths[i].Substring(j + 1);
                        break;
                    }
                }
            }
            for (int i = 0; i < generalFilePaths.Length; i++)
            {
                int end = 0;
                for (int j = generalFilePaths[i].Length - 1; j >= 0; j--)
                {
                    if (generalFilePaths[i][j] == '.')
                    {
                        end = j;
                    }
                    if (generalFilePaths[i][j] == '\\')
                    {
                        pictures.Items.Add(generalFilePaths[i].Substring(j + 1, Math.Min(end - j - 1, 18)));
                        imagePaths[privateFilePaths.Length + i] = "general/" + generalFilePaths[i].Substring(j + 1);
                        break;
                    }
                }
            }
        }

        private void pictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = imagePaths[pictures.SelectedIndex];
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}