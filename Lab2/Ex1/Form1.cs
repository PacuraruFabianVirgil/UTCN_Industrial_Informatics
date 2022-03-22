namespace Ex1
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

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "login.txt");
            {
                string line;
                String user = textBox1.Text;
                String pass = textBox2.Text;
                String username = "";
                String password = "";
                while ((line = streamReader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ' ')
                        {
                            username = line.Substring(0, i);
                            password = line.Substring(i + 1);
                        }
                    }
                    if ((user == username) && (pass == password))
                    {
                        Form2 secondForm = new Form2(user);
                        secondForm.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}