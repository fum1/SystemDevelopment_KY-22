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
    public partial class Salesmenu2 : Form
    {
        public Salesmenu2()
        {
            InitializeComponent();

            stockList1.Visible = false;
            clientRegisterU1.Visible = false;
            order1.Visible = false;
        }

        private void Btn_StockList_Click(object sender, EventArgs e)
        {
            selectPanel.Visible = true;
            selectPanel.Height = btn_StockList.Height;
            selectPanel.Top = btn_StockList.Top;

            stockList1.Visible = true;
            stockList1.Dock = DockStyle.Fill;

            clientRegisterU1.Visible = false;
            order1.Visible = false;
        }

        private void Btn_ClientRegister_Click(object sender, EventArgs e)
        {
            selectPanel.Visible = true;
            selectPanel.Height = btn_ClientRegister.Height;
            selectPanel.Top = btn_ClientRegister.Top;

            stockList1.Visible = false;

            clientRegisterU1.Visible = true;
            clientRegisterU1.Dock = DockStyle.Fill;
            order1.Visible = false;
        }

        private void Btn_Order_Click(object sender, EventArgs e)
        {
            selectPanel.Visible = true;
            selectPanel.Height = btn_Order.Height;
            selectPanel.Top = btn_Order.Top;

            stockList1.Visible = false;
            clientRegisterU1.Visible = false;
            order1.Visible = true;
            order1.Dock = DockStyle.Fill;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salesmenu2_Load(object sender, EventArgs e)
        {

        }
    }
}
