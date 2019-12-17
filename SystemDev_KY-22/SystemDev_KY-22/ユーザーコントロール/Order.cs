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
    public partial class Order : UserControl
    {
        OleDbConnection cn; //コネクションオブジェクト
        DataTable dt;
        private int orederid;

        public Order()
        {
            InitializeComponent();
        }
        private void Order_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();
                cn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

                dataload();
            }
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
            txt_amountofmoney.Clear();
            textBox3.Clear();
            txt_itemid.Clear();

            dataload();

        }

        private void btn_decision_Click(object sender, EventArgs e)
        {

            string queryString = "SELECT 注文ID FROM 注文テーブル ORDER BY 注文ID DESC";
            OleDbDataAdapter da = new OleDbDataAdapter(queryString, cn);
            DataTable dt = new DataTable();

            DataRow dr = dt.Rows[0];

            da.Fill(dt);
            orederid = int.Parse(dr["注文ID"].ToString());
            orederid += 1;

            OleDbCommand cmd =
               new OleDbCommand("INSERT INTO 注文テーブル (注文ID ,数量 ,顧客ID ,社員ID ,商品詳細ID" +
                                " 発送日 , 在庫減フラグ , 店舗ID , 受注日)" +
               "VALUES (@注文ID,@数量,@顧客ID,@社員ID,@商品詳細ID,@発送日,@在庫減フラグ,@店舗ID,@受注日)", cn);

           /* string queryString = "SELECT 注文ID FROM 注文テーブル ORDER BY 注文ID DESC";
            OleDbDataAdapter da = new OleDbDataAdapter(queryString, cn);
            DataTable dt = new DataTable();

            DataRow dr = dt.Rows[0];

            da.Fill(dt);
            orederid = int.Parse(dr["注文ID"].ToString());
            orederid += 1;*/


            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@注文ID", orederid.ToString());
            cmd.Parameters.AddWithValue("@受注日", dtp_Orderdate.Text);
            cmd.Parameters.AddWithValue("@店舗ID", txt_clientID.Text);
            cmd.Parameters.AddWithValue("@社員ID", txt_employeeID.Text);
            cmd.Parameters.AddWithValue("@顧客ID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@数量", textBox3.Text);




        }
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
              new OleDbCommand("SELECT 商品詳細テーブル.商品詳細ID, 商品マスタ.[メーカー], 商品マスタ.車種, 商品マスタ.商品名, 商品詳細テーブル.色, 商品詳細テーブル.車両状態, 商品詳細テーブル.実売価格, 商品詳細テーブル.[オプション]"+
                                "FROM 商品マスタ INNER JOIN 商品詳細テーブル ON 商品マスタ.商品ID = 商品詳細テーブル.商品ID",cn);


            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@商品詳細ID", txt_itemid.Text);
            try
            {
//              cn.Open();

                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    DataRow dr = dt.Rows[0];
                    cmb_manufacturer.Text = dr["メーカー"].ToString();
                    comboBox2.Text = dr["車種"].ToString();
                    textBox2.Text = dr["商品名"].ToString();
                    textBox1.Text=dr["色"].ToString();
                    txt_amountofmoney.Text = dr["実売価格"].ToString();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    cn.Close();                //コネクションを閉じる
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登録できません。" + ex.ToString());
                cn.Close();                //コネクションを閉じる
                return;
            }

        }


        private void txt_amountofmoney_TextChanged_1(object sender, EventArgs e)
        {
            txt_consumptiontax.Text = (int.Parse(txt_amountofmoney.Text) * 0.10).ToString();
            txt_total.Text = (int.Parse(txt_amountofmoney.Text) * 1.10).ToString();
        }
    }
}
    
            
    

