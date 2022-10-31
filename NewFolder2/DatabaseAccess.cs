using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LibrarySystemManagement.NewFolder2
{
    //internal class DatabaseAccess
    //{
    //    SqlConnection sQL;

    //    SqlCommand cmd;
    //    string str = "Data Source=localhost;Initial Catalog=QLNhaSach;User ID=sa;Password=huan1561996";
    //    DataTable dt = new DataTable();
    //    SqlDataAdapter adapter = new SqlDataAdapter();
    //    SqlDataReader dr;

    //    public DataTable dataTable(string query)
    //    {
    //        cmd = sQL.CreateCommand();
    //        cmd.CommandText = query;
    //        adapter.SelectCommand = cmd;
    //        dt.Clear();
    //        adapter.Fill(dt);
    //        return dt;
    //    }
    //    public DataTable ReadBookData()
    //    {
    //        cmd = sQL.CreateCommand();
    //        cmd.CommandText = "Select * from book";
    //        adapter.SelectCommand = cmd;
    //        dt.Clear();
    //        adapter.Fill(dt);
    //        return dt;
    //    }
    //    public void hienThi()
    //    {
    //        dr = cmd.ExecuteReader();

    //    }
    //    public void open()
    //    {
    //        sQL = new SqlConnection(str);
    //        sQL.Open();
    //    }
    //}
}
