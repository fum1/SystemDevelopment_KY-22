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
    
    public partial class List_of_employees : UserControl
        
    {
        OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト
        public List_of_employees()
        {
            InitializeComponent();
        }

        private void List_of_employees_Load_1(object sender, EventArgs e)
        {
            cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

            dataload();
        }
        private void dataload()   //カスタム関数
        {
            
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT 社員ID , 氏名 , 住所 , 郵便番号 ," +
                "電話番号 , 性別 , 部署 , 役職 , 店舗ID , パスワード " +
                "FROM 社員マスタ ORDER BY 社員ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();           //列の幅の自動調整

            cmb_position.DataSource = dt;
            cmb_position.DisplayMember = "役職";
            cmb_position.ValueMember = "役職";

            cmb_clerk.DataSource = dt;
            cmb_clerk.DisplayMember = "店舗ID";
            cmb_clerk.ValueMember = "店舗ID";

            cmb_department.DataSource = dt;
            cmb_department.DisplayMember = "部署";
            cmb_department.ValueMember = "部署";

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand("SELECT 社員ID , 氏名 , 住所 , 郵便番号 ," +
                "電話番号 , 性別 , 部署 , 役職 , 店舗ID , パスワード " +
                "FROM 社員マスタ WHERE 社員ID LIKE '%'+ @氏名 + '%' ORDER BY 社員ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@氏名", txt_id.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }
    }
}
