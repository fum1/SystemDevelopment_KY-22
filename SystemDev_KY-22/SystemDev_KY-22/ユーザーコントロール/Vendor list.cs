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
        OleDbConnection cn;

        private string empid;
        public Vendor_list()
        {
            InitializeComponent();
        }

        private void dataload()   //カスタム関数
        {

            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT * FROM 仕入先マスタ", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);


            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;    //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();           //列の幅の自動調整

        }

            private void btn_Suppliersearch_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                //OleDbCommand cmd =
                //    new OleDbCommand("SELECT 仕入先ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 ,商品ID   " +
                //   "FROM 仕入先マスタ WHERE 仕入先ID = @仕入先ID  ORDER BY 仕入先ID");
                OleDbCommand cmd =
                    new OleDbCommand("SELECT * FROM 仕入先マスタ WHERE 仕入先ID = @仕入先ID  ORDER BY 仕入先ID");
                cmd.Connection = cn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;

                cmd.Parameters.AddWithValue("@仕入先ID", txt_SupplierID.Text);


                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv_vendorlist.DataSource = dt;
                dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
                dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調整
            }
            else
            {
                empid = txt_SupplierID.Text;
                //groupBox_update.Visible = true;

                OleDbCommand cmd =
                    new OleDbCommand("SELECT 仕入先ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 ,商品ID   " +
                "FROM 仕入先マスタ WHERE 仕入先ID = @仕入先ID ORDER BY 仕入先ID");
                cmd.Connection = cn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                cmd.Parameters.AddWithValue("@仕入先ID", txt_SupplierID.Text);
                DataTable dt = new DataTable();
                da.Fill(dt);

                try
                {
                    DataRow dr = dt.Rows[0];


                    txt_Suppliername.Text = dr["仕入先会社名"].ToString();
                    txt_postalcode.Text = dr["仕入先郵便番号"].ToString();
                    txt_address.Text = dr["仕入先住所"].ToString();
                    txt_tel.Text = dr["仕入先電話番号"].ToString();
                    txt_productID.Text = dr["商品ID"].ToString();
                    

                    cn.Close();

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("IDが見つかりませんでした");
                    cn.Close();                //コネクションを閉じる
                    return;
                }
            }
        }

        private void btn_Suppliernamesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand(("SELECT 仕入先ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 ,商品ID   " +
                "FROM 仕入先マスタ WHERE 仕入先会社名 = @仕入先会社名  ORDER BY 仕入先会社名"));
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先会社名", txt_Suppliername.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自
        }

        private void btn_postalcodesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand(("SELECT 仕入先ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 ,商品ID   " +
                "FROM 仕入先マスタ WHERE 仕入先郵便番号  = @仕入先郵便番号 ORDER BY 仕入先郵便番号 "));
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先郵便番号 ", txt_postalcode.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_vendorlist.DataSource = dt;
            dgv_vendorlist.AllowUserToAddRows = false;   //最下行を非表示
            dgv_vendorlist.AutoResizeColumns();          //列の幅の自動調
        }

        private void btn_telsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
              new OleDbCommand("SELECT 仕入先ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 ,商品ID   " +
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
                new OleDbCommand("SELECT 仕入先ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 ,商品ID   " +
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
             new OleDbCommand("SELECT 仕入先ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号 ,商品ID   " +
                "FROM 仕入先マスタ WHERE 商品ID = @商品ID ORDER BY 商品ID");
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
                new OleDbCommand("INSERT INTO 仕入先マスタ (仕入先ID,仕入先会社名, 仕入先郵便番号, 仕入先住所, 仕入先電話番号,商品ID) " +
                "VALUES (@仕入先ID, @仕入先会社名, @仕入先郵便番号,@仕入先電話番号, @仕入先住所, @商品ID)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@仕入先ID", txt_SupplierID.Text);
            cmd.Parameters.AddWithValue("@仕入先会社名", txt_Suppliername.Text);                 //IDのデータ
            cmd.Parameters.AddWithValue("@仕入先郵便番号", txt_postalcode.Text);             //Passのデータ
            cmd.Parameters.AddWithValue("@仕入先住所", txt_address.Text);             //Nameのデータ
            cmd.Parameters.AddWithValue("@仕入先電話番号", txt_tel.Text);  //PostNumberのデータ
            cmd.Parameters.AddWithValue("@商品ID", txt_productID.Text);

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
                     new OleDbCommand("UPDATE 仕入先マスタ SET 仕入先ID = @SupplierID, 仕入先会社名 = @Suppliername , " +
                      "仕入先郵便番号 = @Supplierpostal ,仕入先住所 = @Supplieraddress ,仕入先電話番号 = @Suppliertel ,商品ID = @productID WHERE (仕入先ID = @SupplierID)", cn);
            //@パラメータが出てくる順番に設定する


            cmd.Parameters.AddWithValue("@SupplierID", txt_SupplierID.Text);
            cmd.Parameters.AddWithValue("@Suppliername", txt_Suppliername.Text);               //Passのデータ
            cmd.Parameters.AddWithValue("@Supplierpostal", txt_postalcode.Text);               //Nameのデータ
            cmd.Parameters.AddWithValue("@Supplieraddress", txt_address.Text);     //PostNumberのデータ
            cmd.Parameters.AddWithValue("@Suppliertel", txt_tel.Text);           //Addressのデータ
            cmd.Parameters.AddWithValue("@productID", txt_productID.Text);//IDのデータ


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
            dataload();

        }

        private void Vendor_list_Load_1(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();  //コネクションオブジェクト
                cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
                dataload();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            btn_registration.Visible = false;
            btn_update.Visible = false;
            btn_Clear.Visible = true;

            txt_address.Visible = true;
            txt_postalcode.Visible = true;
            txt_productID.Visible = true;
            txt_SupplierID.Visible = true;
            txt_Suppliername.Visible = true;
            txt_tel.Visible = true;

            btn_Suppliernamesearch.Visible = true;
            btn_addresssearch.Visible = true;
            btn_postalcodesearch.Visible = true;
            btn_productsearch.Visible = true;
            btn_Suppliersearch.Visible = true;
            btn_telsearch.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btn_registration.Visible = true;
            btn_update.Visible = false;
            btn_Clear.Visible = true;

            txt_address.Visible = true;
            txt_postalcode.Visible = true;
            txt_productID.Visible = true;
            txt_SupplierID.Visible = true;
            txt_Suppliername.Visible = true;
            txt_tel.Visible = true;

            btn_Suppliernamesearch.Visible = false;
            btn_addresssearch.Visible = false;
            btn_postalcodesearch.Visible = false;
            btn_productsearch.Visible = false;
            btn_Suppliersearch.Visible = false;
            btn_telsearch.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btn_registration.Visible = false;
            btn_update.Visible = true;
            btn_Clear.Visible = false;

            txt_address.Visible = true;
            txt_postalcode.Visible = true;
            txt_productID.Visible = true;
            txt_SupplierID.Visible = true;
            txt_Suppliername.Visible = true;
            txt_tel.Visible = true;

            btn_Suppliernamesearch.Visible = false;
            btn_addresssearch.Visible = false;
            btn_postalcodesearch.Visible = false;
            btn_productsearch.Visible = false;
            btn_Suppliersearch.Visible = true;
            btn_telsearch.Visible = false;
        }
    }
}