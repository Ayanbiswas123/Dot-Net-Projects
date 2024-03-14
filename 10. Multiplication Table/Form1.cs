namespace Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int num = int.Parse(textBox1.Text);
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(num + " x " + i + " = " + (i * num));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}