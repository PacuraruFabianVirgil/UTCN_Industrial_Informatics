namespace TemaLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void signin_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("login.txt");
            String line, user = "", pass = "";
            Boolean userExists = false;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            while ((line = reader.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ' ')
                    {
                        user = line.Substring(0, i);
                        pass = line.Substring(i + 1);
                    }
                }
                if (user == username.Text)
                {
                    if (pass == password.Text)
                    {
                        Form2 form2 = new Form2(username.Text);
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        userExists = true;
                    }
                }
            }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (userExists)
            {
                feedback.Text = "Wrong password";
            }
            else
            {
                feedback.Text = "User not found";
            }
            reader.Close();
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}