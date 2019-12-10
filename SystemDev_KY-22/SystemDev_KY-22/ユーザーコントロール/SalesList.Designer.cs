namespace SystemDev_KY_22
{
    partial class SalesList
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
            this.dgv_saleslist = new System.Windows.Forms.DataGridView();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.lbl_orderdate = new System.Windows.Forms.Label();
            this.dtp_orderdate1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_orderdate2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_stretchingrod1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_stretchingrod2 = new System.Windows.Forms.Label();
            this.dtp_dateofshipment2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_dateofshipment1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_dateofshipment = new System.Windows.Forms.Label();
            this.txt_actualprice = new System.Windows.Forms.TextBox();
            this.lbl_actualprice = new System.Windows.Forms.Label();
            this.txt_listprice = new System.Windows.Forms.TextBox();
            this.lbl_listprice = new System.Windows.Forms.Label();
            this.txt_option = new System.Windows.Forms.TextBox();
            this.lbl_option = new System.Windows.Forms.Label();
            this.txt_employeeID = new System.Windows.Forms.TextBox();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.txt_clientID = new System.Windows.Forms.TextBox();
            this.lbl_clientID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_saleslist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_saleslist
            // 
            this.dgv_saleslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_saleslist.Location = new System.Drawing.Point(14, 168);
            this.dgv_saleslist.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_saleslist.Name = "dgv_saleslist";
            this.dgv_saleslist.RowTemplate.Height = 24;
            this.dgv_saleslist.Size = new System.Drawing.Size(1285, 581);
            this.dgv_saleslist.TabIndex = 1;
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_productname.Location = new System.Drawing.Point(29, 42);
            this.lbl_productname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(76, 22);
            this.lbl_productname.TabIndex = 28;
            this.lbl_productname.Text = "商品名";
            // 
            // txt_productname
            // 
            this.txt_productname.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txt_productname.Location = new System.Drawing.Point(123, 39);
            this.txt_productname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(159, 29);
            this.txt_productname.TabIndex = 29;
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_orderdate.Location = new System.Drawing.Point(593, 83);
            this.lbl_orderdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(76, 22);
            this.lbl_orderdate.TabIndex = 30;
            this.lbl_orderdate.Text = "注文日";
            // 
            // dtp_orderdate1
            // 
            this.dtp_orderdate1.Font = new System.Drawing.Font("メイリオ", 14.2F);
            this.dtp_orderdate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate1.Location = new System.Drawing.Point(687, 78);
            this.dtp_orderdate1.Name = "dtp_orderdate1";
            this.dtp_orderdate1.Size = new System.Drawing.Size(159, 36);
            this.dtp_orderdate1.TabIndex = 31;
            // 
            // dtp_orderdate2
            // 
            this.dtp_orderdate2.Font = new System.Drawing.Font("メイリオ", 14.2F);
            this.dtp_orderdate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate2.Location = new System.Drawing.Point(912, 78);
            this.dtp_orderdate2.Name = "dtp_orderdate2";
            this.dtp_orderdate2.Size = new System.Drawing.Size(159, 36);
            this.dtp_orderdate2.TabIndex = 32;
            // 
            // lbl_stretchingrod1
            // 
            this.lbl_stretchingrod1.AutoSize = true;
            this.lbl_stretchingrod1.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_stretchingrod1.Location = new System.Drawing.Point(865, 83);
            this.lbl_stretchingrod1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stretchingrod1.Name = "lbl_stretchingrod1";
            this.lbl_stretchingrod1.Size = new System.Drawing.Size(32, 22);
            this.lbl_stretchingrod1.TabIndex = 33;
            this.lbl_stretchingrod1.Text = "～";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_save.Location = new System.Drawing.Point(1113, 103);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(186, 54);
            this.btn_save.TabIndex = 34;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // lbl_stretchingrod2
            // 
            this.lbl_stretchingrod2.AutoSize = true;
            this.lbl_stretchingrod2.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_stretchingrod2.Location = new System.Drawing.Point(865, 127);
            this.lbl_stretchingrod2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stretchingrod2.Name = "lbl_stretchingrod2";
            this.lbl_stretchingrod2.Size = new System.Drawing.Size(32, 22);
            this.lbl_stretchingrod2.TabIndex = 38;
            this.lbl_stretchingrod2.Text = "～";
            // 
            // dtp_dateofshipment2
            // 
            this.dtp_dateofshipment2.Font = new System.Drawing.Font("メイリオ", 14.2F);
            this.dtp_dateofshipment2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateofshipment2.Location = new System.Drawing.Point(912, 121);
            this.dtp_dateofshipment2.Name = "dtp_dateofshipment2";
            this.dtp_dateofshipment2.Size = new System.Drawing.Size(159, 36);
            this.dtp_dateofshipment2.TabIndex = 37;
            // 
            // dtp_dateofshipment1
            // 
            this.dtp_dateofshipment1.Font = new System.Drawing.Font("メイリオ", 14.2F);
            this.dtp_dateofshipment1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dateofshipment1.Location = new System.Drawing.Point(687, 121);
            this.dtp_dateofshipment1.Name = "dtp_dateofshipment1";
            this.dtp_dateofshipment1.Size = new System.Drawing.Size(159, 36);
            this.dtp_dateofshipment1.TabIndex = 36;
            // 
            // lbl_dateofshipment
            // 
            this.lbl_dateofshipment.AutoSize = true;
            this.lbl_dateofshipment.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_dateofshipment.Location = new System.Drawing.Point(593, 127);
            this.lbl_dateofshipment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dateofshipment.Name = "lbl_dateofshipment";
            this.lbl_dateofshipment.Size = new System.Drawing.Size(76, 22);
            this.lbl_dateofshipment.TabIndex = 35;
            this.lbl_dateofshipment.Text = "発送日";
            // 
            // txt_actualprice
            // 
            this.txt_actualprice.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txt_actualprice.Location = new System.Drawing.Point(123, 124);
            this.txt_actualprice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_actualprice.Name = "txt_actualprice";
            this.txt_actualprice.Size = new System.Drawing.Size(159, 29);
            this.txt_actualprice.TabIndex = 40;
            // 
            // lbl_actualprice
            // 
            this.lbl_actualprice.AutoSize = true;
            this.lbl_actualprice.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_actualprice.Location = new System.Drawing.Point(29, 127);
            this.lbl_actualprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_actualprice.Name = "lbl_actualprice";
            this.lbl_actualprice.Size = new System.Drawing.Size(98, 22);
            this.lbl_actualprice.TabIndex = 39;
            this.lbl_actualprice.Text = "実売価格";
            // 
            // txt_listprice
            // 
            this.txt_listprice.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txt_listprice.Location = new System.Drawing.Point(123, 78);
            this.txt_listprice.Margin = new System.Windows.Forms.Padding(2);
            this.txt_listprice.Name = "txt_listprice";
            this.txt_listprice.Size = new System.Drawing.Size(159, 29);
            this.txt_listprice.TabIndex = 42;
            // 
            // lbl_listprice
            // 
            this.lbl_listprice.AutoSize = true;
            this.lbl_listprice.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_listprice.Location = new System.Drawing.Point(29, 81);
            this.lbl_listprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_listprice.Name = "lbl_listprice";
            this.lbl_listprice.Size = new System.Drawing.Size(54, 22);
            this.lbl_listprice.TabIndex = 41;
            this.lbl_listprice.Text = "定価";
            // 
            // txt_option
            // 
            this.txt_option.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txt_option.Location = new System.Drawing.Point(411, 124);
            this.txt_option.Margin = new System.Windows.Forms.Padding(2);
            this.txt_option.Name = "txt_option";
            this.txt_option.Size = new System.Drawing.Size(159, 29);
            this.txt_option.TabIndex = 44;
            // 
            // lbl_option
            // 
            this.lbl_option.AutoSize = true;
            this.lbl_option.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_option.Location = new System.Drawing.Point(317, 127);
            this.lbl_option.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_option.Name = "lbl_option";
            this.lbl_option.Size = new System.Drawing.Size(89, 22);
            this.lbl_option.TabIndex = 43;
            this.lbl_option.Text = "オプション";
            // 
            // txt_employeeID
            // 
            this.txt_employeeID.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txt_employeeID.Location = new System.Drawing.Point(411, 80);
            this.txt_employeeID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_employeeID.Name = "txt_employeeID";
            this.txt_employeeID.Size = new System.Drawing.Size(159, 29);
            this.txt_employeeID.TabIndex = 46;
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.AutoSize = true;
            this.lbl_employeeID.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_employeeID.Location = new System.Drawing.Point(317, 83);
            this.lbl_employeeID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(73, 22);
            this.lbl_employeeID.TabIndex = 45;
            this.lbl_employeeID.Text = "社員ID";
            // 
            // txt_clientID
            // 
            this.txt_clientID.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txt_clientID.Location = new System.Drawing.Point(411, 39);
            this.txt_clientID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_clientID.Name = "txt_clientID";
            this.txt_clientID.Size = new System.Drawing.Size(159, 29);
            this.txt_clientID.TabIndex = 48;
            // 
            // lbl_clientID
            // 
            this.lbl_clientID.AutoSize = true;
            this.lbl_clientID.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_clientID.Location = new System.Drawing.Point(317, 42);
            this.lbl_clientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_clientID.Name = "lbl_clientID";
            this.lbl_clientID.Size = new System.Drawing.Size(73, 22);
            this.lbl_clientID.TabIndex = 47;
            this.lbl_clientID.Text = "顧客ID";
            // 
            // SalesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_clientID);
            this.Controls.Add(this.lbl_clientID);
            this.Controls.Add(this.txt_employeeID);
            this.Controls.Add(this.lbl_employeeID);
            this.Controls.Add(this.txt_option);
            this.Controls.Add(this.lbl_option);
            this.Controls.Add(this.txt_listprice);
            this.Controls.Add(this.lbl_listprice);
            this.Controls.Add(this.txt_actualprice);
            this.Controls.Add(this.lbl_actualprice);
            this.Controls.Add(this.lbl_stretchingrod2);
            this.Controls.Add(this.dtp_dateofshipment2);
            this.Controls.Add(this.dtp_dateofshipment1);
            this.Controls.Add(this.lbl_dateofshipment);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_stretchingrod1);
            this.Controls.Add(this.dtp_orderdate2);
            this.Controls.Add(this.dtp_orderdate1);
            this.Controls.Add(this.lbl_orderdate);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.lbl_productname);
            this.Controls.Add(this.dgv_saleslist);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SalesList";
            this.Size = new System.Drawing.Size(1321, 883);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_saleslist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_saleslist;
        private System.Windows.Forms.DateTimePicker dtp_dateofshipment2;
        private System.Windows.Forms.Label lbl_stretchingrod2;
        private System.Windows.Forms.Label lbl_dateofshipment;
        private System.Windows.Forms.DateTimePicker dtp_dateofshipment1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label lbl_orderdate;
        private System.Windows.Forms.DateTimePicker dtp_orderdate1;
        private System.Windows.Forms.DateTimePicker dtp_orderdate2;
        private System.Windows.Forms.Label lbl_stretchingrod1;
        private System.Windows.Forms.TextBox txt_actualprice;
        private System.Windows.Forms.Label lbl_actualprice;
        private System.Windows.Forms.TextBox txt_listprice;
        private System.Windows.Forms.Label lbl_listprice;
        private System.Windows.Forms.TextBox txt_option;
        private System.Windows.Forms.Label lbl_option;
        private System.Windows.Forms.TextBox txt_employeeID;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.TextBox txt_clientID;
        private System.Windows.Forms.Label lbl_clientID;
    }
}
