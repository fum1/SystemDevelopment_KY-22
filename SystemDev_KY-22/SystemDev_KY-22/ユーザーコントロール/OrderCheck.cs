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
            OleDbCommand cmd = new OleDbCommand("SELECT 受注テーブル.受注ID, 受注テーブル.注文ID, 注文テーブル.数量, 注文テーブル.商品詳細ID, 注文テーブル.在庫減フラグ, 注文テーブル.店舗ID, 注文テーブル.注文日, 受注テーブル.処理 FROM 受注テーブル INNER JOIN 注文テーブル ON 受注テーブル.受注ID = 注文テーブル.注文ID", cn);
            cmd.Connection = cn;
            //cmd.Parameters.AddWithValue("@処理", "1");
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            for(int i = 0;dt.Rows.Count < i; i++)
            {
                if(dt.Rows[i]["処理"].ToString() == "1")
                {
                    dt.Rows[i].Delete();
                }
            }

            dgv_ordercheck.DataSource = dt;
            dgv_ordercheck.AllowUserToAddRows = false;    //最下行を非表示
            dgv_ordercheck.AutoResizeColumns();           //列の幅の自動調整
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                   new OleDbCommand("SELECT 受注テーブル.受注ID, 受注テーブル.注文ID, 注文テーブル.数量, 注文テーブル.商品詳細ID, 注文テーブル.在庫減フラグ, 注文テーブル.店舗ID, 注文テーブル.注文日, 受注テーブル.処理" +
                                    "FROM 受注テーブル INNER JOIN 注文テーブル ON 受注テーブル.受注ID = 注文テーブル.注文ID WHERE 受注ID = @受注ID ORDER BY 受注ID", cn);

            cmd.Parameters.AddWithValue("@処理", "1");
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

        private void btn_end_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("業務の完了を申請します。", "受注完了", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int selectrow = dgv_ordercheck.CurrentCell.RowIndex;                 //選択されている行番号
                OleDbCommand cmd =
                            new OleDbCommand("UPDATE 受注テーブル SET 処理 = @処理 WHERE (受注ID = @受注ID)", cn);
                cmd.Parameters.AddWithValue("@処理", "1");
                cmd.Parameters.AddWithValue("@受注ID", dgv_ordercheck.Rows[selectrow].Cells["受注ID"].Value);
                try
                {
                    cn.Open();                 //コネクションを開く
                    cmd.ExecuteNonQuery();     //SQLを実行
                    cn.Close();                //コネクションを閉じる
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();                //コネクションを閉じる
                    return;
                }

                dataload();                   //データをロードする関数

            }

        }
    }
}
