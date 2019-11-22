using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemDev_KY_22
{
    public partial class SalesMenu : Form
    {

        private readonly PanelControl pc = new PanelControl();
        private UserControl[] userControls;

        public SalesMenu()
        {
            InitializeComponent();

            stockList1.Visible = false;
            clientRegisterU1.Visible = false;
            order1.Visible = false;
        }

        private void Btn_StockList_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, stockList1);
        }

        private void Btn_ClientRegister_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, clientRegisterU1);
        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, order1);

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salesmenu2_Load(object sender, EventArgs e)
        {
            userControls = new UserControl[4] { stockList1, clientRegisterU1, order1,clientList21 };
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_ClientList_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, clientList21);
        }
    }
}
