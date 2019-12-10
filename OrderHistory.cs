using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace OrderHistory
{
    class Program
    {
        static void Main(string[] args)
        {
            // タイマーの間隔(ミリ秒)
            Timer timer = new Timer(300000);

            // タイマーを開始する
            timer.Start();

            Console.ReadKey();
        }


    }
}
