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
        OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト
        public Vendor_list()
        {
            InitializeComponent();
        }

        private void Vendor_list_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

            dataload();

        }

        private void dataload()   //カスタム関数
        {

            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT 仕入先ID , 仕入先会社名 ,仕入先郵便番号 , 仕入先住所 ," +
                "仕入先電話番号 , 商品ID ," +
                "FROM 仕入先マスタ ORDER BY 仕入先ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);


            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;    //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();           //列の幅の自動調整

            cmb_SupplierID.DataSource = dt;
            cmb_SupplierID.DisplayMember = "仕入先ID";
            cmb_SupplierID.ValueMember = "仕入先ID";

            cmb_Suppliername.DataSource = dt;
            cmb_Suppliername.DisplayMember = "仕入先会社名";
            cmb_Suppliername.ValueMember = "仕入先会社名";

            cmb_postalcode.DataSource = dt;
            cmb_postalcode.DisplayMember = "仕入先郵便番号";
            cmb_postalcode.ValueMember = "仕入先郵便番号";

            cmb_address.DataSource = dt;
            cmb_address.DisplayMember = "仕入先住所";
            cmb_address.ValueMember = "仕入先住所";

            cmb_tel.DataSource = dt;
            cmb_tel.DisplayMember = "仕入先電話番号";
            cmb_tel.ValueMember = "仕入先電話番号";

            cmb_productID.DataSource = dt;
            cmb_productID.DisplayMember = "商品ID";
            cmb_productID.ValueMember = "商品ID";




            OleDbDataAdapter　product_da =
                new OleDbDataAdapter("SELECT 商品ID,商品名,定価,車種ID,メーカーID" +
                " FROM 商品マスタ", cn);
            DataTable product_dt = new DataTable();
            product_da.Fill(product_dt);

            cmb_productID.DataSource = product_dt;
            cmb_productID.DisplayMember = "商品ID";
            cmb_productID.ValueMember = "商品ID";


          


        }

        private void btn_Suppliersearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 仕入先ID , 仕入先会社名 ,仕入先郵便番号 , 仕入先住所 ," +
                "仕入先電話番号 , 商品ID ," +
                "FROM 仕入先マスタ WHERE 仕入先ID = @仕入先ID  ORDER BY 仕入先ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先ID", cmb_SupplierID.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_Suppliernamesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 仕入先ID , 仕入先会社名 ,仕入先郵便番号 , 仕入先住所 ," +
                "仕入先電話番号 , 商品ID ," +
                "FROM 仕入先マスタ WHERE 仕入先会社名 = @仕入先会社名  ORDER BY 仕入先会社名");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先会社名", cmb_Suppliername.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_postalcodesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 仕入先ID , 仕入先会社名 ,仕入先郵便番号 , 仕入先住所 ," +
                "仕入先電話番号 , 商品ID ," +
                "FROM 仕入先マスタ WHERE 仕入先郵便番号 = @仕入先郵便番号  ORDER BY 仕入先郵便番号");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先郵便番号", cmb_postalcode.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_telsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 仕入先ID , 仕入先会社名 ,仕入先郵便番号 , 仕入先住所 ," +
                "仕入先電話番号 , 商品ID ," +
                "FROM 仕入先マスタ WHERE 仕入先電話番号 = @仕入先電話番号  ORDER BY 仕入先電話番号");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先電話番号", cmb_tel.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_addresssearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 仕入先ID , 仕入先会社名 ,仕入先郵便番号 , 仕入先住所 ," +
                "仕入先電話番号 , 商品ID ," +
                "FROM 仕入先マスタ WHERE 仕入先住所 = @仕入先住所  ORDER BY 仕入先城所");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先住所", cmb_address.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_productsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 仕入先ID , 仕入先会社名 ,仕入先郵便番号 , 仕入先住所 ," +
                "仕入先電話番号 , 商品ID ," +
                "FROM 仕入先マスタ WHERE 商品ID = @商品ID  ORDER BY 商品ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@商品ID", cmb_productID.Text);


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
                new OleDbCommand("INSERT INTO 仕入先マスタ (仕入先ID,仕入先会社名, 仕入先郵便番号,仕入先住所, 仕入先電話番号,商品ID) " +
                "VALUES (@仕入先ID, @仕入先会社名, @仕入先郵便番号, @仕入先住所, @商品ID)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@仕入先ID", cmb_SupplierID);
            cmd.Parameters.AddWithValue("@仕入先会社名", cmb_Suppliername);                 //IDのデータ
            cmd.Parameters.AddWithValue("@仕入先郵便番号", cmb_postalcode);             //Passのデータ
            cmd.Parameters.AddWithValue("@仕入先住所", cmb_tel);             //Nameのデータ
            cmd.Parameters.AddWithValue("@仕入先電話番号", cmb_address.Text);  //PostNumberのデータ
            cmd.Parameters.AddWithValue("@商品ID", cmb_productID.Text); 
            
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
            OleDbCommand cmd =
                       new OleDbCommand("UPDATE 仕入先マスタ SET 仕入先ID = @SupplierID,仕入先会社名 = @Suppliername, " +
                        " 仕入先郵便番号 = @Supplierpostal,仕入先住所 = @Supplieraddress,仕入先電話番号 = @Suppliertell,商品ID = @productID, WHERE (仕入先ID = @仕入先ID)", cn);
            //@パラメータが出てくる順番に設定する


            cmd.Parameters.AddWithValue("@SupplierID", cmb_SupplierID);
            cmd.Parameters.AddWithValue(" @Suppliername", cmb_Suppliername.Text);               //Passのデータ
            cmd.Parameters.AddWithValue("@Supplierpostal", cmb_postalcode.Text);               //Nameのデータ
            cmd.Parameters.AddWithValue("@Supplieraddress", cmb_tel.Text);     //PostNumberのデータ
            cmd.Parameters.AddWithValue("@Suppliertell", cmb_address.Text);           //Addressのデータ
            cmd.Parameters.AddWithValue("@productID", cmb_productID.Text);//IDのデータ
            

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
            
        }
    }
}

