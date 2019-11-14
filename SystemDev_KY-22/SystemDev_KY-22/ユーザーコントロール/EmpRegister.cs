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
using System.Data.SqlClient;

namespace SystemDev_KY_22
{
    public partial class EmpRegister : UserControl
    {
        OleDbConnection cn = new OleDbConnection(); //コネクションオブジェクト
        DataTable dt = new DataTable();
        public EmpRegister()
        {



            InitializeComponent();
        }

        private void EmpRegister_Load(object sender, EventArgs e)
        {
            groupBox_update.Visible = false;
            cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

        }

        private void textB_enameID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                txt_name.Focus();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
 
        }

      

            private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            // ID、Pass、Name、PostNumber、AddressをINSERT  
            OleDbCommand cmd =
                new OleDbCommand("INSERT INTO 社員マスタ (社員ID,氏名, 住所, 郵便番号, 電話番号,性別,部署,役職,店舗ID,パスワード) " +
                "VALUES (@社員ID, @社員名, @住所, @郵便番号, @電話番号,@性別,@部署,@役職,@店舗ID,@パスワード)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@社員ID", txt_id.Text);
            cmd.Parameters.AddWithValue("@社員名", txt_name.Text);                 //IDのデータ
            cmd.Parameters.AddWithValue("@住所", txt_address.Text);             //Passのデータ
            cmd.Parameters.AddWithValue("@郵便番号", txt_postal.Text);             //Nameのデータ
            cmd.Parameters.AddWithValue("@電話番号", txt_tel.Text);   //PostNumberのデータ
            cmd.Parameters.AddWithValue("@性別", cmb_sex.Text);      //Addressのデータ
            cmd.Parameters.AddWithValue("@部署", txt_department.Text);
            cmd.Parameters.AddWithValue("@役職", txt_position.Text);
            cmd.Parameters.AddWithValue("@店舗ID", txt_clerk.Text);
            cmd.Parameters.AddWithValue("@パスワード", txt_password.Text);
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


            MessageBox.Show("登録しました", "住所録");
        }

        private void txt_id1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           /* OleDbCommand cmd =
               new OleDbCommand("SELECT 社員ID FROM 社員マスタ WHERE PostNumber=@posnum", cn);
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            string postal = txt_id1.Text.("");
            cmd.Parameters.AddWithValue("", postal);             //郵便番号のパラメータ
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txt_name1.Text =
                    dt.Rows[0][0].ToString() + dt.Rows[0][1].ToString() + dt.Rows[0][2].ToString();
            }
            else
            {
                txt_name1.Text = "郵便番号辞書に登録されていません";
            }*/
        }
    }
}