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
            OleDbCommand cmd =
                 new OleDbCommand("INSERT INTO 商品マスタ(商品ID ,商品名 ,定価 ,車種,メーカー,仕入先ID)" +
                                   "VALUES (@商品ID ,@商品名 ,@定価 ,@車種,@メーカー,@仕入先ID)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@商品名", txt_item.Text);
            cmd.Parameters.AddWithValue("@定価", txt_price.Text);
            cmd.Parameters.AddWithValue("@車種", txt_type.Text);
            cmd.Parameters.AddWithValue("@メーカー", txt_maker.Text);

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
        }
    }
}
