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
    public partial class Item : UserControl
    {
        OleDbConnection cn; //コネクションオブジェクト
        DataTable dt;


        private int itemID;
        private int ProductID;


        public Item()
        {
            InitializeComponent();

        }



        private void Item_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection();
            cn.ConnectionString =
                       @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
            dataload();
            dataload2();
            Font();
        }
        private void btn_register_Click(object sender, EventArgs e)
        {

            //連番START
            string queryString = "SELECT 商品ID FROM 商品マスタ ORDER BY 商品ID DESC";
            OleDbDataAdapter da = new OleDbDataAdapter(queryString, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.Rows[0];
            itemID = int.Parse(dr["商品ID"].ToString());
            for (int i = 0; dt.Rows.Count > i; i++)
            {
                dr = dt.Rows[i];
                if (int.Parse(dr["商品ID"].ToString()) > itemID) itemID = int.Parse(dr["商品ID"].ToString());
            }
            itemID += 1;
            //連番END

            OleDbCommand cmd =
                 new OleDbCommand("INSERT INTO 商品マスタ (商品ID ,商品名 ,定価 ,車種 ,メーカー ,仕入先ID )" +
                                   "VALUES (@商品ID ,@商品名 ,@定価 ,@車種 ,@メーカー ,@仕入先ID )", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@商品ID", itemID.ToString());
            cmd.Parameters.AddWithValue("@商品名", txt_item.Text);
            cmd.Parameters.AddWithValue("@定価", txt_price.Text);
            cmd.Parameters.AddWithValue("@車種", cmb_type.Text);
            cmd.Parameters.AddWithValue("@メーカー", txt_maker.Text);
            cmd.Parameters.AddWithValue("@仕入先ID", txt_supplier.Text);

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
            MessageBox.Show("登録しました", "管理者");
            dataload();
        }

        private void btn_register1_Click(object sender, EventArgs e)
        {
            string queryString = "SELECT 商品詳細ID FROM 商品詳細テーブル ORDER BY 商品詳細ID DESC";//連番コードここから
            OleDbDataAdapter da = new OleDbDataAdapter(queryString, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow dr = dt.Rows[0];

            ProductID = int.Parse(dr["商品詳細ID"].ToString());
            ProductID += 1;

            OleDbCommand cmd =
                 new OleDbCommand("INSERT INTO 商品詳細テーブル (商品詳細ID ,走行距離 ,発売日 ,オプション ,商品ID ,色 ,モデル,実売価格,車両状態 )" +
                                   "VALUES (@商品詳細ID ,@走行距離 ,@発売日 ,@オプション ,@商品ID ,@色 ,@モデル ,@販売価格 ,@車両状態 )", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@商品詳細ID", ProductID.ToString());
            cmd.Parameters.AddWithValue("@走行距離", txt_mileage.Text);
            cmd.Parameters.AddWithValue("@発売日", txt_release.Text);
            cmd.Parameters.AddWithValue("@オプション", txt_option.Text);
            cmd.Parameters.AddWithValue("@商品ID", txt_itemID.Text);
            cmd.Parameters.AddWithValue("@色", txt_color.Text);
            cmd.Parameters.AddWithValue("@モデル", txt_model.Text);
            cmd.Parameters.AddWithValue("@販売価格", txt_actual.Text);
            cmd.Parameters.AddWithValue("@車両状態", txt_vehicle.Text);

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
            MessageBox.Show("登録しました", "管理者");

            dataload2();
        }

        private void dataload()   //カスタム関数
        {
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT * FROM 商品マスタ ORDER BY 商品ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);


            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();           //列の幅の自動調整



            OleDbDataAdapter type_da =
              new OleDbDataAdapter("SELECT 車種 FROM 車種マスタ", cn);
            DataTable type_dt = new DataTable();
            type_da.Fill(type_dt);

            cmb_type.DataSource = type_dt;
            cmb_type.DisplayMember = "車種";
            cmb_type.ValueMember = "車種";





        }

        private void dataload2()
        {

            OleDbDataAdapter da =
               new OleDbDataAdapter("SELECT * FROM 商品詳細テーブル ORDER BY 商品詳細ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);


            dataGridView2.DataSource = dt;
            dataGridView2.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView2.AutoResizeColumns();           //列の幅の自動調整

        }



        private void btn_itemsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
              new OleDbCommand("SELECT 商品ID , 商品名 , 定価 , 車種 ," +
               "メーカー , 仕入先ID  " +
               "FROM 商品マスタ WHERE 商品名 = @商品名  ORDER BY 商品ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@商品名", txt_item.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_pricesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
            new OleDbCommand("SELECT 商品ID , 商品名 , 定価 , 車種 ," +
             "メーカー , 仕入先ID  " +
             "FROM 商品マスタ WHERE 定価 = @定価  ORDER BY 商品ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@定価", txt_price.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_typesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
            new OleDbCommand("SELECT 商品ID , 商品名 , 定価 , 車種 ," +
             "メーカー , 仕入先ID  " +
             "FROM 商品マスタ WHERE 車種 = @車種  ORDER BY 商品ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@車種", cmb_type.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_makersearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
            new OleDbCommand("SELECT 商品ID , 商品名 , 定価 , 車種 ," +
             "メーカー , 仕入先ID  " +
             "FROM 商品マスタ WHERE メーカー = @メーカー  ORDER BY 商品ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@メーカー", txt_maker.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_suppliersearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
            new OleDbCommand("SELECT 商品ID , 商品名 , 定価 , 車種 ," +
             "メーカー , 仕入先ID  " +
             "FROM 商品マスタ WHERE 仕入先ID = @仕入先ID  ORDER BY 商品ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@仕入先ID", txt_supplier.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_itemIDsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
           new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション ," +
            "商品ID , 色 ,モデル ,実版価格 ,車両状態  " +
            "FROM 商品詳細テーブル WHERE 商品ID = @商品ID  ORDER BY 商品詳細ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@商品ID", txt_itemID.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_mileagesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
          new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション ," +
           "商品ID , 色 ,モデル ,実版価格 ,車両状態  " +
           "FROM 商品詳細テーブル WHERE 走行距離 = @走行距離  ORDER BY 商品詳細ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@走行距離", txt_mileage.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_releasesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
     　　 new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション ," +
      　　 "商品ID , 色 ,モデル ,実版価格 ,車両状態  " +
      　　 "FROM 商品詳細テーブル WHERE 発売日 = @発売日  ORDER BY 商品詳細ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@発売日", txt_release.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_optionsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
   　　　 new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション ," +
    　　　 "商品ID , 色 ,モデル ,実版価格 ,車両状態  " +
    　　　 "FROM 商品詳細テーブル WHERE オプション = @オプション  ORDER BY 商品詳細ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@オプション", txt_option.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_colorsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
   　　　new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション ," +
    　　　"商品ID , 色 ,モデル ,実版価格 ,車両状態  " +
   　　　 "FROM 商品詳細テーブル WHERE 色 = @色  ORDER BY 商品詳細ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@色", txt_color.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_modelsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
 　　　　new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション ," +
 　　　　 　"商品ID , 色 ,モデル ,実版価格 ,車両状態  " +
 　　　　　 "FROM 商品詳細テーブル WHERE モデル = @モデル  ORDER BY 商品詳細ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@モデル", txt_model.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_actualsearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
　　　　　new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション ," +
 　　　　　"商品ID , 色 ,モデル ,実版価格 ,車両状態  " +
 　　　　　"FROM 商品詳細テーブル WHERE 実売価格 = @実売価格  ORDER BY 商品詳細ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@実売価格", txt_actual.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_vehiclesearch_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
　　　　　new OleDbCommand("SELECT 商品詳細ID , 走行距離 , 発売日 , オプション ," +
 　　　　　　"商品ID , 色 ,モデル ,実版価格 ,車両状態  " +
 　　　　　　"FROM 商品詳細テーブル WHERE 車両状況 = @車両状況  ORDER BY 商品詳細ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@車両状況", txt_vehicle.Text);


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void Font()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("メイリオ", 9);
            this.dataGridView2.DefaultCellStyle.Font = new Font("メイリオ", 9);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_item.Clear();
            txt_price.Clear();
            txt_maker.Clear();
            txt_supplier.Clear();
            cmb_type.SelectedIndex = -1;
        }

        private void btn_clear2_Click(object sender, EventArgs e)
        {
            txt_itemID.Clear();
            txt_mileage.Clear();
            txt_release.Clear();
            txt_option.Clear();
            txt_color.Clear();
            txt_model.Clear();
            txt_actual.Clear();
            txt_vehicle.Clear();

                



        }
    }
}
