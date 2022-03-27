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
            MaximizeBox = false;
        }

        private void login_Click(object sender, EventArgs e)
        {
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
                        pass = line.Substring(i + 1);
                    }
                }
                if (user == username.Text)
                {
                    if (pass == password.Text)
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    } else
                    {
                        userExists = true;
                    }
                }
            }
            if (userExists)
            {
                feedback.Text = "Wrong password";
            } else
            {
                feedback.Text = "User not found";
            }
        }
    }
}