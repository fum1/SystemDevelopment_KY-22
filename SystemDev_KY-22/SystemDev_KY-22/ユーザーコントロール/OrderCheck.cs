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
    public partial class OrderCheck : UserControl
    {
        OleDbConnection cn;  //コネクションオブジェクト

        public OrderCheck()
        {
            InitializeComponent();
        }

        private void OrderCheck_Load(object sender, EventArgs e)
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
                new OleDbDataAdapter("SELECT 受注テーブル.受注ID, 受注テーブル.注文ID, 注文テーブル.数量, 注文テーブル.商品詳細ID, 注文テーブル.在庫減フラグ, 注文テーブル.店舗ID, 注文テーブル.注文日, 受注テーブル.処理 FROM 受注テーブル INNER JOIN 注文テーブル ON 受注テーブル.受注ID = 注文テーブル.注文ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_ordercheck.DataSource = dt;
            dgv_ordercheck.AllowUserToAddRows = false;    //最下行を非表示
            dgv_ordercheck.AutoResizeColumns();           //列の幅の自動調整
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                   new OleDbCommand("SELECT 顧客ID , 氏名 , 住所 , 郵便番号 , 電話番号 , 性別 , 生年月日 FROM 顧客マスタ WHERE 顧客ID = @顧客ID ORDER BY 顧客ID", cn);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@受注ID", mxt_productname.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            mxt_productname.ResetText();
            dtp_orderdate1.ResetText();
            dtp_orderdate2.ResetText();
        }

        private void dgv_ordercheck_Click(object sender, EventArgs e)
        {

        }
    }
}
