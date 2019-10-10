using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDev_KY_22
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //流れを把握するために仮でコード書いてます。
            //実装時には削除するか使いまわすか再検討すること (fum1)

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Splash fs = new Splash();
            fs.Show();
            fs.Refresh();
            Thread.Sleep(3000);//時間のかかる処理
            fs.Close();
            Application.Run(new Login());

        }
    }
}
