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
    public partial class ClientList : UserControl
    {
        OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト

        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList2_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
            dataload();

        }

        private void dataload()   //カスタム関数
        {
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT 顧客ID, 氏名, 性別, 生年月日, 郵便番号, 住所, 電話番号 FROM 顧客マスタ ORDER BY 顧客ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();           //列の幅の自動調整
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            if(radioB_Id.Checked == true)
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
                    cn.Close();
                    MessageBox.Show("顧客ID : " + dr["顧客ID"].ToString() + Environment.NewLine + "氏名 : " + dr["氏名"].ToString() + Environment.NewLine + "郵便番号 : " + dr["郵便番号"].ToString() + Environment.NewLine + "住所 : " + dr["住所"].ToString() + Environment.NewLine + "電話番号 : " + dr["電話番号"].ToString() + Environment.NewLine + "性別 : " + dr["性別"].ToString() + Environment.NewLine + "生年月日 : " + dr["生年月日"].ToString(), txt_id.Text + "の検索結果");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("IDが見つかりませんでした");
                    cn.Close();                //コネクションを閉じる
                    return;
                }
            }
            else
            {
                OleDbCommand cmd =
                    new OleDbCommand("SELECT 顧客ID , 氏名 , 住所 , 郵便番号 , 電話番号 , 性別 , 生年月日 FROM 顧客マスタ WHERE 氏名 = @氏名 ORDER BY 顧客ID", cn);
                cmd.Connection = cn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;

                cmd.Parameters.AddWithValue("@氏名", txt_id.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);

                try
                {
                    DataRow dr = dt.Rows[0];
                    cn.Close();
                    MessageBox.Show("顧客ID : " + dr["顧客ID"].ToString() + Environment.NewLine + "氏名 : " + dr["氏名"].ToString() + Environment.NewLine + "郵便番号 : " + dr["郵便番号"].ToString() + Environment.NewLine + "住所 : " + dr["住所"].ToString() + Environment.NewLine + "電話番号 : " + dr["電話番号"].ToString() + Environment.NewLine + "性別 : " + dr["性別"].ToString() + Environment.NewLine + "生年月日 : " + dr["生年月日"].ToString(), txt_id.Text + "の検索結果");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("氏名が見つかりませんでした");
                    cn.Close();                //コネクションを閉じる
                    return;
                }
        }


        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            /*int selectrow = dataGridView1.CurrentCell.RowIndex;                 //選択されている行番号
            textBID.Text =
                dataGridView1.Rows[selectrow].Cells["ID"].Value.ToString();     //ID
            textBPass.Text =
                dataGridView1.Rows[selectrow].Cells["パスワード"].Value.ToString(); //パスワード
            textBName.Text =
                dataGridView1.Rows[selectrow].Cells["名前"].Value.ToString();     //名前
            maskedTextBPostal.Text =
                dataGridView1.Rows[selectrow].Cells["郵便番号"].Value.ToString(); //郵便番号
            textBAddress.Text =
                dataGridView1.Rows[selectrow].Cells["住所"].Value.ToString();     //住所*/
        }

        private void radioB_Id_CheckedChanged(object sender, EventArgs e)
        {
            lbl_id.Text = "顧客ID:";
        }

        private void radioB_Name_CheckedChanged(object sender, EventArgs e)
        {
            lbl_id.Text = "氏名:";
        }
    }
}
