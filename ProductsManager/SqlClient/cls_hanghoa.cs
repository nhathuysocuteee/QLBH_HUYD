using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SqlClient
{
    public class cls_hanghoa : cls_ketnoi
    {
        public static DataTable selectHH()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM HANG_HOA", cls_ketnoi.conn);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cls_ketnoi.conn.Close();
            }

            return dt;
        }
    }
}
