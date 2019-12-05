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
            this.btn_decision = new System.Windows.Forms.Button();
            this.gbx_vehicle = new System.Windows.Forms.GroupBox();
            this.cmb_manufacturer = new System.Windows.Forms.ComboBox();
            this.lbl_circle = new System.Windows.Forms.Label();
            this.rtb_total = new System.Windows.Forms.RichTextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.txt_consumptiontax = new System.Windows.Forms.TextBox();
            this.txt_amountofmoney = new System.Windows.Forms.TextBox();
            this.lst_status = new System.Windows.Forms.ListBox();
            this.lst_bodycolor = new System.Windows.Forms.ListBox();
            this.lst_carname = new System.Windows.Forms.ListBox();
            this.lbl_carname = new System.Windows.Forms.Label();
            this.lst_modelname = new System.Windows.Forms.ListBox();
            this.lbl_manufacturer = new System.Windows.Forms.Label();
            this.lbl_bodycolor = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_amountofmoney = new System.Windows.Forms.Label();
            this.lbl_modelname = new System.Windows.Forms.Label();
            this.lbl_consumptiontax = new System.Windows.Forms.Label();
            this.gbx_order = new System.Windows.Forms.GroupBox();
            this.gbx_remarks = new System.Windows.Forms.GroupBox();
            this.rtb_remarks = new System.Windows.Forms.RichTextBox();
            this.txt_clientID = new System.Windows.Forms.TextBox();
            this.txt_employeeID = new System.Windows.Forms.TextBox();
            this.txt_storeID = new System.Windows.Forms.TextBox();
            this.dtp_Orderdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_storeID = new System.Windows.Forms.Label();
            this.lbl_Orderdate = new System.Windows.Forms.Label();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.lbl_clientID = new System.Windows.Forms.Label();
            this.gbx_vehicle.SuspendLayout();
            this.gbx_order.SuspendLayout();
            this.gbx_remarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_decision
            // 
            this.btn_decision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decision.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_decision.Location = new System.Drawing.Point(856, 616);
            this.btn_decision.Margin = new System.Windows.Forms.Padding(4);
            this.btn_decision.Name = "btn_decision";
            this.btn_decision.Size = new System.Drawing.Size(235, 60);
            this.btn_decision.TabIndex = 21;
            this.btn_decision.Text = "決定";
            this.btn_decision.UseVisualStyleBackColor = true;
            // 
            // gbx_vehicle
            // 
            this.gbx_vehicle.Controls.Add(this.cmb_manufacturer);
            this.gbx_vehicle.Controls.Add(this.lbl_circle);
            this.gbx_vehicle.Controls.Add(this.rtb_total);
            this.gbx_vehicle.Controls.Add(this.lbl_total);
            this.gbx_vehicle.Controls.Add(this.txt_consumptiontax);
            this.gbx_vehicle.Controls.Add(this.txt_amountofmoney);
            this.gbx_vehicle.Controls.Add(this.lst_status);
            this.gbx_vehicle.Controls.Add(this.lst_bodycolor);
            this.gbx_vehicle.Controls.Add(this.lst_carname);
            this.gbx_vehicle.Controls.Add(this.lbl_carname);
            this.gbx_vehicle.Controls.Add(this.lst_modelname);
            this.gbx_vehicle.Controls.Add(this.lbl_manufacturer);
            this.gbx_vehicle.Controls.Add(this.lbl_bodycolor);
            this.gbx_vehicle.Controls.Add(this.lbl_status);
            this.gbx_vehicle.Controls.Add(this.lbl_amountofmoney);
            this.gbx_vehicle.Controls.Add(this.lbl_modelname);
            this.gbx_vehicle.Controls.Add(this.lbl_consumptiontax);
            this.gbx_vehicle.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbx_vehicle.Location = new System.Drawing.Point(662, 0);
            this.gbx_vehicle.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_vehicle.Name = "gbx_vehicle";
            this.gbx_vehicle.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_vehicle.Size = new System.Drawing.Size(642, 602);
            this.gbx_vehicle.TabIndex = 20;
            this.gbx_vehicle.TabStop = false;
            this.gbx_vehicle.Text = "車両";
            // 
            // cmb_manufacturer
            // 
            this.cmb_manufacturer.FormattingEnabled = true;
            this.cmb_manufacturer.Location = new System.Drawing.Point(189, 58);
            this.cmb_manufacturer.Name = "cmb_manufacturer";
            this.cmb_manufacturer.Size = new System.Drawing.Size(240, 30);
            this.cmb_manufacturer.TabIndex = 26;
            // 
            // lbl_circle
            // 
            this.lbl_circle.AutoSize = true;
            this.lbl_circle.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_circle.Location = new System.Drawing.Point(438, 520);
            this.lbl_circle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_circle.Name = "lbl_circle";
            this.lbl_circle.Size = new System.Drawing.Size(32, 22);
            this.lbl_circle.TabIndex = 18;
            this.lbl_circle.Text = "円";
            // 
            // rtb_total
            // 
            this.rtb_total.Location = new System.Drawing.Point(194, 490);
            this.rtb_total.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_total.Name = "rtb_total";
            this.rtb_total.Size = new System.Drawing.Size(235, 76);
            this.rtb_total.TabIndex = 25;
            this.rtb_total.Text = "";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_total.Location = new System.Drawing.Point(37, 501);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(103, 35);
            this.lbl_total.TabIndex = 24;
            this.lbl_total.Text = "合計：";
            // 
            // txt_consumptiontax
            // 
            this.txt_consumptiontax.Location = new System.Drawing.Point(194, 343);
            this.txt_consumptiontax.Margin = new System.Windows.Forms.Padding(4);
            this.txt_consumptiontax.Name = "txt_consumptiontax";
            this.txt_consumptiontax.Size = new System.Drawing.Size(236, 29);
            this.txt_consumptiontax.TabIndex = 23;
            // 
            // txt_amountofmoney
            // 
            this.txt_amountofmoney.Location = new System.Drawing.Point(195, 290);
            this.txt_amountofmoney.Margin = new System.Windows.Forms.Padding(4);
            this.txt_amountofmoney.Name = "txt_amountofmoney";
            this.txt_amountofmoney.Size = new System.Drawing.Size(235, 29);
            this.txt_amountofmoney.TabIndex = 22;
            // 
            // lst_status
            // 
            this.lst_status.FormattingEnabled = true;
            this.lst_status.ItemHeight = 22;
            this.lst_status.Location = new System.Drawing.Point(194, 239);
            this.lst_status.Margin = new System.Windows.Forms.Padding(4);
            this.lst_status.Name = "lst_status";
            this.lst_status.Size = new System.Drawing.Size(236, 26);
            this.lst_status.TabIndex = 21;
            // 
            // lst_bodycolor
            // 
            this.lst_bodycolor.FormattingEnabled = true;
            this.lst_bodycolor.ItemHeight = 22;
            this.lst_bodycolor.Location = new System.Drawing.Point(194, 193);
            this.lst_bodycolor.Margin = new System.Windows.Forms.Padding(4);
            this.lst_bodycolor.Name = "lst_bodycolor";
            this.lst_bodycolor.Size = new System.Drawing.Size(240, 26);
            this.lst_bodycolor.TabIndex = 20;
            // 
            // lst_carname
            // 
            this.lst_carname.FormattingEnabled = true;
            this.lst_carname.ItemHeight = 22;
            this.lst_carname.Location = new System.Drawing.Point(195, 149);
            this.lst_carname.Margin = new System.Windows.Forms.Padding(4);
            this.lst_carname.Name = "lst_carname";
            this.lst_carname.Size = new System.Drawing.Size(239, 26);
            this.lst_carname.TabIndex = 19;
            // 
            // lbl_carname
            // 
            this.lbl_carname.AutoSize = true;
            this.lbl_carname.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_carname.Location = new System.Drawing.Point(100, 155);
            this.lbl_carname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_carname.Name = "lbl_carname";
            this.lbl_carname.Size = new System.Drawing.Size(48, 16);
            this.lbl_carname.TabIndex = 18;
            this.lbl_carname.Text = "車名：";
            // 
            // lst_modelname
            // 
            this.lst_modelname.FormattingEnabled = true;
            this.lst_modelname.ItemHeight = 22;
            this.lst_modelname.Location = new System.Drawing.Point(194, 102);
            this.lst_modelname.Margin = new System.Windows.Forms.Padding(4);
            this.lst_modelname.Name = "lst_modelname";
            this.lst_modelname.Size = new System.Drawing.Size(240, 26);
            this.lst_modelname.TabIndex = 17;
            // 
            // lbl_manufacturer
            // 
            this.lbl_manufacturer.AutoSize = true;
            this.lbl_manufacturer.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_manufacturer.Location = new System.Drawing.Point(75, 67);
            this.lbl_manufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_manufacturer.Name = "lbl_manufacturer";
            this.lbl_manufacturer.Size = new System.Drawing.Size(64, 16);
            this.lbl_manufacturer.TabIndex = 13;
            this.lbl_manufacturer.Text = "メーカー：";
            // 
            // lbl_bodycolor
            // 
            this.lbl_bodycolor.AutoSize = true;
            this.lbl_bodycolor.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_bodycolor.Location = new System.Drawing.Point(20, 205);
            this.lbl_bodycolor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bodycolor.Name = "lbl_bodycolor";
            this.lbl_bodycolor.Size = new System.Drawing.Size(99, 16);
            this.lbl_bodycolor.TabIndex = 7;
            this.lbl_bodycolor.Text = "ボディーカラー：";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_status.Location = new System.Drawing.Point(100, 252);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(48, 16);
            this.lbl_status.TabIndex = 15;
            this.lbl_status.Text = "状態：";
            // 
            // lbl_amountofmoney
            // 
            this.lbl_amountofmoney.AutoSize = true;
            this.lbl_amountofmoney.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_amountofmoney.Location = new System.Drawing.Point(100, 301);
            this.lbl_amountofmoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_amountofmoney.Name = "lbl_amountofmoney";
            this.lbl_amountofmoney.Size = new System.Drawing.Size(48, 16);
            this.lbl_amountofmoney.TabIndex = 10;
            this.lbl_amountofmoney.Text = "金額：";
            // 
            // lbl_modelname
            // 
            this.lbl_modelname.AutoSize = true;
            this.lbl_modelname.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_modelname.Location = new System.Drawing.Point(75, 115);
            this.lbl_modelname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_modelname.Name = "lbl_modelname";
            this.lbl_modelname.Size = new System.Drawing.Size(64, 16);
            this.lbl_modelname.TabIndex = 14;
            this.lbl_modelname.Text = "車種名：";
            // 
            // lbl_consumptiontax
            // 
            this.lbl_consumptiontax.AutoSize = true;
            this.lbl_consumptiontax.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_consumptiontax.Location = new System.Drawing.Point(75, 431);
            this.lbl_consumptiontax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_consumptiontax.Name = "lbl_consumptiontax";
            this.lbl_consumptiontax.Size = new System.Drawing.Size(64, 16);
            this.lbl_consumptiontax.TabIndex = 12;
            this.lbl_consumptiontax.Text = "消費税：";
            // 
            // gbx_order
            // 
            this.gbx_order.Controls.Add(this.gbx_remarks);
            this.gbx_order.Controls.Add(this.txt_clientID);
            this.gbx_order.Controls.Add(this.txt_employeeID);
            this.gbx_order.Controls.Add(this.txt_storeID);
            this.gbx_order.Controls.Add(this.dtp_Orderdate);
            this.gbx_order.Controls.Add(this.lbl_storeID);
            this.gbx_order.Controls.Add(this.lbl_Orderdate);
            this.gbx_order.Controls.Add(this.lbl_employeeID);
            this.gbx_order.Controls.Add(this.lbl_clientID);
            this.gbx_order.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbx_order.Location = new System.Drawing.Point(11, 0);
            this.gbx_order.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_order.Name = "gbx_order";
            this.gbx_order.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_order.Size = new System.Drawing.Size(643, 699);
            this.gbx_order.TabIndex = 19;
            this.gbx_order.TabStop = false;
            this.gbx_order.Text = "注文";
            // 
            // gbx_remarks
            // 
            this.gbx_remarks.Controls.Add(this.rtb_remarks);
            this.gbx_remarks.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbx_remarks.Location = new System.Drawing.Point(8, 371);
            this.gbx_remarks.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_remarks.Name = "gbx_remarks";
            this.gbx_remarks.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_remarks.Size = new System.Drawing.Size(496, 305);
            this.gbx_remarks.TabIndex = 13;
            this.gbx_remarks.TabStop = false;
            this.gbx_remarks.Text = "備考";
            // 
            // rtb_remarks
            // 
            this.rtb_remarks.Location = new System.Drawing.Point(8, 32);
            this.rtb_remarks.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_remarks.Name = "rtb_remarks";
            this.rtb_remarks.Size = new System.Drawing.Size(480, 265);
            this.rtb_remarks.TabIndex = 0;
            this.rtb_remarks.Text = "";
            // 
            // txt_clientID
            // 
            this.txt_clientID.Location = new System.Drawing.Point(149, 289);
            this.txt_clientID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_clientID.Name = "txt_clientID";
            this.txt_clientID.Size = new System.Drawing.Size(318, 29);
            this.txt_clientID.TabIndex = 12;
            // 
            // txt_employeeID
            // 
            this.txt_employeeID.Location = new System.Drawing.Point(148, 225);
            this.txt_employeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_employeeID.Name = "txt_employeeID";
            this.txt_employeeID.Size = new System.Drawing.Size(316, 29);
            this.txt_employeeID.TabIndex = 11;
            // 
            // txt_storeID
            // 
            this.txt_storeID.Location = new System.Drawing.Point(149, 161);
            this.txt_storeID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_storeID.Name = "txt_storeID";
            this.txt_storeID.Size = new System.Drawing.Size(316, 29);
            this.txt_storeID.TabIndex = 10;
            // 
            // dtp_Orderdate
            // 
            this.dtp_Orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Orderdate.Location = new System.Drawing.Point(149, 102);
            this.dtp_Orderdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Orderdate.Name = "dtp_Orderdate";
            this.dtp_Orderdate.Size = new System.Drawing.Size(315, 29);
            this.dtp_Orderdate.TabIndex = 9;
            // 
            // lbl_storeID
            // 
            this.lbl_storeID.AutoSize = true;
            this.lbl_storeID.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_storeID.Location = new System.Drawing.Point(32, 171);
            this.lbl_storeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_storeID.Name = "lbl_storeID";
            this.lbl_storeID.Size = new System.Drawing.Size(62, 16);
            this.lbl_storeID.TabIndex = 5;
            this.lbl_storeID.Text = "店舗ID：";
            // 
            // lbl_Orderdate
            // 
            this.lbl_Orderdate.AutoSize = true;
            this.lbl_Orderdate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Orderdate.Location = new System.Drawing.Point(30, 107);
            this.lbl_Orderdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Orderdate.Name = "lbl_Orderdate";
            this.lbl_Orderdate.Size = new System.Drawing.Size(64, 16);
            this.lbl_Orderdate.TabIndex = 3;
            this.lbl_Orderdate.Text = "受注日：";
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.AutoSize = true;
            this.lbl_employeeID.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_employeeID.Location = new System.Drawing.Point(32, 235);
            this.lbl_employeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(62, 16);
            this.lbl_employeeID.TabIndex = 8;
            this.lbl_employeeID.Text = "社員ID：";
            // 
            // lbl_clientID
            // 
            this.lbl_clientID.AutoSize = true;
            this.lbl_clientID.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_clientID.Location = new System.Drawing.Point(32, 299);
            this.lbl_clientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_clientID.Name = "lbl_clientID";
            this.lbl_clientID.Size = new System.Drawing.Size(62, 16);
            this.lbl_clientID.TabIndex = 6;
            this.lbl_clientID.Text = "顧客ID：";
            // 
            // Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_decision);
            this.Controls.Add(this.gbx_vehicle);
            this.Controls.Add(this.gbx_order);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(1317, 703);
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
        private System.Windows.Forms.RichTextBox rtb_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.TextBox txt_consumptiontax;
        private System.Windows.Forms.TextBox txt_amountofmoney;
        private System.Windows.Forms.ListBox lst_status;
        private System.Windows.Forms.ListBox lst_bodycolor;
        private System.Windows.Forms.ListBox lst_carname;
        private System.Windows.Forms.Label lbl_carname;
        private System.Windows.Forms.ListBox lst_modelname;
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
        private System.Windows.Forms.TextBox txt_storeID;
        private System.Windows.Forms.DateTimePicker dtp_Orderdate;
        private System.Windows.Forms.Label lbl_storeID;
        private System.Windows.Forms.Label lbl_Orderdate;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.Label lbl_clientID;
        private System.Windows.Forms.ComboBox cmb_manufacturer;
    }
}
