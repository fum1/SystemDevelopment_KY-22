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
    public partial class Order : UserControl
    {
        OleDbConnection cn = new OleDbConnection(); //コネクションオブジェクト
        public Order()
        {
            InitializeComponent();
        }
        private void Order_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

            dataload();
        }
        private void dataload()//カスタム関数
        {
            OleDbDataAdapter cmb_da =
                new OleDbDataAdapter("SELECT 店舗ID,店舗名,郵便番号,住所,責任者,電話番号 FROM 店舗マスタ", cn);
            DataTable clk_dt = new DataTable();
            cmb_da.Fill(clk_dt);

            comboBox1.DataSource = clk_dt;
            comboBox1.DisplayMember = "店舗ID";
            comboBox1.ValueMember = "店舗ID";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            cmb_manufacturer.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox2.Clear();
            textBox1.Clear();
            comboBox3.SelectedIndex = -1;
            txt_amountofmoney.Clear();
            txt_consumptiontax.Clear();
            txt_employeeID.Clear();
            txt_clientID.Clear();


            dataload();

        }
    }
}
