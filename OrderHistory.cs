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
            OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト

            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

            // タイマーの間隔(ミリ秒)
            Timer timer = new Timer(300000);

            // タイマーを開始する
            timer.Start();

            timer.Elapsed += (sender, e) =>
            {
                OleDbCommand cmd =
                   new OleDbCommand("SELECT 受注ID , 注文ID , 処理 FROM 受注テーブル WHERE 注文ID=@注文ID ORDER BY 注文ID", cn);
                cmd.Connection = cn;
                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cmd;
            };

            Console.ReadKey();
        }


    }
}
