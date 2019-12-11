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
        private readonly PanelControl pc = new PanelControl();
        private UserControl[] userControls;
        

        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_EmpRegister_Click(object sender, EventArgs e)
        {
           pc.Set((Button)sender,selectPanel);
            pc.Chenge(userControls, empRegister);
        }

        private void Btn_SalesCheck_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender,selectPanel);
            pc.Chenge(userControls, salesList);

        }

        private void Btn_OrderList_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender,selectPanel);
            pc.Chenge(userControls, orderCheck);
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, list_of_employees);
        }

        private void btn_Vendorlist_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, vendor_list);
        }
        private void AdminMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            userControls = new UserControl[5] {  orderCheck, salesList, vendor_list,empRegister,list_of_employees };
        }
        
    };
}

