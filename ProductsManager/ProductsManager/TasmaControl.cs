using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProductsManager
{
    class TasmaControl
    {
        private SqlConnection conn = new SqlConnection(@"Server=.;Database=QLBH;Integrated Security=true");
        public DataTable queryAdapterS(string table)
        {
            string query = String.Format("SELECT * FROM {0}", table);
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable queryAdapterS(string table, string idname, object id)
        {
            string query = String.Format("SELECT * FROM {0} WHERE {1}={2}", table, idname, id);
            SqlDataAdapter adap = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public void activeCommand(string query, string alert, string error)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Connection.Open();
            MessageBox.Show(
                (cmd.ExecuteNonQuery() != 0) ? alert : error
            );
            cmd.Connection.Close();
        }
    }
}
