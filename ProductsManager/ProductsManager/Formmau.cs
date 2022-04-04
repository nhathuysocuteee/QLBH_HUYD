using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlClient;

namespace ProductsManager
{
    public partial class Formmau : Form
    {
        public Formmau()
        {
            InitializeComponent();
        }
        public void buocdl_gv()
        {
            dataGridView1.DataSource = cls_hanghoa.selectHH();
        }
        private void Formmau_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
