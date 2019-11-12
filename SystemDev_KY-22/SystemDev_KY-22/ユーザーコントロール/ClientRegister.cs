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
    }

}
