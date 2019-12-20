namespace SystemDev_KY_22
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Vendorlist = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.btn_OrderList = new System.Windows.Forms.Button();
            this.Btn_EmpRegister = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.carOrderHistory1 = new SystemDev_KY_22.ユーザーコントロール.CarOrderHistory();
            this.vendor_list = new SystemDev_KY_22.ユーザーコントロール.Vendor_list();
            this.list_of_employees = new SystemDev_KY_22.ユーザーコントロール.List_of_employees();
            this.orderCheck = new SystemDev_KY_22.ユーザーコントロール.OrderCheck();
            this.empRegister = new SystemDev_KY_22.EmpRegister();
            this.orderHistory1 = new SystemDev_KY_22.ユーザーコントロール.OrderHistory();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 135);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("ＭＳ 明朝", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(1180, 14);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(361, 102);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "ログアウト";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 70);
            this.label1.TabIndex = 6;
            this.label1.Text = "管理者用メニュー";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_Vendorlist);
            this.panel2.Controls.Add(this.btn_employees);
            this.panel2.Controls.Add(this.selectPanel);
            this.panel2.Controls.Add(this.btn_OrderList);
            this.panel2.Controls.Add(this.Btn_EmpRegister);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 749);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(22, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 160);
            this.button1.TabIndex = 8;
            this.button1.Text = "発注履歴";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Vendorlist
            // 
            this.btn_Vendorlist.BackColor = System.Drawing.Color.Transparent;
            this.btn_Vendorlist.FlatAppearance.BorderSize = 0;
            this.btn_Vendorlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Vendorlist.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Vendorlist.ForeColor = System.Drawing.Color.Black;
            this.btn_Vendorlist.Image = ((System.Drawing.Image)(resources.GetObject("btn_Vendorlist.Image")));
            this.btn_Vendorlist.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Vendorlist.Location = new System.Drawing.Point(22, 698);
            this.btn_Vendorlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Vendorlist.Name = "btn_Vendorlist";
            this.btn_Vendorlist.Size = new System.Drawing.Size(248, 160);
            this.btn_Vendorlist.TabIndex = 7;
            this.btn_Vendorlist.Text = "仕入先一覧";
            this.btn_Vendorlist.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Vendorlist.UseVisualStyleBackColor = false;
            this.btn_Vendorlist.Click += new System.EventHandler(this.btn_Vendorlist_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.BackColor = System.Drawing.Color.Transparent;
            this.btn_employees.FlatAppearance.BorderSize = 0;
            this.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employees.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_employees.ForeColor = System.Drawing.Color.Black;
            this.btn_employees.Image = ((System.Drawing.Image)(resources.GetObject("btn_employees.Image")));
            this.btn_employees.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_employees.Location = new System.Drawing.Point(22, 551);
            this.btn_employees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(248, 160);
            this.btn_employees.TabIndex = 6;
            this.btn_employees.Text = "社員一覧";
            this.btn_employees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_employees.UseVisualStyleBackColor = false;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click_1);
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.Gray;
            this.selectPanel.Location = new System.Drawing.Point(280, 32);
            this.selectPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(11, 89);
            this.selectPanel.TabIndex = 5;
            this.selectPanel.Visible = false;
            // 
            // btn_OrderList
            // 
            this.btn_OrderList.BackColor = System.Drawing.Color.Transparent;
            this.btn_OrderList.FlatAppearance.BorderSize = 0;
            this.btn_OrderList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrderList.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_OrderList.ForeColor = System.Drawing.Color.Black;
            this.btn_OrderList.Image = ((System.Drawing.Image)(resources.GetObject("btn_OrderList.Image")));
            this.btn_OrderList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_OrderList.Location = new System.Drawing.Point(22, 237);
            this.btn_OrderList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OrderList.Name = "btn_OrderList";
            this.btn_OrderList.Size = new System.Drawing.Size(248, 160);
            this.btn_OrderList.TabIndex = 2;
            this.btn_OrderList.Text = "注文履歴";
            this.btn_OrderList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_OrderList.UseVisualStyleBackColor = false;
            this.btn_OrderList.Click += new System.EventHandler(this.Btn_OrderList_Click);
            // 
            // Btn_EmpRegister
            // 
            this.Btn_EmpRegister.BackColor = System.Drawing.Color.Transparent;
            this.Btn_EmpRegister.FlatAppearance.BorderSize = 0;
            this.Btn_EmpRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EmpRegister.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_EmpRegister.ForeColor = System.Drawing.Color.Black;
            this.Btn_EmpRegister.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EmpRegister.Image")));
            this.Btn_EmpRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_EmpRegister.Location = new System.Drawing.Point(22, 73);
            this.Btn_EmpRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_EmpRegister.Name = "Btn_EmpRegister";
            this.Btn_EmpRegister.Size = new System.Drawing.Size(248, 160);
            this.Btn_EmpRegister.TabIndex = 4;
            this.Btn_EmpRegister.Text = "社員登録";
            this.Btn_EmpRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_EmpRegister.UseVisualStyleBackColor = false;
            this.Btn_EmpRegister.Click += new System.EventHandler(this.Btn_EmpRegister_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.orderHistory1);
            this.panel3.Controls.Add(this.carOrderHistory1);
            this.panel3.Controls.Add(this.vendor_list);
            this.panel3.Controls.Add(this.list_of_employees);
            this.panel3.Controls.Add(this.orderCheck);
            this.panel3.Controls.Add(this.empRegister);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(297, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1259, 749);
            this.panel3.TabIndex = 2;
            // 
            // carOrderHistory1
            // 
            this.carOrderHistory1.BackColor = System.Drawing.Color.White;
            this.carOrderHistory1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.carOrderHistory1.Location = new System.Drawing.Point(80, 348);
            this.carOrderHistory1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.carOrderHistory1.Name = "carOrderHistory1";
            this.carOrderHistory1.Size = new System.Drawing.Size(1230, 735);
            this.carOrderHistory1.TabIndex = 5;
            this.carOrderHistory1.Visible = false;
            // 
            // vendor_list
            // 
            this.vendor_list.Location = new System.Drawing.Point(107, 401);
            this.vendor_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vendor_list.Name = "vendor_list";
            this.vendor_list.Size = new System.Drawing.Size(1149, 764);
            this.vendor_list.TabIndex = 4;
            this.vendor_list.Visible = false;
            // 
            // list_of_employees
            // 
            this.list_of_employees.BackColor = System.Drawing.Color.White;
            this.list_of_employees.Location = new System.Drawing.Point(161, 420);
            this.list_of_employees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_of_employees.Name = "list_of_employees";
            this.list_of_employees.Size = new System.Drawing.Size(1149, 764);
            this.list_of_employees.TabIndex = 3;
            this.list_of_employees.Visible = false;
            // 
            // orderCheck
            // 
            this.orderCheck.BackColor = System.Drawing.Color.White;
            this.orderCheck.Location = new System.Drawing.Point(80, 305);
            this.orderCheck.Margin = new System.Windows.Forms.Padding(5);
            this.orderCheck.Name = "orderCheck";
            this.orderCheck.Size = new System.Drawing.Size(1389, 879);
            this.orderCheck.TabIndex = 2;
            this.orderCheck.Visible = false;
            // 
            // empRegister
            // 
            this.empRegister.BackColor = System.Drawing.Color.White;
            this.empRegister.Location = new System.Drawing.Point(220, 222);
            this.empRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empRegister.Name = "empRegister";
            this.empRegister.Size = new System.Drawing.Size(1799, 982);
            this.empRegister.TabIndex = 1;
            this.empRegister.Visible = false;
            // 
            // orderHistory1
            // 
            this.orderHistory1.BackColor = System.Drawing.Color.White;
            this.orderHistory1.Location = new System.Drawing.Point(42, 222);
            this.orderHistory1.Name = "orderHistory1";
            this.orderHistory1.Size = new System.Drawing.Size(1230, 735);
            this.orderHistory1.TabIndex = 6;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu2";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button Btn_EmpRegister;
        private System.Windows.Forms.Button btn_OrderList;
        public System.Windows.Forms.Panel selectPanel;
        private EmpRegister empRegister1;
        private ユーザーコントロール.List_of_employees list_of_employees1;
        private ユーザーコントロール.OrderCheck orderCheck1;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_Vendorlist;
        private ユーザーコントロール.Vendor_list vendor_list1;
        private ユーザーコントロール.OrderCheck orderCheck2;
        private ユーザーコントロール.Vendor_list vendor_list;
        private ユーザーコントロール.List_of_employees list_of_employees;
        private ユーザーコントロール.OrderCheck orderCheck;
        private EmpRegister empRegister;
        private System.Windows.Forms.Button button1;
        private ユーザーコントロール.CarOrderHistory carOrderHistory1;
        private ユーザーコントロール.OrderHistory orderHistory1;
    }
}