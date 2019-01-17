using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using MySql.Data.MySqlClient;
namespace ADO
{
    public static class DBL
    {
        //selectTable 显示全表
        //select
        
        
        public static void SelectAdd()
        {
            using (MySqlConnection conn = new MySqlConnection("server=192.168.137.222; database=annoy; user=root; password=123456;"))
            {
                conn.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(new MySqlCommand("select * from logininfo", conn)))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "LoginInfo");

                    foreach(DataRow row in dataSet.Tables["LoginInfo"].Rows)
                    {
                        Console.WriteLine("{0}|{1}|{2}|{3}", row["Id"].ToString(), row["LoginName"].ToString(), row["LoginPwd"].ToString(), row["LoginDate"].ToString());
                    }
                }

                conn.Close();
            }
        }
 
    }
}
