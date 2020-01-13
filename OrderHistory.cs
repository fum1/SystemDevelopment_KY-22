using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace OrderHistory
{
    class Program
    {

        static void Main(string[] args)
        {
            OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト
            cn.ConnectionString =
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = cn;
                cn.Open();


                OleDbDataAdapter da =
                    new OleDbDataAdapter("SELECT 注文ID FROM 注文テーブル ORDER BY 注文ID ", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                OleDbDataAdapter da2 =
                    new OleDbDataAdapter("SELECT * FROM 受注テーブル ORDER BY 注文ID ", cn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                if(int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString()) > int.Parse(dt2.Rows[dt.Rows.Count - 1][1].ToString()))
                {
                    int load = int.Parse(dt.Rows[dt.Rows.Count - 1][0].ToString());

                    for (int unload = int.Parse(dt2.Rows[dt.Rows.Count - 1][1].ToString()); unload < load; unload++)
                    {
                        OleDbCommand cmd3 =
                            new OleDbCommand("INSERT INTO 受注テーブル (受注ID,注文ID) " +
                            "VALUES (@受注ID, @注文ID)", cn);
                        cmd3.Parameters.AddWithValue("@受注ID", (int.Parse(dt2.Rows[unload][0].ToString() + 1).ToString()));
                        cmd3.Parameters.AddWithValue("@注文ID", (int.Parse(dt.Rows[load][0].ToString() + 1).ToString()));
                        load++;
                        try
                        {
                            cn.Open();                 //コネクションを開く
                            cmd3.ExecuteNonQuery();     //SQLを実行
                            cn.Close();                //コネクションを閉じる
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            cn.Close();               //コネクションを閉じる
                            return;
                        }
                    }
                    Console.WriteLine("注文テーブルの変更があったので登録しました");
                }
                cn.Close();
        }
    }
}
