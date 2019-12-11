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
        OleDbConnection cn;

        private Label[] chenge_labels;
        private TextBox[] chenge_textBoxes;
        public ClientRegister()
        {
            InitializeComponent();
        }

        private void ClientRegister_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();
                cn.ConnectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
            }

            chenge_labels = new Label[6] { lbl_address, lbl_birthday, lbl_name, lbl_pos, lbl_sex, lbl_tel };
            chenge_textBoxes = new TextBox[4] { txt_address, txt_name, txt_pos, txt_tel };
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

        private void cmb_sex_KeyDown(object sender, KeyEventArgs e)
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
            if (radioB_Register.Checked == true)
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
            else
            {
                // Pass、Name、PostNumber、AddressをUPDATE
                OleDbCommand cmd =
                    new OleDbCommand("UPDATE 顧客マスタ SET 顧客ID = @顧客ID,氏名 = @name, " +
                     " 性別 = @sex,生年月日 = @birthday,郵便番号 = @pos,住所 = @address,電話番号 = @tel WHERE (顧客ID = @顧客ID)", cn);
                //@パラメータが出てくる順番に設定する


                cmd.Parameters.AddWithValue("@顧客ID", txt_id.Text);
                cmd.Parameters.AddWithValue("@name", txt_name.Text);         //Nameのデータ
                cmd.Parameters.AddWithValue("@sex", cmb_sex.Text);           //sexのデータ
                cmd.Parameters.AddWithValue("@birthday", dtp_birthday.Text); //birthdayのデータ
                cmd.Parameters.AddWithValue("@pos", txt_pos.Text);           //posのデータ
                cmd.Parameters.AddWithValue("@address", txt_address.Text);   //addressのデータ
                cmd.Parameters.AddWithValue("@tel", txt_tel.Text);           //telのデータ

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
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_pos.Clear();
            txt_address.Clear();
            txt_tel.Clear();
            cmb_sex.SelectedIndex = -1;
        }

        private void radioB_Update_CheckedChanged(object sender, EventArgs e)
        {
            btn_search.Visible = true;
            for (int i = 0; chenge_labels.Length > i; i++) chenge_labels[i].Visible = false;
            for (int i = 0; chenge_textBoxes.Length > i; i++) chenge_textBoxes[i].Visible = false;
            dtp_birthday.Visible = false;
            cmb_sex.Visible = false;
            btn_login.Text = "更新";
        }

        private void radioB_Register_CheckedChanged(object sender, EventArgs e)
        {
            btn_search.Visible = false;
            for (int i = 0; chenge_labels.Length > i; i++) chenge_labels[i].Visible = true;
            for (int i = 0; chenge_textBoxes.Length > i; i++) chenge_textBoxes[i].Visible = true;
            dtp_birthday.Visible = true;
            cmb_sex.Visible = true;
            btn_login.Text = "登録";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand("SELECT 顧客ID , 氏名 , 住所 , 郵便番号 , 電話番号 , 性別 , 生年月日 FROM 顧客マスタ WHERE 顧客ID = @顧客ID ORDER BY 顧客ID", cn);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@顧客ID", txt_id.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                DataRow dr = dt.Rows[0];

                txt_address.Text = dr["住所"].ToString();
                txt_pos.Text = dr["郵便番号"].ToString();
                txt_tel.Text = dr["電話番号"].ToString();
                cmb_sex.Text = dr["性別"].ToString();
                dtp_birthday.Text = txt_name.Text = dr["生年月日"].ToString();
                txt_name.Text = dr["氏名"].ToString();
                cn.Close();

                for (int i = 0; chenge_labels.Length > i; i++) chenge_labels[i].Visible = true;
                for (int i = 0; chenge_textBoxes.Length > i; i++) chenge_textBoxes[i].Visible = true;
                dtp_birthday.Visible = true;
                cmb_sex.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("IDが見つかりませんでした");
                cn.Close();                //コネクションを閉じる
                return;
            }
        }
    }
}
