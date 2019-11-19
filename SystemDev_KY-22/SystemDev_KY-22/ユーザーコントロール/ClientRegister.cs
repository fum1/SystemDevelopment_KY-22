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

namespace SystemDev_KY_22
{
    public partial class ClientRegister : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        public ClientRegister()
        {
            InitializeComponent();
        }

        private void ClientRegister_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
        }

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_name.Focus();    //氏名の入力にフォーカスを当てる
            } 
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_sex.Focus();    //性別の入力にフォーカスを当てる
            }
        }

        private void rbtn_man_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_birthday.Focus();    //生年月日の入力にフォーカスを当てる
            }
        }

        private void dtp_birthday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txt_pos.Focus();    //郵便番号の入力にフォーカスを当てる
            }
        }

        private void txt_pos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_address.Focus();    //住所の入力にフォーカスを当てる
            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_tel.Focus();    //TELの入力にフォーカスを当てる
            }
        }

        private void txt_tel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.Focus();    //TELの入力にフォーカスを当てる
            }
        }

       private void btn_login_Click(object sender, EventArgs e)
        {
            // ID、Pass、Name、PostNumber、AddressをINSERT  
            OleDbCommand cmd =
                new OleDbCommand("INSERT INTO 顧客マスタ (顧客ID,氏名, 性別, 生年月日, 郵便番号,住所,電話番号) " +
                "VALUES (@顧客ID, @氏名, @性別, @生年月日, @郵便番号,@住所,@電話番号)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@顧客ID", txt_id.Text);
            cmd.Parameters.AddWithValue("@氏名", txt_name.Text);
            cmd.Parameters.AddWithValue("@性別", cmb_sex.Text);
            cmd.Parameters.AddWithValue("@生年月日", dtp_birthday.Text);
            cmd.Parameters.AddWithValue("@郵便番号", txt_pos.Text);
            cmd.Parameters.AddWithValue("@住所", txt_address.Text);
            cmd.Parameters.AddWithValue("@電話番号", txt_tel.Text);
            
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
        
    }
    }
