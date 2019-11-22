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
    }
}
