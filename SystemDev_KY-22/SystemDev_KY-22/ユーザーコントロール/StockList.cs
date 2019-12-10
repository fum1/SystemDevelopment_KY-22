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

        OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト

        public StockList()
        {
            InitializeComponent();
        }

        private void StockList_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
            dataload();
        }

        private void dataload()   //カスタム関数
        {
            //string queryString = "SELECT 在庫テーブル.在庫ID, 在庫テーブル.商品詳細ID, 商品詳細テーブル.商品ID, 商品マスタ.商品名," +
            //                    " [メーカーマスター].[メーカー], 商品詳細テーブル.車種, 在庫テーブル.在庫数量, 車種マスタ.安全在庫数, 商品詳細テーブル.色," +
            //                    " 商品詳細テーブル.[モデル], 商品詳細テーブル.走行距離, 商品詳細テーブル.[オプション], 商品マスタ.仕入先ID, 商品詳細テーブル.実売価格" +
            //                    "FROM " +
            //                    "メーカーマスター INNER JOIN" +
            //                    "(" +

            //                       "(" +

            //                           "(" +
            //                           "車種マスタ INNER JOIN 商品マスタ ON 車種マスタ.車種 = 商品マスタ.車種" +
            //                           ") " +

            //                               "INNER JOIN 商品詳細テーブル ON" +

            //                               "(" +
            //                               "商品マスタ.商品ID = 商品詳細テーブル.商品ID" +
            //                               ") " +

            //                                    "AND" +

            //                                    "(" +
            //                                    "車種マスタ.車種 = 商品詳細テーブル.車種" +
            //                                    ")" +

            //                       ") " +
            //                     "INNER JOIN 在庫テーブル ON 商品詳細テーブル.商品詳細ID = 在庫テーブル.商品詳細ID" +
            //                     ")" +

            //                     " ON[メーカーマスター].[メーカー] = 商品マスタ.[メーカーID]";           
            string queryString = "SELECT 在庫テーブル.在庫ID, 在庫テーブル.商品詳細ID, 商品詳細テーブル.商品ID, 商品マスタ.商品名 FROM 在庫テーブル,商品詳細テーブル INNER JOIN 在庫テーブル ON 商品詳細テーブル.在庫詳細ID = 在庫テーブル.在庫詳細ID";
            
            //                               "(" +
            //                               "商品マスタ.商品ID = 商品詳細テーブル.商品ID"" +
            //                    "(" +

            //                       "(" +
            // PostNumber（郵便番号）、Address（住所）  Memberテーブルから
            OleDbDataAdapter da =
                new OleDbDataAdapter( queryString,cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();           //列の幅の自動調整

            // コンボボックスにデータテーブルをセット
            //this.comboB_CarName.DataSource = dt;
            //this.comboB_CarName.DisplayMember = "商品名";
            //this.comboB_CarName.ValueMember = "商品名";

            //this.comboB_Maker.DataSource = dt;
            //this.comboB_Maker.DisplayMember = "メーカー";
            //this.comboB_Maker.ValueMember = "メーカー";

        }
    }
}
