using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace ADB_1_7_DA1
{
    public class DATAPRO
    {
        private string Constr = "Data Source=MINHNHUT-HOME;Initial Catalog=DoAn1_CSDL_NC;Integrated Security=True";

        public DataTable ExecuteQuery(string query )
        {
            DataTable data = new DataTable();
            using (SqlConnection con= new SqlConnection(Constr))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);              
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                con.Close();
            }
            return data; 
        }
        public string StrCon()
        {
            return Constr;
        }
    }
}
