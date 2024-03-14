using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multipage
{
    public partial class Form2 : Form
    {
        public int a = 0;
        public Form2(int val)
        {
            this.a = val;
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sum = int.Parse(textBox2.Text) + a;
            textBox3.Text = sum.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
