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

namespace SystemDev_KY_22.ユーザーコントロール
{
    public partial class CarOrderHistory : UserControl
    {
        OleDbConnection cn; //コネクションオブジェクト
        public CarOrderHistory()
        {
            InitializeComponent();
        }
        private void CarOrderHistory_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection();
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
            dataload();
        }

        private void dataload()
        {
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT 発注テーブル.発注ID, 発注テーブル.発注年月日, 発注テーブル.仕入先ID, 発注テーブル.個数, 発注テーブル.社員ID" +
                                     "FROM 社員マスタ INNER JOIN(仕入先マスタ INNER JOIN 発注テーブル ON 仕入先マスタ.仕入先ID = 発注テーブル.仕入先ID) ON 社員マスタ.社員ID = 発注テーブル.社員ID",cn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();

            this.cmd_Supplier.DataSource = dt;
            this.cmd_Supplier.DisplayMember = "仕入先ID";
            this.cmd_Supplier.ValueMember = "仕入先ID";

            this.cmd_Product.DataSource = dt;
            this.cmd_Product.DisplayMember = "商品ID";
            this.cmd_Product.ValueMember = "商品ID";

            this.cmd_Emp.DataSource = dt;
            this.cmd_Emp.DisplayMember = "社員ID";
            this.cmd_Emp.ValueMember = "社員ID";
        }

        private void btn_Seach_Click(object sender, EventArgs e)
        {
            //cmd.Connection = cn;
            //OleDbDataAdapter da = new OleDbDataAdapter();
            //da.SelectCommand = cmd;

            try
            {
                OleDbCommand cmd
                = new OleDbCommand("SELECT 発注テーブル.発注ID, 発注テーブル.発注年月日, 発注テーブル.仕入先ID, 発注テーブル.個数, 発注テーブル.社員ID" +
                                   "FROM 社員マスタ INNER JOIN(仕入先マスタ INNER JOIN 発注テーブル ON 仕入先マスタ.仕入先ID = 発注テーブル.仕入先ID) ON 社員マスタ.社員ID = 発注テーブル.社員ID" +
                                   "WHERE 仕入先ID = @仕入先ID OR 商品ID = @商品ID OR 社員ID = @社員ID ORDER BY 発注ID", cn);
            }

            catch
            {
                MessageBox.Show("データはありません");
                return;
            }

            //cmd.Parameters.AddWithValue("@dtime", DataTime.Parse(dateTimePicker1.Value.ToString()));
            //cmd.Parameters.AddWithValue("@仕入先ID", cmd_Supplier.Text);
            //cmd.Parameters.AddWithValue("@商品ID", cmd_Product.Text);
            //cmd.Parameters.AddWithValue("@社員ID", cmd_Emp.Text);
        }
    }
}
