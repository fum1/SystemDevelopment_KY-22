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
    public partial class StockList : UserControl
    {
        OleDbConnection cn; //コネクションオブジェクト

        public StockList()
        {
            InitializeComponent();
        }

        private void StockList_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();
                cn.ConnectionString =
                        @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
                dataload();

                comboBox1.SelectedIndex = 0;
                comboBox5.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;

            }
        }

        private void dataload()   //カスタム関数
        {
            string queryString = "SELECT 在庫テーブル.在庫ID, 在庫テーブル.商品詳細ID, 商品詳細テーブル.商品ID, 商品マスタ.商品名, 商品マスタ.定価, 商品マスタ.車種, 商品マスタ.[メーカー], 商品マスタ.仕入先ID, 商品詳細テーブル.走行距離, 商品詳細テーブル.発売日, 商品詳細テーブル.[オプション], 商品詳細テーブル.色, 商品詳細テーブル.[モデル], 商品詳細テーブル.実売価格, 在庫テーブル.在庫数量 FROM 商品マスタ INNER JOIN (商品詳細テーブル INNER JOIN 在庫テーブル ON 商品詳細テーブル.商品詳細ID = 在庫テーブル.商品詳細ID) ON 商品マスタ.商品ID = 商品詳細テーブル.商品ID ORDER BY 在庫ID";
            OleDbDataAdapter da = new OleDbDataAdapter (queryString, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();           //列の幅の自動調整

            //コンボボックスにデータテーブルをセット
            this.comboB_CarName.DataSource = dt;
            this.comboB_CarName.DisplayMember = "商品名";
            this.comboB_CarName.ValueMember = "商品名";

            this.comboB_Maker.DataSource = dt;
            this.comboB_Maker.DisplayMember = "メーカー";
            this.comboB_Maker.ValueMember = "メーカー";
        }

        private void btn_CarNameSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand("SELECT 在庫テーブル.在庫ID, 在庫テーブル.商品詳細ID, 商品詳細テーブル.商品ID, 商品マスタ.商品名, 商品マスタ.定価, 商品マスタ.車種, 商品マスタ.[メーカー], 商品マスタ.仕入先ID, 商品詳細テーブル.走行距離, 商品詳細テーブル.発売日, 商品詳細テーブル.[オプション], 商品詳細テーブル.色, 商品詳細テーブル.[モデル], 商品詳細テーブル.実売価格, 在庫テーブル.在庫数量 FROM 商品マスタ INNER JOIN (商品詳細テーブル INNER JOIN 在庫テーブル ON 商品詳細テーブル.商品詳細ID = 在庫テーブル.商品詳細ID) ON 商品マスタ.商品ID = 商品詳細テーブル.商品ID " +
                "WHERE 商品名=@CarName ORDER BY 在庫ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@CarName", comboB_CarName.Text);  //ポジションIDのコンボボックス

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_MakerSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand("SELECT 在庫テーブル.在庫ID, 在庫テーブル.商品詳細ID, 商品詳細テーブル.商品ID, 商品マスタ.商品名, 商品マスタ.定価, 商品マスタ.車種, 商品マスタ.[メーカー], 商品マスタ.仕入先ID, 商品詳細テーブル.走行距離, 商品詳細テーブル.発売日, 商品詳細テーブル.[オプション], 商品詳細テーブル.色, 商品詳細テーブル.[モデル], 商品詳細テーブル.実売価格, 在庫テーブル.在庫数量 FROM 商品マスタ INNER JOIN (商品詳細テーブル INNER JOIN 在庫テーブル ON 商品詳細テーブル.商品詳細ID = 在庫テーブル.商品詳細ID) ON 商品マスタ.商品ID = 商品詳細テーブル.商品ID " +
                "WHERE [メーカー]=@Maker ORDER BY 在庫ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            cmd.Parameters.AddWithValue("@Maker", comboB_Maker.Text);  //ポジションIDのコンボボックス

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_PriceSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand("SELECT 在庫テーブル.在庫ID, 在庫テーブル.商品詳細ID, 商品詳細テーブル.商品ID, 商品マスタ.商品名, 商品マスタ.定価, 商品マスタ.車種, 商品マスタ.[メーカー], 商品マスタ.仕入先ID, 商品詳細テーブル.走行距離, 商品詳細テーブル.発売日, 商品詳細テーブル.[オプション], 商品詳細テーブル.色, 商品詳細テーブル.[モデル], 商品詳細テーブル.実売価格, 在庫テーブル.在庫数量 FROM 商品マスタ INNER JOIN (商品詳細テーブル INNER JOIN 在庫テーブル ON 商品詳細テーブル.商品詳細ID = 在庫テーブル.商品詳細ID) ON 商品マスタ.商品ID = 商品詳細テーブル.商品ID " +
                        " ORDER BY 在庫ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (int.Parse(comboBox3.Text) < int.Parse(comboBox1.Text))              //Parseはint型に変換する関数
            {
                for (int i = 0; dt.Rows.Count > i; i++)
                {
                    int price = int.Parse(dt.Rows[i][13].ToString());
                    if (int.Parse(comboBox3.Text) > price || price > int.Parse(comboBox1.Text))
                        dt.Rows[i].Delete();                            
                }
            }
            else
            {
                for (int i = 0; dt.Rows.Count > i; i++)
                {
                    int price = int.Parse(dt.Rows[i][13].ToString());
                    if (int.Parse(comboBox1.Text) > price || price > int.Parse(comboBox3.Text))
                        dt.Rows[i].Delete();
                }
            }
            

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_MileageSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand("SELECT 在庫テーブル.在庫ID, 在庫テーブル.商品詳細ID, 商品詳細テーブル.商品ID, 商品マスタ.商品名, 商品マスタ.定価, 商品マスタ.車種, 商品マスタ.[メーカー], 商品マスタ.仕入先ID, 商品詳細テーブル.走行距離, 商品詳細テーブル.発売日, 商品詳細テーブル.[オプション], 商品詳細テーブル.色, 商品詳細テーブル.[モデル], 商品詳細テーブル.実売価格, 在庫テーブル.在庫数量 FROM 商品マスタ INNER JOIN (商品詳細テーブル INNER JOIN 在庫テーブル ON 商品詳細テーブル.商品詳細ID = 在庫テーブル.商品詳細ID) ON 商品マスタ.商品ID = 商品詳細テーブル.商品ID " +
                "ORDER BY 在庫ID");  //Birthdayが指定した間にある
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (int.Parse(comboBox3.Text) < int.Parse(comboBox1.Text))
            {
                for (int i = 0; dt.Rows.Count > i; i++)
                {
                    int price = int.Parse(dt.Rows[i][13].ToString());
                    if (int.Parse(comboBox4.Text) > price || price > int.Parse(comboBox5.Text))
                        dt.Rows[i].Delete();            
                }
            }
            else
            {
                for (int i = 0; dt.Rows.Count > i; i++)
                {
                    int price = int.Parse(dt.Rows[i][13].ToString());
                    if (int.Parse(comboBox5.Text) > price || price > int.Parse(comboBox4.Text))
                        dt.Rows[i].Delete();
                }
            }

            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Close();
            dataload();
            cn.Open();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                OleDbCommand cmd =
                    new OleDbCommand("SELECT 在庫テーブル.在庫ID, 在庫テーブル.商品詳細ID, 商品詳細テーブル.商品ID, 商品マスタ.商品名, 商品マスタ.定価, 商品マスタ.車種, 商品マスタ.[メーカー], 商品マスタ.仕入先ID, 商品詳細テーブル.走行距離, 商品詳細テーブル.発売日, 商品詳細テーブル.[オプション], 商品詳細テーブル.色, 商品詳細テーブル.[モデル], 商品詳細テーブル.実売価格, 在庫テーブル.在庫数量 FROM 商品マスタ INNER JOIN (商品詳細テーブル INNER JOIN 在庫テーブル ON 商品詳細テーブル.商品詳細ID = 在庫テーブル.商品詳細ID) ON 商品マスタ.商品ID = 商品詳細テーブル.商品ID " +
                    "WHERE 在庫数量='0' ORDER BY 在庫ID");
                cmd.Connection = cn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;


                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
                dataGridView1.AutoResizeColumns();          //列の幅の自動調整
            }
            else
            {
                dataload();
            }

        }
    }
}
