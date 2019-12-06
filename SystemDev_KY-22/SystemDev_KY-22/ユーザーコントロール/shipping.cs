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
    public partial class shipping : UserControl
    {
        OleDbConnection cn = new OleDbConnection(); //コネクションオブジェクト

        public shipping()
        {
            InitializeComponent();
        }

        private void btn_shipping_Click(object sender, EventArgs e)
        {
            //入力された日時を登録する
            //コントロールをクリアする
        }

        private void btn_IDcheck_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand("SELECT 商品詳細ID , 仕入先ID , 走行距離 , 車種 ," +
                "発売日 , オプション , 商品 , 色 , モデル , 実売価格 , 数量 " +
                "FROM 社員マスタ WHERE 社員ID = @社員ID ORDER BY 社員ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@商品詳細ID", txt_Product.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                DataRow dr = dt.Rows[0];

                txt_idhead1.Text = dr["商品詳細"].ToString();
                txt_name1.Text = dr["氏名"].ToString();
                txt_postal1.Text = dr["郵便番号"].ToString();
                txt_address1.Text = dr["住所"].ToString();
                txt_tel1.Text = dr["電話番号"].ToString();
                cmb_sex1.Text = dr["性別"].ToString();
                cmb_department1.Text = dr["部署"].ToString();
                cmb_position1.Text = dr["役職"].ToString();
                cmb_clerk1.Text = dr["店舗ID"].ToString();
                mtextB_Pass.Text = dr["パスワード"].ToString();
                MessageBox.Show(dr["商品詳細ID"].ToString() + Environment.NewLine + dr["仕入先ID"].ToString() + Environment.NewLine + dr["走行距離"].ToString() + Environment.NewLine + dr["車種"].ToString() + Environment.NewLine + dr["発売日"].ToString() + Environment.NewLine + dr["オプション"].ToString() + Environment.NewLine +, "IDチェック");
                cn.Close();

                txt_idhead1.Text = txt_id1.Text.Substring(0, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IDが見つかりませんでした");
                cn.Close();                //コネクションを閉じる
                return;
            }
        }

        private void shipping_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
        }
    }
}
