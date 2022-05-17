using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace lancuoiiiii
{
    internal class Functions
    {
        public static SqlConnection Conn;
        public static string Connstring;
        public static void Connect ()
        {
            Connstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\lancuoiiiii\\database\\QuanLyBanHangg.mdf;Integrated Security=True";
            Conn = new SqlConnection ();
            Conn.ConnectionString = Connstring;
            Conn.Open ();
            MessageBox.Show("Ket noi thanh cong");

        
        }
        public static void Close ()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close ();
                Conn.Dispose ();
                Conn = null;
            }
        }
        public static DataTable Getdatatotable(string sql)
        {
            SqlDataAdapter a = new SqlDataAdapter ();
            a.SelectCommand = new SqlCommand ();
            a.SelectCommand.Connection = Functions.Conn;
            a.SelectCommand.CommandText = sql;

            DataTable bang = new DataTable ();
            a.Fill (bang);
            return bang;
        }
        public static bool Checkkey (string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.Conn);
            DataTable table = new DataTable();
            Mydata.Fill (table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Conn; 
            cmd.CommandText = sql; 
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
    }
}
