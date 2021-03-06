﻿namespace SystemDev_KY_22
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lB_MainTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_storing = new System.Windows.Forms.Button();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.btn_StockList = new System.Windows.Forms.Button();
            this.btn_Item = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Item = new SystemDev_KY_22.ユーザーコントロール.Item();
            this.storing1 = new SystemDev_KY_22.ユーザーコントロール.Storing();
            this.stockList = new SystemDev_KY_22.StockList();
            this.loaUnloading = new SystemDev_KY_22.LoaUnloading();
            this.orderCheck = new SystemDev_KY_22.ユーザーコントロール.OrderCheck();
            this.carOrder = new SystemDev_KY_22.CarOrder();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lB_MainTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 108);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("ＭＳ 明朝", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1690, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 73);
            this.button4.TabIndex = 7;
            this.button4.Text = "ログアウト";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lB_MainTitle
            // 
            this.lB_MainTitle.AutoSize = true;
            this.lB_MainTitle.Font = new System.Drawing.Font("ＭＳ 明朝", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lB_MainTitle.Location = new System.Drawing.Point(34, 38);
            this.lB_MainTitle.Name = "lB_MainTitle";
            this.lB_MainTitle.Size = new System.Drawing.Size(412, 48);
            this.lB_MainTitle.TabIndex = 6;
            this.lB_MainTitle.Text = "物流担当メニュー";
            this.lB_MainTitle.Click += new System.EventHandler(this.lB_MainTitle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btn_storing);
            this.panel2.Controls.Add(this.selectPanel);
            this.panel2.Controls.Add(this.btn_StockList);
            this.panel2.Controls.Add(this.btn_Item);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 972);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 803);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 115);
            this.button1.TabIndex = 3;
            this.button1.Text = "発注";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(12, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 115);
            this.button3.TabIndex = 6;
            this.button3.Text = "入出庫一覧";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_storing
            // 
            this.btn_storing.BackColor = System.Drawing.Color.Transparent;
            this.btn_storing.FlatAppearance.BorderSize = 0;
            this.btn_storing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_storing.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_storing.ForeColor = System.Drawing.Color.Black;
            this.btn_storing.Image = ((System.Drawing.Image)(resources.GetObject("btn_storing.Image")));
            this.btn_storing.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_storing.Location = new System.Drawing.Point(6, 487);
            this.btn_storing.Name = "btn_storing";
            this.btn_storing.Size = new System.Drawing.Size(201, 115);
            this.btn_storing.TabIndex = 7;
            this.btn_storing.Text = "入庫登録";
            this.btn_storing.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_storing.UseVisualStyleBackColor = false;
            this.btn_storing.Click += new System.EventHandler(this.btn_storing_Click);
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.Gray;
            this.selectPanel.Location = new System.Drawing.Point(213, 57);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(10, 89);
            this.selectPanel.TabIndex = 5;
            this.selectPanel.Visible = false;
            // 
            // btn_StockList
            // 
            this.btn_StockList.BackColor = System.Drawing.Color.Transparent;
            this.btn_StockList.FlatAppearance.BorderSize = 0;
            this.btn_StockList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StockList.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_StockList.ForeColor = System.Drawing.Color.Black;
            this.btn_StockList.Image = ((System.Drawing.Image)(resources.GetObject("btn_StockList.Image")));
            this.btn_StockList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_StockList.Location = new System.Drawing.Point(6, 57);
            this.btn_StockList.Name = "btn_StockList";
            this.btn_StockList.Size = new System.Drawing.Size(201, 115);
            this.btn_StockList.TabIndex = 2;
            this.btn_StockList.Text = "在庫一覧";
            this.btn_StockList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_StockList.UseVisualStyleBackColor = false;
            this.btn_StockList.Click += new System.EventHandler(this.btn_StockList_Click);
            // 
            // btn_Item
            // 
            this.btn_Item.BackColor = System.Drawing.Color.Transparent;
            this.btn_Item.FlatAppearance.BorderSize = 0;
            this.btn_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Item.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Item.ForeColor = System.Drawing.Color.Black;
            this.btn_Item.Image = ((System.Drawing.Image)(resources.GetObject("btn_Item.Image")));
            this.btn_Item.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Item.Location = new System.Drawing.Point(23, 345);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(165, 113);
            this.btn_Item.TabIndex = 8;
            this.btn_Item.Text = "商品";
            this.btn_Item.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Item.UseVisualStyleBackColor = false;
            this.btn_Item.Click += new System.EventHandler(this.btn_Item_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(6, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 115);
            this.button2.TabIndex = 4;
            this.button2.Text = "受注";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Item);
            this.panel3.Controls.Add(this.storing1);
            this.panel3.Controls.Add(this.stockList);
            this.panel3.Controls.Add(this.loaUnloading);
            this.panel3.Controls.Add(this.orderCheck);
            this.panel3.Controls.Add(this.carOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(223, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1697, 972);
            this.panel3.TabIndex = 8;
            // 
            // Item
            // 
            this.Item.BackColor = System.Drawing.Color.White;
            this.Item.Location = new System.Drawing.Point(6, 579);
            this.Item.Margin = new System.Windows.Forms.Padding(2);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(1273, 652);
            this.Item.TabIndex = 7;
            this.Item.Visible = false;
            // 
            // storing1
            // 
            this.storing1.BackColor = System.Drawing.Color.White;
            this.storing1.Location = new System.Drawing.Point(321, 394);
            this.storing1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.storing1.Name = "storing1";
            this.storing1.Size = new System.Drawing.Size(1747, 929);
            this.storing1.TabIndex = 6;
            this.storing1.Visible = false;
            // 
            // stockList
            // 
            this.stockList.BackColor = System.Drawing.Color.White;
            this.stockList.Location = new System.Drawing.Point(39, 513);
            this.stockList.Name = "stockList";
            this.stockList.Size = new System.Drawing.Size(1042, 703);
            this.stockList.TabIndex = 5;
            this.stockList.Visible = false;
            // 
            // loaUnloading
            // 
            this.loaUnloading.BackColor = System.Drawing.Color.White;
            this.loaUnloading.Location = new System.Drawing.Point(126, 403);
            this.loaUnloading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loaUnloading.Name = "loaUnloading";
            this.loaUnloading.Size = new System.Drawing.Size(1002, 592);
            this.loaUnloading.TabIndex = 3;
            this.loaUnloading.Visible = false;
            // 
            // orderCheck
            // 
            this.orderCheck.BackColor = System.Drawing.Color.White;
            this.orderCheck.Location = new System.Drawing.Point(628, 224);
            this.orderCheck.Margin = new System.Windows.Forms.Padding(5);
            this.orderCheck.Name = "orderCheck";
            this.orderCheck.Size = new System.Drawing.Size(1389, 879);
            this.orderCheck.TabIndex = 1;
            this.orderCheck.Visible = false;
            // 
            // carOrder
            // 
            this.carOrder.BackColor = System.Drawing.Color.White;
            this.carOrder.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.carOrder.Location = new System.Drawing.Point(39, 331);
            this.carOrder.Margin = new System.Windows.Forms.Padding(5);
            this.carOrder.Name = "carOrder";
            this.carOrder.Size = new System.Drawing.Size(1230, 735);
            this.carOrder.TabIndex = 0;
            this.carOrder.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu2";
            this.Load += new System.EventHandler(this.MainMenu2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lB_MainTitle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_StockList;
        private System.Windows.Forms.Panel selectPanel;
        private StockList stockList1;
        private ユーザーコントロール.OrderCheck orderCheck1;
        private CarOrder carOrder1;
        private System.Windows.Forms.Button button3;
        private LoaUnloading loaUnloading;
        private ユーザーコントロール.OrderCheck orderCheck;
        private CarOrder carOrder;
        private StockList stockList;
        private System.Windows.Forms.Button btn_storing;
        private ユーザーコントロール.Storing storing1;
        private System.Windows.Forms.Button btn_Item;
        private ユーザーコントロール.Item Item;
    }
}