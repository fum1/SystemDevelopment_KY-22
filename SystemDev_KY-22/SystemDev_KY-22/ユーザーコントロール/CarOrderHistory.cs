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
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();
                cn.ConnectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
                dataload();
            }
        }

        private void dataload()
        {
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT 発注テーブル.発注ID, 発注テーブル.発注年月日, 発注テーブル.仕入先ID, 仕入先マスタ.商品ID, 発注テーブル.個数, 発注テーブル.社員ID " +
                                     "FROM 商品マスタ INNER JOIN(社員マスタ INNER JOIN(仕入先マスタ INNER JOIN 発注テーブル ON 仕入先マスタ.仕入先ID = 発注テーブル.仕入先ID) ON 社員マスタ.社員ID = 発注テーブル.社員ID) ON 商品マスタ.商品ID = 仕入先マスタ.商品ID",cn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();


        }

        private void btn_CarNameSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand("SELECT 発注テーブル.発注ID, 発注テーブル.発注年月日, 発注テーブル.仕入先ID, 仕入先マスタ.商品ID, 発注テーブル.個数, 発注テーブル.社員ID " +
                                 "FROM 商品マスタ INNER JOIN(社員マスタ INNER JOIN(仕入先マスタ INNER JOIN 発注テーブル ON 仕入先マスタ.仕入先ID = 発注テーブル.仕入先ID) ON 社員マスタ.社員ID = 発注テーブル.社員ID) ON 商品マスタ.商品ID = 仕入先マスタ.商品ID " +
                                 "WHERE 発注年月日=@dtime1 ORDER BY 発注ID", cn);  
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //日時を設定しているコントロールを設定
            cmd.Parameters.AddWithValue("@dtime1", DateTime.Parse(dateTimePicker1.Value.ToString()));
            

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cn.Close();
            cn.Open();

        }
    }
}
