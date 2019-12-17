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
    public partial class Item : UserControl
    {
        OleDbConnection cn; //コネクションオブジェクト
        DataTable dt;

        private int itemID;
        private int ProductID;

        public Item()
        {
            InitializeComponent();
        }

       

        private void Item_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection();
            cn.ConnectionString =
                       @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
        }
        private void btn_register_Click(object sender, EventArgs e)
        {

            //連番START
            string queryString = "SELECT 商品ID FROM 商品マスタ ORDER BY 商品ID DESC";
            OleDbDataAdapter da = new OleDbDataAdapter(queryString, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            itemID = int.Parse(dr["商品ID"].ToString());
            for(int i = 0;dt.Rows.Count > i; i++)
            {
                dr = dt.Rows[i];
                if (int.Parse(dr["商品ID"].ToString()) > itemID) itemID = int.Parse(dr["商品ID"].ToString());
            }
            itemID += 1;
            //連番END

            OleDbCommand cmd =
                 new OleDbCommand("INSERT INTO 商品マスタ (商品ID ,商品名 ,定価 ,車種 ,メーカー ,仕入先ID )" +
                                   "VALUES (@商品ID ,@商品名 ,@定価 ,@車種 ,@メーカー ,@仕入先ID )", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@商品ID", itemID.ToString());
            cmd.Parameters.AddWithValue("@商品名", txt_item.Text);
            cmd.Parameters.AddWithValue("@定価", txt_price.Text);
            cmd.Parameters.AddWithValue("@車種", txt_type.Text);
            cmd.Parameters.AddWithValue("@メーカー", txt_maker.Text); 
            cmd.Parameters.AddWithValue("@仕入先ID", txt_supplier.Text);

            try
            {
                cn.Open();                 //コネクションを開く
                cmd.ExecuteNonQuery();     //SQLを実行
                cn.Close();                //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();               //コネクションを閉じる
                return;

            }
            MessageBox.Show("登録しました", "管理者");
        }

        private void btn_register1_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT 商品詳細ID FROM 商品詳細テーブル ORDER BY 商品詳細ID DESC";//連番コードここから
            OleDbDataAdapter da = new OleDbDataAdapter(queryString, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.Rows[0];

            ProductID = int.Parse(dr["商品詳細ID"].ToString());
            ProductID += 1;

            OleDbCommand cmd =
                 new OleDbCommand("INSERT INTO 商品詳細テーブル (商品詳細ID ,走行距離 ,発売日 ,オプション ,商品ID ,色 ,モデル,実売価格,車両状態 )" +
                                   "VALUES (@商品詳細ID ,@走行距離 ,@発売日 ,@オプション ,@商品ID ,@色 ,@モデル ,@販売価格 ,@車両状態 )", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@商品詳細ID", ProductID.ToString());
            cmd.Parameters.AddWithValue("@走行距離", txt_mileage.Text);
            cmd.Parameters.AddWithValue("@発売日", txt_release.Text);
            cmd.Parameters.AddWithValue("@オプション", txt_option.Text);
            cmd.Parameters.AddWithValue("@商品ID", txt_itemID.Text);
            cmd.Parameters.AddWithValue("@色", txt_color.Text);
            cmd.Parameters.AddWithValue("@モデル", txt_model.Text);
            cmd.Parameters.AddWithValue("@販売価格", txt_actual.Text);
            cmd.Parameters.AddWithValue("@車両状態", txt_vehicle.Text);

            try
            {
                cn.Open();                 //コネクションを開く
                cmd.ExecuteNonQuery();     //SQLを実行
                cn.Close();                //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();               //コネクションを閉じる
                return;

            }
            MessageBox.Show("登録しました", "管理者");
        }
    }
}
