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
            //userControls = new UserControl[3] { };
        }

        private void lB_MainTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
