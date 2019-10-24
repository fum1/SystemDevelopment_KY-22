namespace SystemDev_KY_22
{
    partial class SalesMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.btn_Order = new System.Windows.Forms.Button();
            this.btn_ClientRegister = new System.Windows.Forms.Button();
            this.btn_StockList = new System.Windows.Forms.Button();
            this.panel_Back = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.order1 = new SystemDev_KY_22.Order();
            this.clientRegisterU1 = new SystemDev_KY_22.ClientRegisterU();
            this.stockList1 = new SystemDev_KY_22.StockList();
            this.panel1.SuspendLayout();
            this.panel_Back.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.selectPanel);
            this.panel1.Controls.Add(this.btn_Order);
            this.panel1.Controls.Add(this.btn_ClientRegister);
            this.panel1.Controls.Add(this.btn_StockList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 810);
            this.panel1.TabIndex = 5;
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.Gray;
            this.selectPanel.Location = new System.Drawing.Point(213, 204);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(10, 89);
            this.selectPanel.TabIndex = 0;
            this.selectPanel.Visible = false;
            // 
            // btn_Order
            // 
            this.btn_Order.BackColor = System.Drawing.Color.Transparent;
            this.btn_Order.FlatAppearance.BorderSize = 0;
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order.ForeColor = System.Drawing.Color.Black;
            this.btn_Order.Image = ((System.Drawing.Image)(resources.GetObject("btn_Order.Image")));
            this.btn_Order.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Order.Location = new System.Drawing.Point(12, 518);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(201, 115);
            this.btn_Order.TabIndex = 3;
            this.btn_Order.Text = "注文";
            this.btn_Order.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Order.UseVisualStyleBackColor = false;
            this.btn_Order.Click += new System.EventHandler(this.Btn_Order_Click);
            // 
            // btn_ClientRegister
            // 
            this.btn_ClientRegister.BackColor = System.Drawing.Color.Transparent;
            this.btn_ClientRegister.FlatAppearance.BorderSize = 0;
            this.btn_ClientRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientRegister.ForeColor = System.Drawing.Color.Black;
            this.btn_ClientRegister.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClientRegister.Image")));
            this.btn_ClientRegister.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ClientRegister.Location = new System.Drawing.Point(12, 361);
            this.btn_ClientRegister.Name = "btn_ClientRegister";
            this.btn_ClientRegister.Size = new System.Drawing.Size(201, 115);
            this.btn_ClientRegister.TabIndex = 2;
            this.btn_ClientRegister.Text = "顧客登録";
            this.btn_ClientRegister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ClientRegister.UseVisualStyleBackColor = false;
            this.btn_ClientRegister.Click += new System.EventHandler(this.Btn_ClientRegister_Click);
            // 
            // btn_StockList
            // 
            this.btn_StockList.BackColor = System.Drawing.Color.Transparent;
            this.btn_StockList.FlatAppearance.BorderSize = 0;
            this.btn_StockList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StockList.ForeColor = System.Drawing.Color.Black;
            this.btn_StockList.Image = ((System.Drawing.Image)(resources.GetObject("btn_StockList.Image")));
            this.btn_StockList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_StockList.Location = new System.Drawing.Point(12, 204);
            this.btn_StockList.Name = "btn_StockList";
            this.btn_StockList.Size = new System.Drawing.Size(201, 115);
            this.btn_StockList.TabIndex = 1;
            this.btn_StockList.Text = "在庫一覧";
            this.btn_StockList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_StockList.UseVisualStyleBackColor = false;
            this.btn_StockList.Click += new System.EventHandler(this.Btn_StockList_Click);
            // 
            // panel_Back
            // 
            this.panel_Back.Controls.Add(this.order1);
            this.panel_Back.Controls.Add(this.clientRegisterU1);
            this.panel_Back.Controls.Add(this.stockList1);
            this.panel_Back.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Back.Location = new System.Drawing.Point(223, 107);
            this.panel_Back.Name = "panel_Back";
            this.panel_Back.Size = new System.Drawing.Size(1042, 703);
            this.panel_Back.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(223, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1042, 108);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "営業担当メニュー";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("ＭＳ 明朝", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(771, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 82);
            this.button4.TabIndex = 4;
            this.button4.Text = "ログアウト";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // order1
            // 
            this.order1.BackColor = System.Drawing.Color.White;
            this.order1.Location = new System.Drawing.Point(27, 84);
            this.order1.Margin = new System.Windows.Forms.Padding(24, 36, 24, 36);
            this.order1.Name = "order1";
            this.order1.Size = new System.Drawing.Size(4168, 3471);
            this.order1.TabIndex = 2;
            // 
            // clientRegisterU1
            // 
            this.clientRegisterU1.BackColor = System.Drawing.Color.White;
            this.clientRegisterU1.Location = new System.Drawing.Point(2372, 1131);
            this.clientRegisterU1.Margin = new System.Windows.Forms.Padding(24, 36, 24, 36);
            this.clientRegisterU1.Name = "clientRegisterU1";
            this.clientRegisterU1.Size = new System.Drawing.Size(4168, 3471);
            this.clientRegisterU1.TabIndex = 1;
            // 
            // stockList1
            // 
            this.stockList1.BackColor = System.Drawing.Color.White;
            this.stockList1.Location = new System.Drawing.Point(1384, 1229);
            this.stockList1.Margin = new System.Windows.Forms.Padding(24, 36, 24, 36);
            this.stockList1.Name = "stockList1";
            this.stockList1.Size = new System.Drawing.Size(4168, 3471);
            this.stockList1.TabIndex = 0;
            // 
            // SalesMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1265, 810);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_Back);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("ＭＳ 明朝", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesMenu";
            this.Text = "Salesmenu2";
            this.Load += new System.EventHandler(this.Salesmenu2_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Back.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StockList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Button btn_ClientRegister;
        private System.Windows.Forms.Panel panel_Back;
        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Order order1;
        private ClientRegisterU clientRegisterU1;
        private StockList stockList1;
    }
}