﻿using System;
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
            // ID、Pass（パスワード）、Name(名前）
            // PostNumber（郵便番号）、Address（住所）  Memberテーブルから
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT 在庫テーブル.在庫ID, 在庫テーブル.商品詳細ID, 商品マスタ.商品ID, 商品マスタ.商品名, 商品マスタ.定価, 在庫テーブル.在庫数量, 商品詳細テーブル.走行距離, 商品詳細テーブル.発売日, 商品詳細テーブル.色, 商品詳細テーブル.[モデル], 商品詳細テーブル.実売価格, 商品詳細テーブル.仕入先ID, 車種マスタ.車種, 商品マスタ.[メーカー] FROM 車種マスタ INNER JOIN((商品マスタ INNER JOIN 商品詳細テーブル ON 商品マスタ.商品ID = 商品詳細テーブル.商品ID) INNER JOIN 在庫テーブル ON 商品詳細テーブル.商品詳細ID = 在庫テーブル.商品詳細ID) ON 車種マスタ.車種ID = 商品マスタ.車種ID", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();           //列の幅の自動調整

            // コンボボックスにデータテーブルをセット
            this.comboB_CarName.DataSource = dt;
            this.comboB_CarName.DisplayMember = "商品名";
            this.comboB_CarName.ValueMember = "商品名";

            this.comboB_Maker.DataSource = dt;
            this.comboB_Maker.DisplayMember = "メーカー";
            this.comboB_Maker.ValueMember = "メーカー";

        }
    }
}
