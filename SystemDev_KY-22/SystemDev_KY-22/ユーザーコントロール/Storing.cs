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
    public partial class Storing : UserControl
    {
        OleDbConnection cn;  //コネクションオブジェクト
        DataTable dt;
        public Storing()
        {
            InitializeComponent();
        }

        private void Storing_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();
                cn.ConnectionString =
                   @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                    new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション , 商品ID , 色 , モデル , 実売価格 , 車両状態 FROM 商品詳細テーブル WHERE 商品詳細ID = @商品詳細ID ORDER BY 商品詳細ID", cn);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@商品詳細ID", textBox1.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                DataRow dr = dt.Rows[0];
                cn.Close();
                MessageBox.Show("商品詳細ID : " + dr["商品詳細ID"].ToString() + Environment.NewLine + "走行距離 : " + dr["走行距離"].ToString() + Environment.NewLine + "発売日 : " + dr["発売日"].ToString() + Environment.NewLine + "オプション : " + dr["オプション"].ToString() +
                Environment.NewLine + "商品ID : " + dr["商品ID"].ToString() + Environment.NewLine + "色 : " + dr["色"].ToString() + Environment.NewLine + "モデル : " + dr["モデル"].ToString() + Environment.NewLine + " 実売価格: " + dr["実売価格"].ToString() + Environment.NewLine + "車両状態 : " + dr["車両状態"].ToString(), textBox1.Text + "の検索結果");
            }
            catch (Exception ex)
            {
                MessageBox.Show("IDが見つかりませんでした");
                cn.Close();                //コネクションを閉じる
                return;
            }
        }

        private void btn_IDcheck_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                    new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション , 商品ID , 色 , モデル , 実売価格 , 車両状態 FROM 商品詳細テーブル WHERE 商品詳細ID = @商品詳細ID ORDER BY 商品詳細ID", cn);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@商品詳細ID", textBox1.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                DataRow dr = dt.Rows[0];
                cn.Close();
                MessageBox.Show("商品詳細ID : " + dr["商品詳細ID"].ToString() + Environment.NewLine + "走行距離 : " + dr["走行距離"].ToString() + Environment.NewLine + "発売日 : " + dr["発売日"].ToString() + Environment.NewLine + "オプション : " + dr["オプション"].ToString() +
                Environment.NewLine + "商品ID : " + dr["商品ID"].ToString() + Environment.NewLine + "色 : " + dr["色"].ToString() + Environment.NewLine + "モデル : " + dr["モデル"].ToString() + Environment.NewLine + " 実売価格: " + dr["実売価格"].ToString() + Environment.NewLine + "車両状態 : " + dr["車両状態"].ToString(), textBox1.Text + "の検索結果");
            }
            catch (Exception ex)
            {
                MessageBox.Show("IDが見つかりませんでした");
                cn.Close();                //コネクションを閉じる
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //連番START
            string queryString = "SELECT 入庫ID FROM 入庫テーブル ORDER BY 入庫ID DESC";
            OleDbDataAdapter da = new OleDbDataAdapter(queryString, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            int itemID = int.Parse(dr["入庫ID"].ToString());
            for (int i = 0; dt.Rows.Count > i; i++)
            {
                dr = dt.Rows[i];
                if (int.Parse(dr["入庫ID"].ToString()) > itemID) itemID = int.Parse(dr["入庫ID"].ToString());
            }
            itemID += 1;
            //連番END
            DateTime dateTime = DateTime.Now;


            OleDbCommand cmd =
                   new OleDbCommand("INSERT INTO 入庫テーブル (入庫ID,入庫年月日,入庫数,仕入先ID,商品詳細ID)" +
                   "VALUES (@入庫ID,@入庫年月日,@入庫数,@仕入先ID,@商品詳細ID)", cn);


            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@入庫ID", itemID.ToString());
            cmd.Parameters.AddWithValue("@入庫年月日", dateTime.ToString());
            cmd.Parameters.AddWithValue("@入庫数", comboBox1.Text);
            cmd.Parameters.AddWithValue("@仕入先ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@商品詳細ID", textBox1.Text);

            try
            {
                cn.Open();                 //コネクションを開く
                cmd.ExecuteNonQuery();     //SQLを実行
                cn.Close();                //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();               //コネクションを閉じる
                return;
            }

            OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM 在庫テーブル WHERE 商品詳細ID = @商品詳細ID", cn);

            cmd2.Parameters.AddWithValue("@商品詳細ID", textBox1.Text);
            cmd2.Connection = cn;
            //cmd.Parameters.AddWithValue("@処理", "1");
            OleDbDataAdapter da2 = new OleDbDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            int stockvol = int.Parse(dt2.Rows[0]["在庫数量"].ToString());


            OleDbCommand cmd1 =
                    new OleDbCommand("UPDATE 在庫テーブル SET 在庫数量 = @在庫数量 WHERE (商品詳細ID = @商品詳細ID)", cn);
            cmd1.Parameters.AddWithValue("@在庫数量", stockvol + int.Parse(comboBox1.Text));
            cmd1.Parameters.AddWithValue("@商品詳細ID", textBox1.Text);
            try
            {
                cn.Open();                 //コネクションを開く
                cmd1.ExecuteNonQuery();     //SQLを実行
                cn.Close();                //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();                //コネクションを閉じる
                return;
            }


            MessageBox.Show("登録しました", "管理者");
        }

        private void btn_shipping_Click(object sender, EventArgs e)
        {
            //連番START
            string queryString = "SELECT 出庫ID FROM 出庫テーブル ORDER BY 出庫ID DESC";
            OleDbDataAdapter da = new OleDbDataAdapter(queryString, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            int itemID = int.Parse(dr["出庫ID"].ToString());
            for (int i = 0; dt.Rows.Count > i; i++)
            {
                dr = dt.Rows[i];
                if (int.Parse(dr["出庫ID"].ToString()) > itemID) itemID = int.Parse(dr["出庫ID"].ToString());
            }
            itemID += 1;
            //連番END
            DateTime dateTime = DateTime.Now;


            OleDbCommand cmd =
                   new OleDbCommand("INSERT INTO 出庫テーブル (出庫ID,出庫年月日,出庫数,在庫ID,商品詳細ID)" +
                   "VALUES (@出庫ID,@入庫年月日,@入庫数,@在庫ID,@商品詳細ID)", cn);


            //@パラメータが出てくる順番に設定する
           
            cmd.Parameters.AddWithValue("@出庫ID", itemID.ToString());
            cmd.Parameters.AddWithValue("@出庫年月日", dateTime.ToString());
            cmd.Parameters.AddWithValue("@出庫数", cmb_Shipping_Vol.Text);
            cmd.Parameters.AddWithValue("@商品詳細ID", txt_Product.Text);
            cmd.Parameters.AddWithValue("@在庫ID", txt_Product.Text);
            try
            {
                cn.Open();                 //コネクションを開く
                cmd.ExecuteNonQuery();     //SQLを実行
                cn.Close();                //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();               //コネクションを閉じる
                return;
            }

            OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM 在庫テーブル WHERE 商品詳細ID = @商品詳細ID", cn);

            cmd2.Parameters.AddWithValue("@商品詳細ID", txt_Product.Text);
            cmd2.Connection = cn;
            //cmd.Parameters.AddWithValue("@処理", "1");
            OleDbDataAdapter da2 = new OleDbDataAdapter();
            da2.SelectCommand = cmd2;
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            int stockvol = int.Parse(dt2.Rows[0]["在庫数量"].ToString());


            OleDbCommand cmd1 =
                    new OleDbCommand("UPDATE 在庫テーブル SET 在庫数量 = @在庫数量 WHERE (商品詳細ID = @商品詳細ID)", cn);
            cmd1.Parameters.AddWithValue("@在庫数量", stockvol - int.Parse(cmb_Shipping_Vol.Text));
            cmd1.Parameters.AddWithValue("@商品詳細ID", txt_Product.Text);
            try
            {
                cn.Open();                 //コネクションを開く
                cmd1.ExecuteNonQuery();     //SQLを実行
                cn.Close();                //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();                //コネクションを閉じる
                return;
            }

            MessageBox.Show("登録しました", "管理者");


        }

        private void button4_Click(object sender, EventArgs e)
        {

            //連番START
            string queryString = "SELECT 在庫ID FROM 在庫テーブル ORDER BY 在庫ID DESC";
            OleDbDataAdapter da = new OleDbDataAdapter(queryString, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            int itemID = int.Parse(dr["在庫ID"].ToString());
            for (int i = 0; dt.Rows.Count > i; i++)
            {
                dr = dt.Rows[i];
                if (int.Parse(dr["在庫ID"].ToString()) > itemID) itemID = int.Parse(dr["在庫ID"].ToString());
            }
            itemID += 1;
            //連番END

            OleDbCommand cmd =
                   new OleDbCommand("INSERT INTO 在庫テーブル (在庫ID,在庫数量,商品詳細ID)" +
                   "VALUES (@在庫ID,@在庫数量,@商品詳細ID)", cn);


            //@パラメータが出てくる順番に設定する

            cmd.Parameters.AddWithValue("@在庫ID", itemID.ToString());
            cmd.Parameters.AddWithValue("@在庫数量", "0");
            cmd.Parameters.AddWithValue("@商品詳細ID", textBox5.Text);

            try
            {
                cn.Open();                 //コネクションを開く
                cmd.ExecuteNonQuery();     //SQLを実行
                cn.Close();                //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();               //コネクションを閉じる
                return;
            }
            MessageBox.Show("新規在庫を登録しました。");
        }
    }
    }

