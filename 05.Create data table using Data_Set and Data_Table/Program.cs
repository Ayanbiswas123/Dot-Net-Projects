using System;
using System.Data;

namespace Create_data_table_using_Data_Set_and_Data_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a new Dataset
            DataSet ds = new DataSet();
            //Create a new DataTable
            DataTable dt = new DataTable("Employee");
            dt.Columns.Add("Eid", typeof(int));
            dt.Columns.Add("E_name", typeof(string));
            dt.Rows.Add(1, "Ayan");
            dt.Rows.Add(2,"Raj");
            dt.Rows.Add(3,"Joy");
            ds.Tables.Add(dt);
            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine($"EmployeeID : {row["Eid"]},Name : {row["E_name"]}");
            }
            Console.WriteLine($"{2 * 3}");
            Console.ReadLine();
        }
    }
}
