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

        private string empid;

        public EmpRegister()
        {



            InitializeComponent();
        }

        private void EmpRegister_Load(object sender, EventArgs e)
        {
            groupBox_update.Visible = false;
            cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

            dataload();
            




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
                new OleDbCommand("INSERT INTO 社員マスタ (社員ID,氏名, 住所, 郵便番号, 電話番号,生年月日,性別,部署,役職,店舗ID,パスワード) " +
                "VALUES (@社員ID, @社員名, @住所, @郵便番号, @電話番号,@生年月日,@性別,@部署,@役職,@店舗ID,@パスワード)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@社員ID", txt_idhead.Text + txt_id.Text);
            cmd.Parameters.AddWithValue("@社員名", txt_name.Text);                 //IDのデータ
            cmd.Parameters.AddWithValue("@住所", txt_address.Text);             //Passのデータ
            cmd.Parameters.AddWithValue("@郵便番号", txt_postal.Text);             //Nameのデータ
            cmd.Parameters.AddWithValue("@電話番号", txt_tel.Text);  //PostNumberのデータ
            cmd.Parameters.AddWithValue("@生年月日", txt_birthday.Text); 
            cmd.Parameters.AddWithValue("@性別", cmb_sex.Text);      //Addressのデータ
            cmd.Parameters.AddWithValue("@部署", cmb_department.Text);
            cmd.Parameters.AddWithValue("@役職", cmb_position.Text);
            cmd.Parameters.AddWithValue("@店舗ID", cmb_clerk.Text);
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


            MessageBox.Show("登録しました", "管理者");
        }

        private void txt_id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            empid = txt_id1.Text;
            groupBox_update.Visible = true;

            OleDbCommand cmd =
                new OleDbCommand("SELECT 社員ID , 氏名 , 住所 , 郵便番号 ," +
                "電話番号 , 生年月日 , 性別 , 部署 , 役職 , 店舗ID , パスワード " +
                "FROM 社員マスタ WHERE 社員ID = @社員ID ORDER BY 社員ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@社員ID", txt_id1.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                DataRow dr = dt.Rows[0];
           
                txt_idhead1.Text = dr["社員ID"].ToString();
                txt_name1.Text= dr["氏名"].ToString();
                txt_postal1.Text = dr["郵便番号"].ToString();
                txt_address1.Text = dr["住所"].ToString();
                txt_tel1.Text = dr["電話番号"].ToString();
                cmb_sex1.Text = dr["性別"].ToString();
                cmb_department1.Text = dr["部署"].ToString();
                cmb_position1.Text = dr["役職"].ToString();
                cmb_clerk1.Text = dr["店舗ID"].ToString();
                mtextB_Pass.Text = dr["パスワード"].ToString();

                cn.Close();

                txt_idhead1.Text = txt_id1.Text.Substring(0, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IDが見つかりませんでした");
                cn.Close();                //コネクションを閉じる
                return;
            }



        }

        private void cmb_sex1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedItem = cmb_sex1.SelectedItem.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int length = txt_id1.TextLength;
            if (checkB_Delete.Checked)
            {
                OleDbCommand delete_cmd = new OleDbCommand("DELETE FROM 社員マスタ WHERE 社員ID = @id", cn);  //ID
                delete_cmd.Parameters.AddWithValue("@id", empid);
                try
                {
                    cn.Open();                 //コネクションを開く
                    delete_cmd.ExecuteNonQuery();     //SQLを実行
                    cn.Close();                //コネクションを閉じる
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cn.Close();                //コネクションを閉じる
                    return;
                }

                MessageBox.Show("旧IDのデータを削除しました", "削除完了");
            }
            else
            {
                if (empid == txt_idhead1.Text + empid.Substring(1, length - 1))
                {
                    // Pass、Name、PostNumber、AddressをUPDATE
                    OleDbCommand cmd =
                        new OleDbCommand("UPDATE 社員マスタ SET 社員ID = @社員ID,氏名 = @name, " +
                         " 郵便番号 = @postal,住所 = @address,電話番号 = @tell,性別 = @sex,部署 = @department,役職 = @position," +
                         "店舗ID = @shopID,パスワード = @pass WHERE (社員ID = @社員ID)", cn);
                    //@パラメータが出てくる順番に設定する


                    cmd.Parameters.AddWithValue("@社員ID", txt_idhead1.Text + empid.Substring(1, length - 1));
                    cmd.Parameters.AddWithValue("@name", txt_name1.Text);               //Passのデータ
                    cmd.Parameters.AddWithValue("@postal", txt_postal1.Text);               //Nameのデータ
                    cmd.Parameters.AddWithValue("@address", txt_address1.Text);     //PostNumberのデータ
                    cmd.Parameters.AddWithValue("@tell", txt_tel1.Text);           //Addressのデータ
                    cmd.Parameters.AddWithValue("@sex", cmb_sex1.Text);//IDのデータ
                    cmd.Parameters.AddWithValue("@department", cmb_department1.Text);
                    cmd.Parameters.AddWithValue("@position", cmb_position1.Text);
                    cmd.Parameters.AddWithValue("@shopID", cmb_clerk1.Text);
                    cmd.Parameters.AddWithValue("@pass", mtextB_Pass.Text);

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
                else
                {
                    OleDbCommand cmd =
                    new OleDbCommand("INSERT INTO 社員マスタ (社員ID,氏名, 住所, 郵便番号, 電話番号,性別,部署,役職,店舗ID,パスワード) " +
                    "VALUES (@社員ID, @社員名, @住所, @郵便番号, @電話番号,@性別,@部署,@役職,@店舗ID,@パスワード)", cn);
                    //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
                    //@パラメータが出てくる順番に設定する
                    cmd.Parameters.AddWithValue("@社員ID", txt_idhead1.Text + empid.Substring(1, length - 1));
                    cmd.Parameters.AddWithValue("@社員名", txt_name1.Text);                 //IDのデータ
                    cmd.Parameters.AddWithValue("@住所", txt_address1.Text);             //Passのデータ
                    cmd.Parameters.AddWithValue("@郵便番号", txt_postal1.Text);             //Nameのデータ
                    cmd.Parameters.AddWithValue("@電話番号", txt_tel1.Text);   //PostNumberのデータ
                    cmd.Parameters.AddWithValue("@性別", cmb_sex1.Text);      //Addressのデータ
                    cmd.Parameters.AddWithValue("@部署", cmb_department1.Text);
                    cmd.Parameters.AddWithValue("@役職", cmb_position1.Text);
                    cmd.Parameters.AddWithValue("@店舗ID", cmb_clerk1.Text);
                    cmd.Parameters.AddWithValue("@パスワード", mtextB_Pass.Text);
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

                    MessageBox.Show("IDが変更されているので新規登録しました", "登録完了");

                    OleDbCommand delete_cmd = new OleDbCommand("DELETE FROM 社員マスタ WHERE 社員ID = @id", cn);  //ID
                    delete_cmd.Parameters.AddWithValue("@id", empid);
                    try
                    {
                        cn.Open();                 //コネクションを開く
                        delete_cmd.ExecuteNonQuery();     //SQLを実行
                        cn.Close();                //コネクションを閉じる
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        cn.Close();                //コネクションを閉じる
                        return;
                    }

                    MessageBox.Show("旧IDのデータを削除しました", "削除完了");
                }
            }
        }


        private void dataload()   //カスタム関数
        {


            OleDbDataAdapter department_da =
               new OleDbDataAdapter("SELECT 部署ID,部署名,部署責任者 FROM 部署テーブル", cn);
            DataTable department_dt = new DataTable();
            department_da.Fill(department_dt);

            cmb_department1.DataSource = department_dt;
            cmb_department1.DisplayMember = "部署名";
            cmb_department1.ValueMember = "部署名";


            OleDbDataAdapter position_da =
                new OleDbDataAdapter("SELECT 役職ID,役職名 FROM 役職テーブル", cn);
            DataTable position_dt = new DataTable();
            position_da.Fill(position_dt);

            cmb_position1.DataSource = position_dt;
            cmb_position1.DisplayMember = "役職名";
            cmb_position1.ValueMember = "役職名";

            OleDbDataAdapter clerk_da =
                new OleDbDataAdapter("SELECT 店舗ID,店舗名,郵便番号,住所,責任者,電話番号" +
                " FROM 店舗マスタ", cn);
            DataTable clerk_dt = new DataTable();
            clerk_da.Fill(clerk_dt);

            cmb_clerk1.DataSource = clerk_dt;
            cmb_clerk1.DisplayMember = "店舗ID";
            cmb_clerk1.ValueMember = "店舗ID";

            OleDbDataAdapter department1_da =
               new OleDbDataAdapter("SELECT 部署ID,部署名,部署責任者 FROM 部署テーブル", cn);
            DataTable department1_dt = new DataTable();
            department1_da.Fill(department1_dt);

            cmb_department.DataSource = department1_dt;
            cmb_department.DisplayMember = "部署名";
            cmb_department.ValueMember = "部署名";


            OleDbDataAdapter position1_da =
                new OleDbDataAdapter("SELECT 役職ID,役職名 FROM 役職テーブル", cn);
            DataTable position1_dt = new DataTable();
            position1_da.Fill(position1_dt);

            cmb_position.DataSource = position1_dt;
            cmb_position.DisplayMember = "役職名";
            cmb_position.ValueMember = "役職名";

            OleDbDataAdapter clerk1_da =
                new OleDbDataAdapter("SELECT 店舗ID,店舗名,郵便番号,住所,責任者,電話番号" +
                " FROM 店舗マスタ", cn);
            DataTable clerk1_dt = new DataTable();
            clerk1_da.Fill(clerk1_dt);

            cmb_clerk.DataSource = clerk1_dt;
            cmb_clerk.DisplayMember = "店舗ID";
            cmb_clerk.ValueMember = "店舗ID";

        }

        private void cmb_sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cmb_sex.SelectedItem.ToString();
        }

        private void cmb_department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cmb_department.Text == "営業")
            {
                txt_idhead.Text = "A";
            }
            else
            {
                if (cmb_department.Text == "物流")
                {
                    txt_idhead.Text = "B";
                }
                else
                {
                    txt_idhead.Text = "Z";
                }
            }

            if (cmb_position.Text != "一般社員")
            {
                switch (txt_idhead.Text)
                {
                    case "A":
                        txt_idhead.Text = "D";
                        break;

                    case "B":
                        txt_idhead.Text = "E";
                        break;

                    case "Z":
                        txt_idhead.Text = "C";
                        break;
                }
            }

            if (cmb_department1.Text == "営業")
            {
                txt_idhead1.Text = "A";
            }
            else
            {
                if (cmb_department1.Text == "物流")
                {
                    txt_idhead1.Text = "B";
                }
                else
                {
                    txt_idhead1.Text = "Z";
                }
            }

            if (cmb_position1.Text != "一般社員")
            {
                switch (txt_idhead1.Text)
                {
                    case "A":
                        txt_idhead1.Text = "D";
                        break;

                    case "B":
                        txt_idhead1.Text = "E";
                        break;

                    case "Z":
                        txt_idhead1.Text = "C";
                        break;
                }
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (cmb_department1.Text == "営業")
            {
                txt_idhead1.Text = "A";
            }
            else
            {
                if (cmb_department.Text == "物流")
                {
                    txt_idhead1.Text = "B";
                }
                else
                {
                    txt_idhead1.Text = "Z";
                }
            }

            if (cmb_position1.Text != "一般社員")
            {
                switch (txt_idhead1.Text)
                {
                    case "A":
                        txt_idhead1.Text = "D";
                        break;

                    case "B":
                        txt_idhead1.Text = "E";
                        break;

                    case "Z":
                        txt_idhead1.Text = "C";
                        break;
                }
            }
        }

        private void txt_idhead_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkB_Delete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkB_Delete.Checked)
            {
                DialogResult result = MessageBox.Show("社員の情報が削除されますがよろしいですか？", "削除", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    checkB_Delete.Checked = false;
                }
            }

        }

    }
    
}
