using System;
using System.Windows.Forms;

namespace binary_to_decimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string binary = textBox1.Text;

            int decimalValue = Convert.ToInt32(textBox1.Text,2);
            String octalVaue = Convert.ToString(decimalValue, 8);

            textBox2.Text = decimalValue.ToString();
            textBox3.Text = octalVaue.ToString();
        }
    }
}
