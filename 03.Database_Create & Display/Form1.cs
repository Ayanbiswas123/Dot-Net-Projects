using System.Data;
using System.Data.SqlClient;


namespace _03.Database_Create___Display
{
    public partial class Form1 : Form
    {
        public void showData()
        {
            // 1.Address of SQL server and database

            string connectingString = "Data Source=DESKTOP-A72DUVD\\SQLEXPRESS;Initial Catalog=ayandb;Integrated Security=True";

            // 2. Establish connection

            SqlConnection con = new SqlConnection(connectingString);

            // 3. open connection
            con.Open();

            // 4. prepare query

            string Query = "select * from database_two_show";
            SqlCommand cmd = new SqlCommand(Query, con);

            // 5. execute query

            var table_data = cmd.ExecuteReader();

            while (table_data.Read())
            {
                dataGridView1.Rows.Add(table_data["id"], table_data["firstname"] + " " + table_data["lastname"], table_data["saddress"], "Edit", "Delete");
            }


            /* Method 1
            DataTable dt = new DataTable();
            dt.Load(table_data);

            dataGridView1.DataSource = dt;*/
            // 6. close connection
            con.Close();
        }
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

            int id = int.Parse(textBox1.Text);
            string firstname = textBox2.Text;
            string lastname = textBox3.Text;
            string saddress = textBox4.Text;
            string Query = "insert into database_two_show(id,firstname,lastname,saddress) values (" + id + ",'" + firstname + "','" + lastname + "','" + saddress + "');";
            // 5. ececute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            // 6. close connection
            con.Close();

            MessageBox.Show("Data has been saved");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dataGridView1.Rows.Clear();
            showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            // 1.Address of SQL server and database

            string connectingString = "Data Source=DESKTOP-A72DUVD\\SQLEXPRESS;Initial Catalog=ayandb;Integrated Security=True";

            // 2. Establish connection

            SqlConnection con = new SqlConnection(connectingString);

            // 3. open connection
            con.Open();

            // 4. prepare query

            string Query = "select * from database_two_show";
            SqlCommand cmd = new SqlCommand(Query, con);

            // 5. execute query

            var table_data = cmd.ExecuteReader();

            while (table_data.Read())
            {
                dataGridView1.Rows.Add(table_data["id"], table_data["firstname"] + " " + table_data["lastname"], table_data["saddress"], "Edit", "Delete");
            }


            /* Method 1
            DataTable dt = new DataTable();
            dt.Load(table_data);

            dataGridView1.DataSource = dt;*/
            // 6. close connection
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1.Address of SQL server and database

            string connectingString = "Data Source=DESKTOP-A72DUVD\\SQLEXPRESS;Initial Catalog=ayandb;Integrated Security=True";

            // 2. Establish connection

            SqlConnection con = new SqlConnection(connectingString);

            // 3. open connection
            con.Open();

            // 4. prepare query

            int id = int.Parse(textBox1.Text);
            string firstname = textBox2.Text;
            string lastname = textBox3.Text;
            string saddress = textBox4.Text;

            string Query = "update database_two_show set firstname = '" + firstname + "', lastname = '" + lastname + "',saddress = '" + saddress + "' where id = " + id + "";
            // 5. ececute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            // 6. close connection
            con.Close();

            MessageBox.Show("Data has been Updated");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            dataGridView1.Rows.Clear();
            showData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1.Address of SQL server and database

            string connectingString = "Data Source=DESKTOP-A72DUVD\\SQLEXPRESS;Initial Catalog=ayandb;Integrated Security=True";

            // 2. Establish connection

            SqlConnection con = new SqlConnection(connectingString);

            // 3. open connection
            con.Open();

            // 4. prepare query
            int id = int.Parse(textBox1.Text);

            string Query = "select * from database_two_show where id = " + id + "";


            // 5. execute query

            SqlCommand cmd = new SqlCommand(Query, con);

