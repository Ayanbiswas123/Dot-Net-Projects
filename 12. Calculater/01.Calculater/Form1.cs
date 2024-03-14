namespace _01.Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string op;
        int num1, num2, total, result;
        private void button14_Click(object sender, EventArgs e)
        {
            op = "/";
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textBox1.Text);

            if (op == "+")
            {
                result = num1 + num2;
            }
            else if (op == "-")
            {
                result = num1 - num2;
            }
            else if (op == "*")
            {
                result = num1 * num2;
            }
            else if (op == "/")
            {
                result = num1 / num2;
            }
            else
            {
                textBox1.Text = "Wrong";
            };

            textBox1.Text = result.ToString();

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            op = "+";
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            op = "-";
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            op = "*";
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            op = "^";
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            op = "%";
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            num1 = 0;
            num2 = 0;
            result = 0;
        }
    }
}