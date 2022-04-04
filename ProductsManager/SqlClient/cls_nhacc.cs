using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SqlClient
{
    public class cls_nhacc
    {
        public static DataTable selectNCC()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM NHA_CC", cls_ketnoi.conn);
            adap.Fill(dt);
            return dt;
        }
        
    }
}
