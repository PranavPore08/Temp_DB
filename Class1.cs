using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace WinFormsApp1
{
    internal class Class1
    {
        SqlCommand cmd;
        SqlConnection s=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\localDB.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt;
        SqlDataAdapter adpt;
        SqlCommandBuilder bld;
        public int Add_data(int id,string name) {
            s.Open();
            String query = "insert into Temp values("+id+",'"+name+"')";
            cmd = new SqlCommand(query, s);
            int no = cmd.ExecuteNonQuery();
            s.Close();
            return no;
        }
        public DataTable Display()
        {
            String query = "Select * from Temp";
            s.Open();
            adpt = new SqlDataAdapter(query,s);
            bld = new SqlCommandBuilder(adpt);
            dt = new DataTable();
            adpt.Fill(dt);
            s.Close();
            return dt;
        }

        public int Update_data(int id, string name)
        {
            s.Open();
            String query = "update Temp set name='" + name + "' where ID="+id;
            cmd = new SqlCommand(query, s);
            int no = cmd.ExecuteNonQuery();
            s.Close();
            return no;
        }

        public int Delete_user(int id)
        {
            s.Open();
            String query = "delete from Temp where ID=" + id;
            cmd = new SqlCommand(query, s);
            int no = cmd.ExecuteNonQuery();
            s.Close();
            return no;
        }
    }
}
