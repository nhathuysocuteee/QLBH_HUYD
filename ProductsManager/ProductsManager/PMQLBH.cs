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
using SqlClient;
namespace ProductsManager
{
    public partial class PMQLBH : Form
    {
       
        public PMQLBH()
        {
            InitializeComponent();
        }
        public void activeDataSQL()
        {
            dataGV_TTTK.DataSource = cls_hanghoa.selectHH();
            cb_nhacc.DataSource = cls_nhacc.selectNCC();
            cb_nhacc.ValueMember = "MaNCC";
            cb_nhacc.DisplayMember = "TenNCC";
        }
        private void PMQLBH_Load(object sender, EventArgs e)
        {
            activeDataSQL();
        }

        public void timkiemdl()
        {
            if(rad_ttmah.Checked ==  true)
            {
                dataGV_TTTK.DataSource = cls_timkiem.timkiemtheoma(txt_timkiem.Text);
                
            } else if(rad_tttenh.Checked == true)
            {

                dataGV_TTTK.DataSource = cls_timkiem.timkiemtheoten(txt_timkiem.Text);

                
            }
            else if(checkb_tktbd.Checked == true) 
            {
                dataGV_TTTK.DataSource = cls_timkiem.timkiemtheoten(txt_timkiem.Text);
                
            }
            

        }
        private void dataGV_TTTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_nhacc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            timkiemdl();
        }

        private void rad_ttmah_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rad_tttenh_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkb_tktbd_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