            var table_data = cmd.ExecuteReader();

            if (table_data.Read())
            {
                textBox2.Text = table_data["firstname"].ToString();
                textBox3.Text = table_data["lastname"].ToString();
                textBox4.Text = table_data["saddress"].ToString();
            }
            else { MessageBox.Show("No Record Found"); }


            // 6. close connection
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            // Purform Delete Operation

            if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (MessageBox.Show("Do you want to deleted the Record ", " Conform Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // 1.Address of SQL server and database

                    string connectingString = "Data Source=DESKTOP-A72DUVD\\SQLEXPRESS;Initial Catalog=ayandb;Integrated Security=True";

                    // 2. Establish connection

                    SqlConnection con = new SqlConnection(connectingString);

                    // 3. open connection
                    con.Open();

                    // 4. prepare query

                    int id = int.Parse(textBox1.Text);
                    string firstname = textBox2.Text;
                    string lastname = textBox3.Text;
                    string saddress = textBox4.Text;

                    string Query = "delete from database_two_show where id = " + id + "";
                    // 5. ececute query
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();

                    // 6. close connection
                    con.Close();

                    MessageBox.Show("Data has been Deleted");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                    dataGridView1.Rows.Clear();
                    showData();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 1.Address of SQL server and database

            string connectingString = "Data Source=DESKTOP-A72DUVD\\SQLEXPRESS;Initial Catalog=ayandb;Integrated Security=True";

            // 2. Establish connection

            SqlConnection con = new SqlConnection(connectingString);

            // 3. open connection
            con.Open();

            // 4. prepare query

            int id = int.Parse(textBox1.Text);
            string firstname = textBox2.Text;
            string lastname = textBox3.Text;
            string saddress = textBox4.Text;

            string Query = "delete from database_two_show where id = " + id + "";
            // 5. ececute query
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            // 6. close connection
            con.Close();

            MessageBox.Show("Data has been Deleted");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            dataGridView1.Rows.Clear();
            showData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            // 1.Address of SQL server and database

            string connectingString = "Data Source=DESKTOP-A72DUVD\\SQLEXPRESS;Initial Catalog=ayandb;Integrated Security=True";

            // 2. Establish connection

            SqlConnection con = new SqlConnection(connectingString);

            // 3. open connection
            con.Open();

            // 4. prepare query

            string firstname = textBox5.Text;

            string Query = "select * from database_two_show where firstname like '%" + firstname + "%'";
            SqlCommand cmd = new SqlCommand(Query, con);

            // 5. execute query

            var table_data = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (table_data.Read())
            {
                dataGridView1.Rows.Add(table_data["id"], table_data["firstname"] + " " + table_data["lastname"], table_data["saddress"], "Edit", "Delete");
            }

            con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // 1.Address of SQL server and database

            string connectingString = "Data Source=DESKTOP-A72DUVD\\SQLEXPRESS;Initial Catalog=ayandb;Integrated Security=True";

            // 2. Establish connection

            SqlConnection con = new SqlConnection(connectingString);

            // 3. open connection
            con.Open();

            // 4. prepare query

            string firstname = textBox5.Text;

            string Query = "select * from database_two_show where firstname like '%" + firstname + "%'";
            if (int.TryParse(firstname, out _))
            {
                Query += "OR id = " + firstname;
            }



            SqlCommand cmd = new SqlCommand(Query, con);

            // 5. execute query

            var table_data = cmd.ExecuteReader();
            dataGridView1.Rows.Clear();

            while (table_data.Read())
            {
                dataGridView1.Rows.Add(table_data["id"], table_data["firstname"] + " " + table_data["lastname"], table_data["saddress"], "Edit", "Delete");
            }

            con.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("hi", "Hello", MessageBoxButtons.OKCancel)== DialogResult.OK)
            {
                MessageBox.Show("ok press");
            }
            else
            {
                MessageBox.Show(" cancel pressed");
            }
        }
    }
}