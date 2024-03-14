using System.Data.SqlClient;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1.Address of SQL server and database

            string connectingString = "Data Source=DESKTOP-A72DUVD\\SQLEXPRESS;Initial Catalog=ayandb;Integrated Security=True";

            // 2. Establish connection

            SqlConnection con = new SqlConnection(connectingString);

            // 3. open connection
            con.Open();

            // 4. prepare query
            string firstname = textBox1.Text;
            string lastname = textBox2.Text;
            string s = textBox3.Text;
            string Query = "insert into schooldb (firstname,lastname,saddress) values ('"+ firstname + "','"+ lastname + "','"+ s + "')";
            // 5. ececute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            // 6. close connection
            con.Close();

            MessageBox.Show("Data has been saved");
            textBox1.Text = "";



        }
    }
}