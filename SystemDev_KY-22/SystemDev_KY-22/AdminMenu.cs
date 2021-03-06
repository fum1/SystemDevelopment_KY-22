﻿using System;
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
            Login login = new Login();
            login.Show();
            this.Close();
        }



        private void Btn_SalesCheck_Click(object sender, EventArgs e)
        {
           

        }

        private void Btn_OrderList_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender,selectPanel);
            pc.Chenge(userControls, orderHistory1);
        }



        private void btn_Vendorlist_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, vendor_list);
        }
        private void AdminMenu_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            userControls = new UserControl[5] {  orderHistory1, vendor_list,empRegister,list_of_employees, carOrderHistory1 };
            
        }

        private void Btn_EmpRegister_Click_1(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, empRegister);
        }

        private void btn_employees_Click_1(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, list_of_employees);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pc.Set((Button)sender, selectPanel);
            pc.Chenge(userControls, carOrderHistory1);
        }
    };
}

