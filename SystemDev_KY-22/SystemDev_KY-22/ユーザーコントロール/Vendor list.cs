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
    public partial class Vendor_list : UserControl
    {
        OleDbConnection cn;  //コネクションオブジェクト
        DataTable dt;


        public Vendor_list()
        {
            InitializeComponent();
        }

        private void Vendor_list_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();  //コネクションオブジェクト
                dt = new DataTable();
                cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
            }
        }

        private void btn_Suppliersearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 仕入先ID ,商品ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 " +
              "FROM 仕入先マスタ WHERE 仕入先ID = @仕入先ID  ORDER BY 仕入先ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先ID", txt_SupplierID.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動
        }

        private void btn_Suppliernamesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
              new OleDbCommand("SELECT 仕入先ID ,商品ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 " +
              "FROM 仕入先マスタ WHERE 仕入先会社名 = @仕入先会社名  ORDER BY 仕入先会社名");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先会社名", txt_Suppliername.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調
        }

        private void btn_postalcodesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
              new OleDbCommand("SELECT 仕入先ID ,商品ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 " +
              "FROM 仕入先マスタ WHERE 仕入先郵便番号  = @仕入先郵便番号 ORDER BY 仕入先郵便番号 ");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先郵便番号 ", txt_postalcode.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_telsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
              new OleDbCommand("SELECT 仕入先ID ,商品ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 " +
               "FROM 仕入先マスタ WHERE 仕入先電話番号 = @仕入先電話番号 ORDER BY 仕入先電話番号");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先電話番号", txt_tel.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_addresssearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
              new OleDbCommand("SELECT 仕入先ID ,商品ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 " +
              "FROM 仕入先マスタ WHERE 仕入先住所 = @仕入先住所 ORDER BY 仕入先住所");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先住所", txt_address.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_productsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
             new OleDbCommand("SELECT 商品ID ,車種ID ,商品名 ,メーカー ,色 ,モデル ,オプション ,発売日 ,走行距離 ,定価 ,実売価格 " +
              "FROM 商品マスタ WHERE 商品ID = @商品ID ORDER BY 商品ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@商品ID", txt_productID.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_registration_Click(object sender, EventArgs e)
        {
            // ID、Pass、Name、PostNumber、AddressをINSERT  
            OleDbCommand cmd =
                new OleDbCommand("INSERT INTO 仕入先マスタ (仕入先ID, 商品ID, 仕入先会社名, 仕入先郵便番号, 仕入先住所, 仕入先電話番号) " +
                "VALUES (@仕入先ID,@商品ID, @仕入先会社名, @仕入先郵便番号,@仕入先電話番号, @仕入先住所)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@仕入先ID", txt_SupplierID.Text);
            cmd.Parameters.AddWithValue("@商品ID", txt_productID.Text);
            cmd.Parameters.AddWithValue("@仕入先会社名", txt_Suppliername.Text);                 //IDのデータ
            cmd.Parameters.AddWithValue("@仕入先郵便番号", txt_postalcode.Text);             //Passのデータ
            cmd.Parameters.AddWithValue("@仕入先住所", txt_address.Text);             //Nameのデータ
            cmd.Parameters.AddWithValue("@仕入先電話番号", txt_tel.Text);  //PostNumberのデータ
            

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

        private void btn_update_Click(object sender, EventArgs e)
        {
            //OleDbCommand cmd =
            //          new OleDbCommand("UPDATE 仕入先マスタ SET 仕入先ID = @SupplierID , 仕入先会社名 = @Suppliername , " +
            //           "仕入先郵便番号 = @Supplierpostal ,仕入先住所 = @Supplieraddress ,仕入先電話番号 = @Suppliertel ,商品ID = @productID WHERE (仕入先ID = @仕入先ID)", cn);
            OleDbCommand cmd =
                     new OleDbCommand("UPDATE 仕入先マスタ SET 商品ID = @productID ,仕入先会社名 = @Suppliername , " +
                      "仕入先郵便番号 = @Supplierpostal ,仕入先住所 = @Supplieraddress ,仕入先電話番号 = @Suppliertel WHERE (仕入先ID = @SupplierID)", cn);
            //@パラメータが出てくる順番に設定する


            cmd.Parameters.AddWithValue("@SupplierID", txt_SupplierID.Text);
            cmd.Parameters.AddWithValue("@productID", txt_productID.Text);//IDのデータ
            cmd.Parameters.AddWithValue("@Suppliername", txt_Suppliername.Text);               //Passのデータ
            cmd.Parameters.AddWithValue("@Supplierpostal", txt_postalcode.Text);               //Nameのデータ
            cmd.Parameters.AddWithValue("@Supplieraddress", txt_address.Text);     //PostNumberのデータ
            cmd.Parameters.AddWithValue("@Suppliertel", txt_tel.Text);           //Addressのデータ
            


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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_SupplierID.Clear();
            txt_Suppliername.Clear();
            txt_postalcode.Clear();
            txt_tel.Clear();
            txt_tel.Clear();
            txt_address.Clear();
            txt_productID.Clear();

        }

     
    }
}