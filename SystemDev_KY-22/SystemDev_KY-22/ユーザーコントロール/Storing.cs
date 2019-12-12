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
    public partial class Storing : UserControl
    {
        OleDbConnection cn;  //コネクションオブジェクト
        DataTable dt;
        public Storing()
        {
            InitializeComponent();
        }

        private void Storing_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();
                cn.ConnectionString =
                   @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                  new OleDbCommand("INSERT INTO 入庫テーブル(入庫ID,入庫年月日,入庫数,仕入先ID,商品詳細ID,在庫ID)" +
                  "VALUES (@入庫ID, @入庫年月日, @入庫数, @仕入先ID, @商品名,@色,@モデル)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@入庫ID", txt_storing.Text);
            cmd.Parameters.AddWithValue("@入庫年月日", txt_receipt.Text);                 
            cmd.Parameters.AddWithValue("@入庫数", txt_num.Text);             
            cmd.Parameters.AddWithValue("@仕入先ID", txt_supplier.Text);             
            cmd.Parameters.AddWithValue("@商品名", txt_name.Text);   
            cmd.Parameters.AddWithValue("@色", txt_color.Text);      
            cmd.Parameters.AddWithValue("@モデル", txt_model.Text);
            
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                        new OleDbCommand("UPDATE 入庫テーブル SET 入庫ID = @入庫ID,入庫年月日 = @receipt,入庫数 = @num " +
                                         "仕入先ID = @supplierID,商品名 = @name,色 = color,モデル = model" +
                                         " WHERE (入庫ID = @入庫ID)", cn);

            cmd.Parameters.AddWithValue("@入庫ID ", txt_storing.Text);
            cmd.Parameters.AddWithValue("@入庫年月日 ", txt_receipt.Text);
            cmd.Parameters.AddWithValue("@入庫数", txt_num.Text);
            cmd.Parameters.AddWithValue("@仕入先ID", txt_supplier.Text);
            cmd.Parameters.AddWithValue("@商品名", txt_name.Text);
            cmd.Parameters.AddWithValue("@色", txt_color.Text);
            cmd.Parameters.AddWithValue("@モデル", txt_model.Text);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();               //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();                //コネクションを閉じる
                return;
            }
            MessageBox.Show("更新しました");

        }

        private void btn_itemregister_Click(object sender, EventArgs e)
        {

        }
    }
}
