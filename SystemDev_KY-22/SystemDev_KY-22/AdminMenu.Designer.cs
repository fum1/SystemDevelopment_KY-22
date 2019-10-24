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
            this.selectPanel = new System.Windows.Forms.Panel();
            this.btn_StockList = new System.Windows.Forms.Button();
            this.Btn_EmpRegister = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1265, 108);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("ＭＳ 明朝", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_logout.ForeColor = System.Drawing.Color.Black;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(983, 11);
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
            this.label1.Size = new System.Drawing.Size(375, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "管理者用メニュー";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.selectPanel);
            this.panel2.Controls.Add(this.btn_StockList);
            this.panel2.Controls.Add(this.Btn_EmpRegister);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 702);
            this.panel2.TabIndex = 1;
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
            // btn_StockList
            // 
            this.btn_StockList.BackColor = System.Drawing.Color.Transparent;
            this.btn_StockList.FlatAppearance.BorderSize = 0;
            this.btn_StockList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StockList.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_StockList.ForeColor = System.Drawing.Color.Black;
            this.btn_StockList.Image = ((System.Drawing.Image)(resources.GetObject("btn_StockList.Image")));
            this.btn_StockList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_StockList.Location = new System.Drawing.Point(20, 487);
            this.btn_StockList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_StockList.Name = "btn_StockList";
            this.btn_StockList.Size = new System.Drawing.Size(186, 128);
            this.btn_StockList.TabIndex = 2;
            this.btn_StockList.Text = "注文履歴";
            this.btn_StockList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_StockList.UseVisualStyleBackColor = false;
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
            this.Btn_EmpRegister.Location = new System.Drawing.Point(20, 278);
            this.Btn_EmpRegister.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_EmpRegister.Name = "Btn_EmpRegister";
            this.Btn_EmpRegister.Size = new System.Drawing.Size(186, 128);
            this.Btn_EmpRegister.TabIndex = 4;
            this.Btn_EmpRegister.Text = "社員登録";
            this.Btn_EmpRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_EmpRegister.UseVisualStyleBackColor = false;
            this.Btn_EmpRegister.Click += new System.EventHandler(this.Btn_EmpRegister_Click);
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
            this.button1.Location = new System.Drawing.Point(20, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 122);
            this.button1.TabIndex = 3;
            this.button1.Text = "売上確認";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(223, 108);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 702);
            this.panel3.TabIndex = 2;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 810);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMenu2_FormClosing);
            this.Load += new System.EventHandler(this.AdminMenu2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button Btn_EmpRegister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_StockList;
        private System.Windows.Forms.Panel selectPanel;
    }
}