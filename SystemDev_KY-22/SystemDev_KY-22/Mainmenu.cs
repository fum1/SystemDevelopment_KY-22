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
            userControls = new UserControl[6] {carOrder,orderCheck,loaUnloading,stockList,storing1, Item };
            //this.WindowState = FormWindowState.Maximized;
            
        }

        private void lB_MainTitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_StockList_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, stockList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, carOrder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, orderCheck);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls,loaUnloading);
        }

        private void btn_storing_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, storing1);
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, Item);
        }
    }
}
