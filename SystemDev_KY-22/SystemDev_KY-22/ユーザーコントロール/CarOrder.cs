using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SystemDev_KY_22
{
    public partial class CarOrder : UserControl
    {
        OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト
        DataTable dt = new DataTable();
        public CarOrder()
        {
            InitializeComponent();
        }

        private void CarOrder_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
               @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
             
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
           dt.Clear();
        }
    }
}
