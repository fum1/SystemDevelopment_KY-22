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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu2_Load(object sender, EventArgs e)
        {

        }

        private void AdminMenu2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_EmpRegister_Click(object sender, EventArgs e)
        {
            selectPanel.Visible = true;
            selectPanel.Height = Btn_EmpRegister.Height;
            selectPanel.Top = Btn_EmpRegister.Top;
        }
    }
}
