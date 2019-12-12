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
using System.Drawing.Printing;

namespace SystemDev_KY_22
{
    public partial class CarOrder : UserControl
    {
        OleDbConnection cn;  //コネクションオブジェクト
        DataTable dt;
        private string empid;


        public CarOrder()
        {

            InitializeComponent();
        }

        private void CarOrder_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                cn = new OleDbConnection();  //コネクションオブジェクト
                dt = new DataTable();
                cn.ConnectionString =
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog.ShowDialog();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printDocument.Print();
        }



        private void btn_preview_Click(object sender, EventArgs e)
        {
            //PrintDocumentオブジェクトの作成
            System.Drawing.Printing.PrintDocument po =
                new System.Drawing.Printing.PrintDocument();
            //PrintPageイベントハンドラの追加
            po.PrintPage +=
                new System.Drawing.Printing.PrintPageEventHandler(printDocument_PrintPage);

            ///PrintPreviewDialogオブジェクトの作成
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            //プレビューするPrintDocumentを設定
            ppd.Document = po;
            //印刷プレビューダイアログを表示する
            ppd.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //表示する文字列
            string print_lblorderID = lbl_orderID.Text;
            string print_lblsupplier = lbl_supplierID.Text;
            string print_lblcmpanyname = lbl_companyname.Text;
            string print_lblcompanytel = lbl_companytel.Text;
            string print_lblPerson = lbl_PersonID.Text;
            string print_lblorderdate = lbl_orderdate.Text;
            string print_lblnumber = lbl_number.Text;
          
            string print_txtorderID = txt_orderID.Text;
            string print_txtsupplier = txt_supplierID.Text;
            string print_txtcompanyname = txt_companyname.Text;
            string print_txtcompanytel = txt_companytel.Text;
            string print_txtPerson = txt_PersonID.Text;
            string print_cmborderdate = dtp_admissionday.Text;
            string print_txtnumber = txt_number.Text;
           

            /*Bitmap canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            Font fnt = new Font("HGP明朝E", 20);
            StringFormat sf = new StringFormat();
            //文字列を描画するときの大きさを計測する
            SizeF stringSize = g.MeasureString(print_lblsupplier, fnt, 500, sf);*/
            Font font = new Font("HGS創英ﾌﾟﾚｾﾞﾝｽEB", 50.0f);
            Brush brush = new SolidBrush(Color.Black);
            e.Graphics.DrawString("発注書", font, brush, new PointF(280, 20));

            Graphics g = e.Graphics;


            Font a = new Font("HGP明朝E", 30);


            //文字列を描画する
            g.DrawString(print_lblorderID + "        " + print_txtorderID, a, Brushes.Black, 110, 200);
            g.DrawString(print_lblsupplier + "     " + print_txtsupplier, a, Brushes.Black, 110, 300);
            g.DrawString(print_lblPerson + "        " + print_txtPerson, a, Brushes.Black, 110, 600);
            g.DrawString(print_lblorderdate + "  " + print_cmborderdate, a, Brushes.Black, 110, 700);
            g.DrawString(print_lblnumber + " 　　　　 " + print_txtnumber, a, Brushes.Black, 110, 800);

            g.DrawString(print_lblcmpanyname + "    " + print_txtcompanyname, a, Brushes.Black, 130, 400);
            g.DrawString(print_lblcompanytel + " " + print_txtcompanytel, a, Brushes.Black, 130, 500);

            

            /* //リソースを解放する
             fnt.Dispose();
             sf.Dispose();
             g.Dispose();

             //PictureBox1に表示する


             /*var image = pictureBox.Image;
             e.Graphics.DrawImage(image, e.MarginBounds);*/
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_orderID.ResetText();
            txt_supplierID.ResetText();
            txt_PersonID.ResetText();
            dtp_admissionday.ResetText();
            txt_number.ResetText();
            


        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd =
                new OleDbCommand("INSERT INTO 発注テーブル (発注ID,発注年月日, 社員ID, 仕入先ID, 個数) " +
                "VALUES (@発注ID, @発注年月日, @社員ID, @仕入先ID, @個数)", cn);
            //DBの列名に、PassWord (Microsoft Jet 4.0 の予約語)は使用できない
            //@パラメータが出てくる順番に設定する
            cmd.Parameters.AddWithValue("@発注ID", txt_orderID.Text);
            cmd.Parameters.AddWithValue("@発注年月日", dtp_admissionday.Text);                 //IDのデータ
            cmd.Parameters.AddWithValue("@社員ID", txt_PersonID.Text);             //Passのデータ
            cmd.Parameters.AddWithValue("@仕入先ID", txt_supplierID.Text);             //Nameのデータ
            cmd.Parameters.AddWithValue("@個数", txt_number.Text);   //PostNumberのデータ
            try
            {
                cn.Open();                 //コネクションを開く
                cmd.ExecuteNonQuery();     //SQLを実行
                cn.Close();                //コネクションを閉じる
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();               //コネクションを閉じる
                return;
            }
            MessageBox.Show("登録しました", "発注登録");
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            txt_orderID.Clear();
            txt_supplierID.Clear();
            txt_PersonID.Clear();
            txt_number.Clear();
        }

        private void btn_Suppliersearch_Click(object sender, EventArgs e)
        {
            empid = txt_supplierID.Text;
            OleDbCommand cmd =
                new OleDbCommand("SELECT 仕入先ID ,商品ID ,仕入先会社名 ,仕入先郵便番号 ,仕入先住所 ,仕入先電話番号  " +
              "FROM 仕入先マスタ WHERE 仕入先ID = @仕入先ID  ORDER BY 仕入先ID");
            cmd.Connection = cn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@仕入先ID", txt_supplierID.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);

            try
            {
                DataRow dr = dt.Rows[0];

                txt_companyname.Text = dr["仕入先会社名"].ToString();
                txt_companytel.Text = dr["仕入先電話番号"].ToString();

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("IDが見つかりませんでした");
                cn.Close();                //コネクションを閉じる
                return;
            }
        }
    }
}

