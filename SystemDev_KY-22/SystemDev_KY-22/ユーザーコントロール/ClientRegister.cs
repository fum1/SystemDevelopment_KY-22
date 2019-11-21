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

namespace SystemDev_KY_22
{
    public partial class ClientRegister : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        public ClientRegister()
        {
            InitializeComponent();
        }

        private void ClientRegister_Load(object sender, EventArgs e)
        {
            cn.ConnectionString =
                 @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SysDev.accdb;";
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txt_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_name.Focus();    //氏名の入力にフォーカスを当てる
            } 
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbtn_man.Focus();    //性別の入力にフォーカスを当てる
            }
        }

        private void rbtn_man_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtp_birthday.Focus();    //生年月日の入力にフォーカスを当てる
            }
        }

        private void dtp_birthday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txt_pos.Focus();    //郵便番号の入力にフォーカスを当てる
            }
        }

        private void txt_pos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_address.Focus();    //住所の入力にフォーカスを当てる
            }
        }

        private void txt_address_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_tel.Focus();    //TELの入力にフォーカスを当てる
            }
        }

        private void txt_tel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.Focus();    //TELの入力にフォーカスを当てる
            }
        }
    }
    }


