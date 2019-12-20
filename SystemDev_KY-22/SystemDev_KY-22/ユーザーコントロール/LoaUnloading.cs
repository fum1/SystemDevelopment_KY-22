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
    public partial class LoaUnloading : UserControl
    {
        OleDbConnection cn;

        public LoaUnloading()
        {
            InitializeComponent();
        }

        private void LoaUnloading_Load(object sender, EventArgs e)
        {

        }

        private void dataload()   //カスタム関数
        {
            if (rbt_storing.Checked)
            {
                OleDbDataAdapter da =
                    new OleDbDataAdapter("SELECT * FROM 入庫テーブル", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_loaunloading.DataSource = dt;
                dgv_loaunloading.AllowUserToAddRows = false;    //最下行を非表示
                dgv_loaunloading.AutoResizeColumns();           //列の幅の自動調整
            }
            else
            {
                OleDbDataAdapter da =
                    new OleDbDataAdapter("SELECT * FROM 出庫テーブル", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_loaunloading.DataSource = dt;
                dgv_loaunloading.AllowUserToAddRows = false;    //最下行を非表示
                dgv_loaunloading.AutoResizeColumns();           //列の幅の自動調整
            }

        }

        private void rbt_storing_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_storing.Checked) dataload();
        }

        private void rbt_Issue_CheckedChanged(object sender, EventArgs e)
        {
            if(rbt_Issue.Checked) dataload();
        }

        private void LoaUnloading_Load_1(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();
                cn.ConnectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
                dataload();
            }
        }
    }
}
