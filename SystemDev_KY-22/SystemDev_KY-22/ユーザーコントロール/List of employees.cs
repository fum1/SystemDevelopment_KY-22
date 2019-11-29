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
            cmb_position.DisplayMember = "役職名";
            cmb_position.ValueMember = "役職";

            cmb_clerk.DataSource = dt;
            cmb_clerk.DisplayMember = "店舗ID";
            cmb_clerk.ValueMember = "店舗ID";

            cmb_department.DataSource = dt;
            cmb_department.DisplayMember = "部署";
            cmb_department.ValueMember = "部署";


            OleDbDataAdapter position_da =
                new OleDbDataAdapter("SELECT 役職ID,役職名 FROM 役職テーブル", cn);
            DataTable position_dt = new DataTable();
            position_da.Fill(position_dt);

            cmb_position.DataSource = position_dt;
            cmb_position.DisplayMember = "役職名";
            cmb_position.ValueMember = "役職名";


            OleDbDataAdapter dep_da =
                new OleDbDataAdapter("SELECT 部署ID,部署名,部署責任者 FROM 部署テーブル", cn);
            DataTable dep_dt = new DataTable();
            dep_da.Fill(dep_dt);

            cmb_department.DataSource = dep_dt;
            cmb_department.DisplayMember = "部署名";
            //cmb_department.ValueMember = "部署";

            OleDbDataAdapter clk_da =
                new OleDbDataAdapter("SELECT 店舗ID,店舗名,郵便番号,住所,責任者,電話番号 FROM 店舗マスタ", cn);
            DataTable clk_dt = new DataTable();
            clk_da.Fill(clk_dt);

            cmb_clerk.DataSource = clk_dt;
            cmb_clerk.DisplayMember = "店舗ID";
            cmb_clerk.ValueMember = "店舗ID";


        }

        private void btn_search_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd =
               new OleDbCommand("SELECT 社員ID , 氏名 , 住所 , 郵便番号 ," +
                "電話番号 , 性別 , 部署 , 役職 , 店舗ID , パスワード " +
                "FROM 社員マスタ WHERE 役職 = @役職 AND 店舗ID = @店舗ID AND 部署 = @部署 ORDER BY 社員ID");  //Birthdayが指定した間にある
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@役職", cmb_position.Text);
            cmd.Parameters.AddWithValue("@店舗ID", cmb_clerk.Text);
            cmd.Parameters.AddWithValue("@部署", cmb_department.Text);
            

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void cmb_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        private void cmb_clerk_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmb_department_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 社員ID , 氏名 , 住所 , 郵便番号 ," +
                "電話番号 , 性別 , 部署 , 役職 , 店舗ID , パスワード " +
                "FROM 社員マスタ WHERE 社員ID = @社員ID  ORDER BY 社員ID");  //Birthdayが指定した間にある
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@社員ID", txt_id.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            cmb_position.SelectedIndex = -1;
            cmb_clerk.SelectedIndex = -1;
            cmb_department.SelectedIndex = -1;

        }
    }
}
