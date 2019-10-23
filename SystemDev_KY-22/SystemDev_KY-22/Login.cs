using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public int id = 0;

        private void Login_Load(object sender, EventArgs e)
        {
            //流れを把握するために仮でコード書いてます。
            //実装時には削除するか使いまわすか再検討すること (fum1)
            Animator.Animate(500, (frame, resolution) =>
            {
                if (!Visible || IsDisposed) return false;
                var graphicsPath = new GraphicsPath();
                var r = radius * frame / resolution;
                graphicsPath.AddEllipse(new Rectangle(ox - r, oy - r, r * 2, r * 2));
                Region = new Region(graphicsPath);
                if (frame == resolution) Region = null;
                return true;
            });
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
            if(int.TryParse(textB_id.Text,out id))
            {
                switch (id)
                {
                    case 0:
                        Salesmenu2 sm = new Salesmenu2();
                        sm.ShowDialog();
                        break;
                    case 1:
                        Mainmenu mm = new Mainmenu();
                        mm.ShowDialog();
                        break;
                    case 2:
                        AdminMenu am = new AdminMenu();
                        am.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("IDに半角数字を入力してください。 営業 = 0,物流 = 1,Admin = 2");
            }

            
            //流れを把握するために仮でコード書いてます。
            //実装時には削除するか使いまわすか再検討すること (fum1)

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
    }
}
