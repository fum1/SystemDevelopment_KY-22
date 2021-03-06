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

namespace SystemDev_KY_22.ユーザーコントロール
{
    public partial class CarOrderHistory : UserControl
    {
        OleDbConnection cn; //コネクションオブジェクト
        public CarOrderHistory()
        {
            InitializeComponent();
        }
        private void CarOrderHistory_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();
                cn.ConnectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
                dataload();

                //cmd_SupplierID.SelectedIndex = 0;
            }
        }

        private void dataload()
        {
            OleDbDataAdapter da =
                new OleDbDataAdapter("SELECT 発注テーブル.発注ID, 発注テーブル.発注年月日, 発注テーブル.商品ID, 発注テーブル.社員ID, 発注テーブル.仕入先ID, 発注テーブル.個数 " +
                                     "FROM 発注テーブル",cn);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;    //最下行を非表示
            dataGridView1.AutoResizeColumns();

            OleDbDataAdapter da1 =
                 new OleDbDataAdapter("SELECT * FROM 仕入先マスタ", cn);

            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            cmb_SupplierID.DataSource = dt1;
            cmb_SupplierID.DisplayMember = "仕入先ID";
            cmb_SupplierID.ValueMember = "仕入先ID";
        }



        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cn.Close();
            dataload();
            cn.Open();

        }

        private void btn_DateSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 発注テーブル.発注ID, 発注テーブル.発注年月日, 発注テーブル.商品ID, 発注テーブル.社員ID, 発注テーブル.仕入先ID, 発注テーブル.個数 " +
                                "FROM 発注テーブル " +
                                "WHERE 発注年月日=@dtime1 ORDER BY 発注ID", cn);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //日時を設定しているコントロールを設定
            cmd.Parameters.AddWithValue("@dtime1", DateTime.Parse(dateTimePicker1.Value.ToString()));


            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_SupplierIDSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 発注テーブル.発注ID, 発注テーブル.発注年月日, 発注テーブル.商品ID, " +
                                "発注テーブル.社員ID, 発注テーブル.仕入先ID, 発注テーブル.個数 " +
                                "FROM 発注テーブル " +
                                "WHERE 仕入先ID = @supplier ORDER BY 発注ID", cn);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //日時を設定しているコントロールを設定
            cmd.Parameters.AddWithValue("@supplier", cmb_SupplierID.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_ProductIDSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 発注テーブル.発注ID, 発注テーブル.発注年月日, 発注テーブル.商品ID, 発注テーブル.社員ID, 発注テーブル.仕入先ID, 発注テーブル.個数 " +
                                "FROM 発注テーブル " +
                                "WHERE 商品ID=@product ORDER BY 発注ID", cn);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

            //日時を設定しているコントロールを設定
            cmd.Parameters.AddWithValue("@product", txt_ProductID.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

        private void btn_EmpIDSeach_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
               new OleDbCommand("SELECT 発注テーブル.発注ID, 発注テーブル.発注年月日, 発注テーブル.商品ID, 発注テーブル.社員ID, 発注テーブル.仕入先ID, 発注テーブル.個数 " +
                                "FROM 発注テーブル " +
                                "WHERE 社員ID=@emp ORDER BY 発注ID", cn);
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;

          
            cmd.Parameters.AddWithValue("@emp", txt_EmpID.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;   //最下行を非表示
            dataGridView1.AutoResizeColumns();          //列の幅の自動調整
        }

    }


}
