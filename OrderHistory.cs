using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Timers;

namespace OrderHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable();
            OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";


            // タイマーの間隔(5分)
            Timer timer = new Timer(300000);
            timer.Start();
            timer.Elapsed += (sender, e) =>
            {
                OleDbCommand cmd =
                   new OleDbCommand("SELECT * FROM 注文テーブル ORDER BY 注文ID DESC", cn);
                cmd.Connection = cn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
                dt.fill(da);

                //SQL文章の時点で注文IDの降順に設定しているのでrows[0]のデータを持ってくれば注文IDが一番おおきいやつになっているはず
                /*
                 * 
                 * この辺に書いて
                 * 
                 * 
                 * 
                 * 
                */

                //if(保存が完了している範囲の最大ID < 注文テーブルで最新のID)
                //{
                // 　増えた分のデータを注文テーブルから受注テーブルに保存する
                //   最新の分のIDを更新する
                //}
                //else
                //{
                //    スルーする
                //}


            };

            Console.ReadKey();
        }
    }
}
