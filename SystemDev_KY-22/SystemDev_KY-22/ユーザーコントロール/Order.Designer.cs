namespace SystemDev_KY_22
{
    partial class Order
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.btn_decision = new System.Windows.Forms.Button();
            this.gbx_vehicle = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.lbl_itemid = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cmb_manufacturer = new System.Windows.Forms.ComboBox();
            this.lbl_circle = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_consumptiontax = new System.Windows.Forms.TextBox();
            this.txt_amountofmoney = new System.Windows.Forms.TextBox();
            this.lbl_carname = new System.Windows.Forms.Label();
            this.lbl_manufacturer = new System.Windows.Forms.Label();
            this.lbl_bodycolor = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_amountofmoney = new System.Windows.Forms.Label();
            this.lbl_modelname = new System.Windows.Forms.Label();
            this.lbl_consumptiontax = new System.Windows.Forms.Label();
            this.gbx_order = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gbx_remarks = new System.Windows.Forms.GroupBox();
            this.rtb_remarks = new System.Windows.Forms.RichTextBox();
            this.txt_clientID = new System.Windows.Forms.TextBox();
            this.txt_employeeID = new System.Windows.Forms.TextBox();
            this.dtp_Orderdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_storeID = new System.Windows.Forms.Label();
            this.lbl_Orderdate = new System.Windows.Forms.Label();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.lbl_clientID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbx_vehicle.SuspendLayout();
            this.gbx_order.SuspendLayout();
            this.gbx_remarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_decision
            // 
            resources.ApplyResources(this.btn_decision, "btn_decision");
            this.btn_decision.Name = "btn_decision";
            this.btn_decision.UseVisualStyleBackColor = true;
            this.btn_decision.Click += new System.EventHandler(this.btn_decision_Click);
            // 
            // gbx_vehicle
            // 
            this.gbx_vehicle.Controls.Add(this.button2);
            this.gbx_vehicle.Controls.Add(this.txt_itemid);
            this.gbx_vehicle.Controls.Add(this.lbl_itemid);
            this.gbx_vehicle.Controls.Add(this.txt_total);
            this.gbx_vehicle.Controls.Add(this.textBox2);
            this.gbx_vehicle.Controls.Add(this.textBox1);
            this.gbx_vehicle.Controls.Add(this.comboBox3);
            this.gbx_vehicle.Controls.Add(this.comboBox2);
            this.gbx_vehicle.Controls.Add(this.cmb_manufacturer);
            this.gbx_vehicle.Controls.Add(this.lbl_circle);
            this.gbx_vehicle.Controls.Add(this.lbl_total);
            this.gbx_vehicle.Controls.Add(this.txt_consumptiontax);
            this.gbx_vehicle.Controls.Add(this.txt_amountofmoney);
            this.gbx_vehicle.Controls.Add(this.lbl_carname);
            this.gbx_vehicle.Controls.Add(this.lbl_manufacturer);
            this.gbx_vehicle.Controls.Add(this.lbl_bodycolor);
            this.gbx_vehicle.Controls.Add(this.lbl_status);
            this.gbx_vehicle.Controls.Add(this.lbl_amountofmoney);
            this.gbx_vehicle.Controls.Add(this.lbl_modelname);
            this.gbx_vehicle.Controls.Add(this.lbl_consumptiontax);
            resources.ApplyResources(this.gbx_vehicle, "gbx_vehicle");
            this.gbx_vehicle.Name = "gbx_vehicle";
            this.gbx_vehicle.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_itemid
            // 
            resources.ApplyResources(this.txt_itemid, "txt_itemid");
            this.txt_itemid.Name = "txt_itemid";
            // 
            // lbl_itemid
            // 
            resources.ApplyResources(this.lbl_itemid, "lbl_itemid");
            this.lbl_itemid.Name = "lbl_itemid";
            // 
            // txt_total
            // 
            resources.ApplyResources(this.txt_total, "txt_total");
            this.txt_total.Name = "txt_total";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            resources.GetString("comboBox3.Items"),
            resources.GetString("comboBox3.Items1"),
            resources.GetString("comboBox3.Items2"),
            resources.GetString("comboBox3.Items3"),
            resources.GetString("comboBox3.Items4")});
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            // 
            // cmb_manufacturer
            // 
            this.cmb_manufacturer.DisplayMember = "a";
            this.cmb_manufacturer.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_manufacturer, "cmb_manufacturer");
            this.cmb_manufacturer.Name = "cmb_manufacturer";
            // 
            // lbl_circle
            // 
            resources.ApplyResources(this.lbl_circle, "lbl_circle");
            this.lbl_circle.Name = "lbl_circle";
            // 
            // lbl_total
            // 
            resources.ApplyResources(this.lbl_total, "lbl_total");
            this.lbl_total.Name = "lbl_total";
            // 
            // txt_consumptiontax
            // 
            resources.ApplyResources(this.txt_consumptiontax, "txt_consumptiontax");
            this.txt_consumptiontax.Name = "txt_consumptiontax";
            // 
            // txt_amountofmoney
            // 
            resources.ApplyResources(this.txt_amountofmoney, "txt_amountofmoney");
            this.txt_amountofmoney.Name = "txt_amountofmoney";
            this.txt_amountofmoney.TextChanged += new System.EventHandler(this.txt_amountofmoney_TextChanged_1);
            // 
            // lbl_carname
            // 
            resources.ApplyResources(this.lbl_carname, "lbl_carname");
            this.lbl_carname.Name = "lbl_carname";
            // 
            // lbl_manufacturer
            // 
            resources.ApplyResources(this.lbl_manufacturer, "lbl_manufacturer");
            this.lbl_manufacturer.Name = "lbl_manufacturer";
            // 
            // lbl_bodycolor
            // 
            resources.ApplyResources(this.lbl_bodycolor, "lbl_bodycolor");
            this.lbl_bodycolor.Name = "lbl_bodycolor";
            // 
            // lbl_status
            // 
            resources.ApplyResources(this.lbl_status, "lbl_status");
            this.lbl_status.Name = "lbl_status";
            // 
            // lbl_amountofmoney
            // 
            resources.ApplyResources(this.lbl_amountofmoney, "lbl_amountofmoney");
            this.lbl_amountofmoney.Name = "lbl_amountofmoney";
            // 
            // lbl_modelname
            // 
            resources.ApplyResources(this.lbl_modelname, "lbl_modelname");
            this.lbl_modelname.Name = "lbl_modelname";
            // 
            // lbl_consumptiontax
            // 
            resources.ApplyResources(this.lbl_consumptiontax, "lbl_consumptiontax");
            this.lbl_consumptiontax.Name = "lbl_consumptiontax";
            // 
            // gbx_order
            // 
            this.gbx_order.Controls.Add(this.textBox4);
            this.gbx_order.Controls.Add(this.label1);
            this.gbx_order.Controls.Add(this.textBox3);
            this.gbx_order.Controls.Add(this.comboBox1);
            this.gbx_order.Controls.Add(this.gbx_remarks);
            this.gbx_order.Controls.Add(this.txt_clientID);
            this.gbx_order.Controls.Add(this.txt_employeeID);
            this.gbx_order.Controls.Add(this.dtp_Orderdate);
            this.gbx_order.Controls.Add(this.lbl_storeID);
            this.gbx_order.Controls.Add(this.lbl_Orderdate);
            this.gbx_order.Controls.Add(this.lbl_employeeID);
            this.gbx_order.Controls.Add(this.lbl_clientID);
            resources.ApplyResources(this.gbx_order, "gbx_order");
            this.gbx_order.Name = "gbx_order";
            this.gbx_order.TabStop = false;
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // gbx_remarks
            // 
            this.gbx_remarks.Controls.Add(this.rtb_remarks);
            resources.ApplyResources(this.gbx_remarks, "gbx_remarks");
            this.gbx_remarks.Name = "gbx_remarks";
            this.gbx_remarks.TabStop = false;
            // 
            // rtb_remarks
            // 
            resources.ApplyResources(this.rtb_remarks, "rtb_remarks");
            this.rtb_remarks.Name = "rtb_remarks";
            // 
            // txt_clientID
            // 
            resources.ApplyResources(this.txt_clientID, "txt_clientID");
            this.txt_clientID.Name = "txt_clientID";
            // 
            // txt_employeeID
            // 
            resources.ApplyResources(this.txt_employeeID, "txt_employeeID");
            this.txt_employeeID.Name = "txt_employeeID";
            // 
            // dtp_Orderdate
            // 
            this.dtp_Orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtp_Orderdate, "dtp_Orderdate");
            this.dtp_Orderdate.Name = "dtp_Orderdate";
            // 
            // lbl_storeID
            // 
            resources.ApplyResources(this.lbl_storeID, "lbl_storeID");
            this.lbl_storeID.Name = "lbl_storeID";
            // 
            // lbl_Orderdate
            // 
            resources.ApplyResources(this.lbl_Orderdate, "lbl_Orderdate");
            this.lbl_Orderdate.Name = "lbl_Orderdate";
            // 
            // lbl_employeeID
            // 
            resources.ApplyResources(this.lbl_employeeID, "lbl_employeeID");
            this.lbl_employeeID.Name = "lbl_employeeID";
            // 
            // lbl_clientID
            // 
            resources.ApplyResources(this.lbl_clientID, "lbl_clientID");
            this.lbl_clientID.Name = "lbl_clientID";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_decision);
            this.Controls.Add(this.gbx_vehicle);
            this.Controls.Add(this.gbx_order);
            this.Name = "Order";
            resources.ApplyResources(this, "$this");
            this.Load += new System.EventHandler(this.Order_Load);
            this.gbx_vehicle.ResumeLayout(false);
            this.gbx_vehicle.PerformLayout();
            this.gbx_order.ResumeLayout(false);
            this.gbx_order.PerformLayout();
            this.gbx_remarks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_decision;
        private System.Windows.Forms.GroupBox gbx_vehicle;
        private System.Windows.Forms.Label lbl_circle;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_consumptiontax;
        private System.Windows.Forms.TextBox txt_amountofmoney;
        private System.Windows.Forms.Label lbl_carname;
        private System.Windows.Forms.Label lbl_manufacturer;
        private System.Windows.Forms.Label lbl_bodycolor;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_amountofmoney;
        private System.Windows.Forms.Label lbl_modelname;
        private System.Windows.Forms.Label lbl_consumptiontax;
        private System.Windows.Forms.GroupBox gbx_order;
        private System.Windows.Forms.GroupBox gbx_remarks;
        private System.Windows.Forms.RichTextBox rtb_remarks;
        private System.Windows.Forms.TextBox txt_clientID;
        private System.Windows.Forms.TextBox txt_employeeID;
        private System.Windows.Forms.DateTimePicker dtp_Orderdate;
        private System.Windows.Forms.Label lbl_storeID;
        private System.Windows.Forms.Label lbl_Orderdate;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.Label lbl_clientID;
        private System.Windows.Forms.ComboBox cmb_manufacturer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_itemid;
        private System.Windows.Forms.Label lbl_itemid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
    }
}
