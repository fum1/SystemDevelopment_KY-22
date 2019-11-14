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
            this.btn_employees = new System.Windows.Forms.Button();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.btn_OrderList = new System.Windows.Forms.Button();
            this.Btn_EmpRegister = new System.Windows.Forms.Button();
            this.btn_SalesList = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.salesList1 = new SystemDev_KY_22.SalesList();
            this.orderCheck1 = new SystemDev_KY_22.ユーザーコントロール.OrderCheck();
            this.empRegister1 = new SystemDev_KY_22.EmpRegister();
            this.list_of_employees1 = new SystemDev_KY_22.ユーザーコントロール.List_of_employees();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 108);
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
            this.btn_logout.Location = new System.Drawing.Point(885, 11);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(271, 82);
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
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "管理者用メニュー";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btn_employees);
            this.panel2.Controls.Add(this.selectPanel);
            this.panel2.Controls.Add(this.btn_OrderList);
            this.panel2.Controls.Add(this.Btn_EmpRegister);
            this.panel2.Controls.Add(this.btn_SalesList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 599);
            this.panel2.TabIndex = 1;
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
            this.btn_employees.Location = new System.Drawing.Point(21, 554);
            this.btn_employees.Margin = new System.Windows.Forms.Padding(2);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(186, 128);
            this.btn_employees.TabIndex = 6;
            this.btn_employees.Text = "社員一覧";
            this.btn_employees.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_employees.UseVisualStyleBackColor = false;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.Gray;
            this.selectPanel.Location = new System.Drawing.Point(211, 77);
            this.selectPanel.Margin = new System.Windows.Forms.Padding(2);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(8, 71);
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
            this.btn_OrderList.Location = new System.Drawing.Point(21, 376);
            this.btn_OrderList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OrderList.Name = "btn_OrderList";
            this.btn_OrderList.Size = new System.Drawing.Size(186, 128);
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
            this.Btn_EmpRegister.Location = new System.Drawing.Point(21, 198);
            this.Btn_EmpRegister.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_EmpRegister.Name = "Btn_EmpRegister";
            this.Btn_EmpRegister.Size = new System.Drawing.Size(186, 128);
            this.Btn_EmpRegister.TabIndex = 4;
            this.Btn_EmpRegister.Text = "社員登録";
            this.Btn_EmpRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_EmpRegister.UseVisualStyleBackColor = false;
            this.Btn_EmpRegister.Click += new System.EventHandler(this.Btn_EmpRegister_Click);
            // 
            // btn_SalesList
            // 
            this.btn_SalesList.BackColor = System.Drawing.Color.Transparent;
            this.btn_SalesList.FlatAppearance.BorderSize = 0;
            this.btn_SalesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalesList.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_SalesList.ForeColor = System.Drawing.Color.Black;
            this.btn_SalesList.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalesList.Image")));
            this.btn_SalesList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SalesList.Location = new System.Drawing.Point(21, 26);
            this.btn_SalesList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SalesList.Name = "btn_SalesList";
            this.btn_SalesList.Size = new System.Drawing.Size(186, 122);
            this.btn_SalesList.TabIndex = 3;
            this.btn_SalesList.Text = "売上確認";
            this.btn_SalesList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SalesList.UseVisualStyleBackColor = false;
            this.btn_SalesList.Click += new System.EventHandler(this.Btn_SalesCheck_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.salesList1);
            this.panel3.Controls.Add(this.orderCheck1);
            this.panel3.Controls.Add(this.empRegister1);
            this.panel3.Controls.Add(this.list_of_employees1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(223, 108);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 599);
            this.panel3.TabIndex = 2;
            // 
            // salesList1
            // 
            this.salesList1.BackColor = System.Drawing.Color.White;
            this.salesList1.Location = new System.Drawing.Point(50, 543);
            this.salesList1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salesList1.Name = "salesList1";
            this.salesList1.Size = new System.Drawing.Size(782, 562);
            this.salesList1.TabIndex = 0;
            // 
            // orderCheck1
            // 
            this.orderCheck1.BackColor = System.Drawing.Color.White;
            this.orderCheck1.Location = new System.Drawing.Point(91, 238);
            this.orderCheck1.Margin = new System.Windows.Forms.Padding(5);
            this.orderCheck1.Name = "orderCheck1";
            this.orderCheck1.Size = new System.Drawing.Size(1042, 703);
            this.orderCheck1.TabIndex = 3;
            // 
            // empRegister1
            // 
            this.empRegister1.BackColor = System.Drawing.Color.White;
            this.empRegister1.Location = new System.Drawing.Point(34, 440);
            this.empRegister1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.empRegister1.Name = "empRegister1";
            this.empRegister1.Size = new System.Drawing.Size(782, 562);
            this.empRegister1.TabIndex = 2;
            // 
            // list_of_employees1
            // 
            this.list_of_employees1.BackColor = System.Drawing.Color.White;
            this.list_of_employees1.Location = new System.Drawing.Point(260, 278);
            this.list_of_employees1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_of_employees1.Name = "list_of_employees1";
            this.list_of_employees1.Size = new System.Drawing.Size(782, 562);
            this.list_of_employees1.TabIndex = 1;
            this.list_of_employees1.Visible = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 707);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btn_SalesList;
        private System.Windows.Forms.Button btn_OrderList;
        public System.Windows.Forms.Panel selectPanel;
        private EmpRegister empRegister1;
        private ユーザーコントロール.List_of_employees list_of_employees1;
        private ユーザーコントロール.OrderCheck orderCheck1;
        private SalesList salesList1;
        private System.Windows.Forms.Button btn_employees;
    }
}