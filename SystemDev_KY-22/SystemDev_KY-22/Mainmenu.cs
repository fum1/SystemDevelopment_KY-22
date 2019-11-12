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
    public partial class MainMenu : Form
    {
        private readonly PanelControl pc = new PanelControl();
        private UserControl[] userControls;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu2_Load(object sender, EventArgs e)
        {
            userControls = new UserControl[4] {carOrder2,orderCheck2,stockList2,loaUnloading1};
            this.WindowState = FormWindowState.Maximized;
        }

        private void lB_MainTitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_StockList_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, stockList2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, carOrder2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, orderCheck2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls,loaUnloading1);
        }
    }
}
