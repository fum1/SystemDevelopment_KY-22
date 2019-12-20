using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDev_KY_22
{
    public partial class Login : Form
    {
        OleDbConnection cn = new OleDbConnection();  //コネクションオブジェクト
        public Login()
        {
            InitializeComponent();

            
            //流れを把握するために仮でコード書いてます。
            //実装時には削除するか使いまわすか再検討すること (fum1)
            radius = (int)(Math.Sqrt(Width * Width + Height * Height) / 2);
            ox = Width / 2;
            oy = Height / 2;
            Region = new Region(new GraphicsPath());
        }


        //流れを把握するために仮でコード書いてます。
        //実装時には削除するか使いまわすか再検討すること (fum1)
        private int radius { get; set; }
        private int ox { get; set; }
        private int oy { get; set; }

        public string id;


        public int flg;


        private void Login_Load(object sender, EventArgs e)
        {
            //流れを把握するために仮でコード書いてます。
            //実装時には削除するか使いまわすか再検討すること (fum1)
            Animator.Animate(200, (frame, resolution) =>
            {
                if (!Visible || IsDisposed) return false;
                var graphicsPath = new GraphicsPath();
                var r = radius * frame / resolution;
                graphicsPath.AddEllipse(new Rectangle(ox - r, oy - r, r * 2, r * 2));
                Region = new Region(graphicsPath);
                if (frame == resolution) Region = null;
                return true;
            });

            cn.ConnectionString =
     @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";

            this.ActiveControl = textB_id;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LB_ID_Click(object sender, EventArgs e)
        {

        }

        private void TextB_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MaskedTextB_PassWord_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(); //データアダプタオブジェクト
            OleDbCommand cmd = new OleDbCommand();        //コマンドオブジェクト
            string sid = textB_id.Text;
            string spass = MaskedTextB_PassWord.Text;
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM 社員マスタ WHERE 社員ID=@id AND パスワード=@pass";
            da.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@id", sid);         //IDのパラメータ
            cmd.Parameters.AddWithValue("@pass", spass);     //Passのパラメータ
            DataTable dt = new DataTable();
            da.Fill(dt);

            SalesMenu sm = new SalesMenu();
            MainMenu mm = new MainMenu();
            AdminMenu am = new AdminMenu();
            

            if (dt.Rows.Count > 0)    //データテーブルの行数
            {
                this.Hide();
                id = textB_id.Text;
                switch (id.Substring(0,1))
                {
                    case "A":
                        sm.ShowDialog();
                        break;
                    case "B":
                        mm.ShowDialog();
                        break;
                    case "C":
                        am.ShowDialog();
                        break;
                    case "D":
                        DialogResult result = MessageBox.Show("管理者用メニューに切り替えますか？", "ログインメニュー", MessageBoxButtons.YesNo);
                        if(result == DialogResult.Yes)
                        {
                            am.ShowDialog();
                        }
                        else
                        {
                            sm.ShowDialog();
                        }
                        break;
                    case "E":
                        DialogResult result2 = MessageBox.Show("管理者用メニューに切り替えますか？", "ログインメニュー", MessageBoxButtons.YesNo);
                        if (result2 == DialogResult.Yes)
                        {
                            am.ShowDialog();
                        }
                        else
                        {
                            mm.ShowDialog();
                        }
                        break;
                    case "Z":
                        MessageBox.Show("ログインには成功しましたが、あなたには使用する権限がありません。");
                        break;
                }
            }
            else
            {
                MessageBox.Show("ID、パスワードを確認してください。", "WinSystem02");

            }

            cn.Close();



            //if(int.TryParse(textB_id.Text,out id))
            //{

            //}
            //else
            //{
            //    MessageBox.Show("IDに半角数字を入力してください。 営業 = 0,物流 = 1,Admin = 2");
            //}


            ////流れを把握するために仮でコード書いてます。
            ////実装時には削除するか使いまわすか再検討すること (fum1)

        }

        private void PictB_Logo_Click(object sender, EventArgs e)
        {

        }

        private void LB_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
