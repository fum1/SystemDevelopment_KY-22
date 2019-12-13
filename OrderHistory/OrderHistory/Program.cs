using System;
using System.Collections.Generic;
using System.Data;
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
            //Timer timer = new Timer(300000);
            Timer timer = new Timer(300000);

            int a;
            int b;
            int c;

            // タイマーを開始する
            timer.Start();
            
            timer.Elapsed += (sender, e) =>
            {
                DateTime time = DateTime.Now;
                Console.WriteLine("System:テーブルの更新状況の確認を開始します("+time+")");

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cn.Open();           //先にDBを開いておく

                OleDbDataAdapter da =
                    new OleDbDataAdapter("SELECT 注文ID FROM 注文テーブル ORDER BY 注文ID ", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                OleDbDataAdapter da2 =
                    new OleDbDataAdapter("SELECT * FROM 受注テーブル ORDER BY 注文ID ", cn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                a = int.Parse(dt.Rows[dt.Rows.Count - 1]["注文ID"].ToString());
                b = int.Parse(dt2.Rows[dt2.Rows.Count - 1]["注文ID"].ToString());

                cn.Close();
                
                if (a > b)
                {
                    Console.WriteLine("System:受注リストにない新しい注文データが見つかりました。");
                    Console.WriteLine("System:登録を開始します。" + Environment.NewLine);
                    cn.Open();
                    for (b++; b <= a; b++)
                    {

                        da2.Fill(dt2);
                        c = int.Parse(dt2.Rows[dt2.Rows.Count - 1]["受注ID"].ToString()) + 1;
           
                        OleDbCommand cmd3 =
                            new OleDbCommand("INSERT INTO 受注テーブル (受注ID,注文ID) " +
                            "VALUES (@受注ID, @注文ID)", cn);
                        cmd3.Parameters.AddWithValue("@受注ID", c.ToString());
                        cmd3.Parameters.AddWithValue("@注文ID", b.ToString());

                        try
                        {
                            cmd3.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            cn.Close();               //コネクションを閉じる
                            return;
                        }
                        Console.WriteLine("System:新たに登録されたデータ -> 受注ID:" + c.ToString() + " 注文ID:" + b.ToString());
                    }
                    Console.WriteLine(Environment.NewLine + "System:データの更新が完了しました" + Environment.NewLine + Environment.NewLine);
                    cn.Close();
                }
                else
                {
                    Console.WriteLine("System:新しいデータはありませんでした" + Environment.NewLine + Environment.NewLine);
                }
            };
            Console.ReadKey();
        }
    }
}
