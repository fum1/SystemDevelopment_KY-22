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
    public partial class EmpRegister : UserControl
    {
        OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト

        public EmpRegister()
        {



            InitializeComponent();
        }

        private void EmpRegister_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

        }

        private void textB_enameID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                textB_ename.Focus();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // ID、Pass、Name、PostNumber、AddressをINSERT  
            OleDbCommand cmd =
                new OleDbCommand("INSERT INTO 社員マスタ (社員ID,氏名, 住所, 郵便番号, 電話番号,性別,部署,役職,店舗ID) " +
                "VALUES (@社員ID, @社員名, @住所, @郵便番号, @電話番号,@性別,@部署,@役職,@店舗ID)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@社員ID", textB_enameID.Text);
            cmd.Parameters.AddWithValue("@社員名", textB_ename.Text);                 //IDのデータ
            cmd.Parameters.AddWithValue("@住所", textB_address.Text);             //Passのデータ
            cmd.Parameters.AddWithValue("@郵便番号", textB_post.Text);             //Nameのデータ
            cmd.Parameters.AddWithValue("@電話番号", textB_tell.Text);   //PostNumberのデータ
            cmd.Parameters.AddWithValue("@性別", comboB_sex.Text);      //Addressのデータ
            cmd.Parameters.AddWithValue("@部署", textB_dept.Text);
            cmd.Parameters.AddWithValue("@役職", textB_position.Text);
            cmd.Parameters.AddWithValue("@店舗ID", textB_shopID.Text);
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