using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SqlClient
{
    public class cls_timkiem
    {
        public static DataTable timkiemtheoma(string timk_txt)
        {
            DataTable dt = new DataTable();
            string str = String.Format("SELECT * FROM HANG_HOA where MaHH like '%{0}%'", timk_txt);
            SqlDataAdapter adap = new SqlDataAdapter(str, cls_ketnoi.conn);
            adap.Fill(dt);
            return dt;
        }
        public static DataTable timkiemtheoten(string timk_txt)
        {
            DataTable dt = new DataTable();
            string str = String.Format("SELECT * FROM HANG_HOA where TenHH like '%{0}%'", timk_txt);
            SqlDataAdapter adap = new SqlDataAdapter(str, cls_ketnoi.conn);
            adap.Fill(dt);
            return dt;
        }
    }
}
