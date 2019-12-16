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


            //OleDbDataAdapter cmb_manu_da =
            //    new OleDbDataAdapter("SELECT メーカー FROM メーカーマスタ", cn);
            //DataTable manufacturer_dt = new DataTable();
            //cmb_manu_da.Fill(manufacturer_dt);

            //cmb_manufacturer.DataSource = manufacturer_dt;
            //cmb_manufacturer.DisplayMember = "メーカー";
            //cmb_manufacturer.ValueMember = "メーカー";


            //OleDbDataAdapter cmb2_da =
            //    new OleDbDataAdapter("SELECT 車種,安全在庫数 FROM 車種マスタ", cn);
            //DataTable cmb2_dt = new DataTable();
            //cmb2_da.Fill(cmb2_dt);

            //comboBox2.DataSource = cmb2_dt;
            //comboBox2.DisplayMember = "車種";
            //comboBox2.ValueMember = "車種";

            //OleDbDataAdapter txt_money_da =
            //    new OleDbDataAdapter("SELECT 商品ID,商品名,定価,車種,メーカー,仕入れ先ID FROM 商品マスタ", cn);
            //DataTable amountofmoney_dt = new DataTable();
            //txt_money_da.Fill(amountofmoney_dt);

            //txt_amountofmoney.DataSource = amountofmoney_dt;
            //txt_amountofmoney.DisplayMember = "定価";
            //txt_amountofmoney.ValueMember = "定価";


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


            dataload();

        }

        private void btn_decision_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("INSERT INTO 注文テーブル (注文ID ,数量 ,顧客ID ,社員ID ,商品詳細ID," +
                                " 発送日 , 在庫減フラグ , 店舗ID , 注文日)" +
               "VALUES (@注文ID,@数量,@顧客ID,@社員ID,@商品詳細ID,@発送日,@在庫減フラグ,@店舗ID,@注文日)", cn);

            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@店舗ID", txt_clientID.Text);
            cmd.Parameters.AddWithValue("@社員ID", txt_employeeID.Text);
            cmd.Parameters.AddWithValue("@顧客ID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@数量", textBox3.Text);

            MessageBox.Show("登録しますか",
                            "登録",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            //string queryString = "SELECT 注文ID FROM 注文テーブル ORDER BY 注文ID DESC";
            //OleDbDataAdapter da = new OleDbDataAdapter(queryString,cn);
            //DataTable dt = new DataTable();

            //DataRow dr = dt.Rows[0];

            //da.Fill(dt);
            //orederid = int.Parse(dr["注文ID"].ToString());
            //orederid += 1;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
              new OleDbCommand("SELECT 商品詳細テーブル.商品詳細ID, 商品マスタ.[メーカー], 商品マスタ.車種, 商品マスタ.商品名, 商品詳細テーブル.色, 商品詳細テーブル.車両状態, 商品詳細テーブル.実売価格, 商品詳細テーブル.[オプション] " +
              "FROM 商品マスタ INNER JOIN 商品詳細テーブル ON 商品マスタ.商品ID = 商品詳細テーブル.商品ID WHERE 商品詳細テーブル.商品詳細ID = @商品詳細ID");

            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            cmd.Parameters.AddWithValue("@商品詳細ID", txt_itemid.Text);
            da.SelectCommand = cmd;

            da.Fill(dt);
            try
            {
                cn.Open();

                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    DataRow dr = dt.Rows[0];
                    cmb_manufacturer.Text = dr["メーカー"].ToString();
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
                MessageBox.Show("登録できません。"+ ex.ToString());
                cn.Close();                //コネクションを閉じる
                return;
            }

         }


        


        }
        //private void txt_amountofmoney_TextChanged(object sender, EventArgs e)
        //{
        //    txt_consumptiontax.Text = (int.Parse(txt_amountofmoney.Text) * 0.10).ToString();
        //    txt_total.Text = (int.Parse(txt_amountofmoney.Text) * 1.10).ToString();
        //}

        //private void textBox4_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
    
            
    

