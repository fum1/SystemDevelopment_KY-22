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
    public partial class OrderHistory : UserControl
    {
        OleDbConnection cn; //コネクションオブジェクト
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();
                cn.ConnectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
                dataload();

            }
        }

        private void dataload()
        {
            OleDbDataAdapter da =
               new OleDbDataAdapter("SELECT * FROM 受注テーブル", cn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();

            cmb_StoreID.DataSource = dt;
            cmb_StoreID.DisplayMember = "店舗ID";
        }

        private void btn_DateTimeSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT * FROM 受注テーブル WHERE 受注日=@dtime", cn);

            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@dtime", DateTime.Parse(dateTimePicker1.Value.ToString()));

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_StoreIDSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT * FROM 受注テーブル WHERE 店舗ID=@storeid", cn);

            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //店舗IDを設定しているコントロールを設定
            cmd.Parameters.AddWithValue("@supplier", cmb_StoreID.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_EmpIDSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT * FROM 受注テーブル WHERE 社員ID=@empid", cn);

            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //店舗IDを設定しているコントロールを設定
            cmd.Parameters.AddWithValue("@empid", txt_EmpID.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_ClientID_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
              new OleDbCommand("SELECT * FROM 受注テーブル WHERE 顧客ID=@clientid", cn);

            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //店舗IDを設定しているコントロールを設定
            cmd.Parameters.AddWithValue("@clientid", txt_ClientID.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cn.Close();
            dataload();
            cn.Open();
        }
    }
}
