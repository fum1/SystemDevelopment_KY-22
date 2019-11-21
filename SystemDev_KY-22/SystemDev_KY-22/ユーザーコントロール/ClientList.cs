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
    public partial class ClientList : UserControl
    {
        //OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト

        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            //cn.ConnectionString =
            //    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
            //dataload();
        }

        private void dataload()   //カスタム関数
        {
            // ID、Pass（パスワード）、Name(名前）
            // PostNumber（郵便番号）、Address（住所）  Memberテーブルから
            //OleDbDataAdapter da =
            //    new OleDbDataAdapter("SELECT 顧客ID,氏名,性別,生年月日,郵便番号,住所,電話番号", cn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            //dataGridView1.AutoResizeColumns();           //列の幅の自動調整

            // コンボボックスにデータテーブルをセット
            /*this.comboB_CarName.DataSource = dt;
            this.comboB_CarName.DisplayMember = "商品名";
            this.comboB_CarName.ValueMember = "商品名";

            this.comboB_Maker.DataSource = dt;
            this.comboB_Maker.DisplayMember = "メーカー";
            this.comboB_Maker.ValueMember = "メーカー";*/

        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
