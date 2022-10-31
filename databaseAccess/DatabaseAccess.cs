using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibrarySystemManagement.NewFolder2
{
    internal class DatabaseAccess
    {
        SqlConnection sQL;

        SqlCommand cmd;
        // nếu chạy mà lỗi thì bạn sửa lại những thông tin này nha
        string datasource = "DESKTOP-VFCUK2M";
        string databaseName = "QLNhaSach";
        string username = "ducan";
        string password = "123";
        string str = null;
        DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataReader dr;

        public DatabaseAccess()
        {
            str = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}",
                datasource, databaseName, username, password);
        }

        public DataTable dataTable(string query)
        {
            str = string.Format("Data Source={0};Initial Catalog={1);User ID={2};Password={3}", 
                datasource, databaseName, username, password);
            open();
            cmd = sQL.CreateCommand();
            cmd.CommandText = query;
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            return dt;
        }
        public DataTable ReadBookData()
        {
            cmd = sQL.CreateCommand();
            cmd.CommandText = "Select * from book";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            return dt;
        }
        public void hienThi()
        {
            dr = cmd.ExecuteReader();

        }
        public void open()
        {
            sQL = new SqlConnection(str);
            sQL.Open();
        }
    }
}
