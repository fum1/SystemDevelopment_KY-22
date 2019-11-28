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
    public partial class ClientList2 : UserControl
    {
        OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト

        public ClientList2()
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
            txt_name.Clear();
            txt_pos.Clear();
            txt_address.Clear();
            txt_tel.Clear();
            cmb_sex.SelectedIndex = -1;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            groupBox_client.Visible = true;

            OleDbCommand cmd =
                new OleDbCommand("SELECT 顧客ID , 氏名 , 住所 , 郵便番号 , 電話番号 , 性別 , 生年月日 FROM 顧客マスタ ORDER BY 社員ID",cn);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@顧客ID", txt_id.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.Rows[0];
            txt_name.Text = dr["氏名"].ToString();
            txt_pos.Text = dr["郵便番号"].ToString();
            txt_address.Text = dr["住所"].ToString();
            txt_tel.Text = dr["電話番号"].ToString();
            cmb_sex.Text = dr["性別"].ToString();

            cn.Close();
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
    }
}
