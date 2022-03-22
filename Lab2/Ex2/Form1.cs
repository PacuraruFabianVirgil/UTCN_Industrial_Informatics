namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(path: "objects.txt");
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                    listBox1.Items.Add(line);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Text != "")
            {
                listBox2.Items.Add(listBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}