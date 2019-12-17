namespace SystemDev_KY_22
{
    partial class CarOrder
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
            this.lbl_supplierID = new System.Windows.Forms.Label();
            this.lbl_PersonID = new System.Windows.Forms.Label();
            this.lbl_orderdate = new System.Windows.Forms.Label();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.dtp_admissionday = new System.Windows.Forms.DateTimePicker();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.lbl_number = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.txt_PersonID = new System.Windows.Forms.TextBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.txt_supplierID = new System.Windows.Forms.TextBox();
            this.txt_companyname = new System.Windows.Forms.TextBox();
            this.txt_companytel = new System.Windows.Forms.TextBox();
            this.lbl_companytel = new System.Windows.Forms.Label();
            this.lbl_companyname = new System.Windows.Forms.Label();
            this.btn_Suppliersearch = new System.Windows.Forms.Button();
            this.txt_ItemId = new System.Windows.Forms.TextBox();
            this.lbl_ItemId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_supplierID
            // 
            this.lbl_supplierID.AutoSize = true;
            this.lbl_supplierID.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_supplierID.Location = new System.Drawing.Point(50, 44);
            this.lbl_supplierID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_supplierID.Name = "lbl_supplierID";
            this.lbl_supplierID.Size = new System.Drawing.Size(182, 57);
            this.lbl_supplierID.TabIndex = 10;
            this.lbl_supplierID.Text = "仕入先ID";
            // 
            // lbl_PersonID
            // 
            this.lbl_PersonID.AutoSize = true;
            this.lbl_PersonID.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_PersonID.Location = new System.Drawing.Point(42, 309);
            this.lbl_PersonID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_PersonID.Name = "lbl_PersonID";
            this.lbl_PersonID.Size = new System.Drawing.Size(144, 57);
            this.lbl_PersonID.TabIndex = 14;
            this.lbl_PersonID.Text = "社員ID";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_orderdate.Location = new System.Drawing.Point(42, 382);
            this.lbl_orderdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(215, 57);
            this.lbl_orderdate.TabIndex = 15;
            this.lbl_orderdate.Text = "発注年月日";
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_productname.Location = new System.Drawing.Point(42, 345);
            this.lbl_productname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(0, 57);
            this.lbl_productname.TabIndex = 17;
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_number.Location = new System.Drawing.Point(291, 455);
            this.txt_number.Margin = new System.Windows.Forms.Padding(5);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(233, 42);
            this.txt_number.TabIndex = 7;
            // 
            // dtp_admissionday
            // 
            this.dtp_admissionday.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_admissionday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_admissionday.Location = new System.Drawing.Point(291, 382);
            this.dtp_admissionday.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_admissionday.Name = "dtp_admissionday";
            this.dtp_admissionday.Size = new System.Drawing.Size(233, 48);
            this.dtp_admissionday.TabIndex = 6;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(352, 567);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(172, 56);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_order.Location = new System.Drawing.Point(174, 567);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(172, 56);
            this.btn_order.TabIndex = 8;
            this.btn_order.Text = "発注";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_number.Location = new System.Drawing.Point(42, 455);
            this.lbl_number.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(101, 57);
            this.lbl_number.TabIndex = 16;
            this.lbl_number.Text = "個数";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = global::SystemDev_KY_22.Properties.Resources.チェリー;
            this.pictureBox.Location = new System.Drawing.Point(644, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(567, 585);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 38;
            this.pictureBox.TabStop = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // txt_PersonID
            // 
            this.txt_PersonID.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_PersonID.Location = new System.Drawing.Point(291, 309);
            this.txt_PersonID.Margin = new System.Windows.Forms.Padding(5);
            this.txt_PersonID.Name = "txt_PersonID";
            this.txt_PersonID.Size = new System.Drawing.Size(233, 42);
            this.txt_PersonID.TabIndex = 5;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_supplierID.Location = new System.Drawing.Point(299, 46);
            this.txt_supplierID.Margin = new System.Windows.Forms.Padding(5);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.Size = new System.Drawing.Size(233, 42);
            this.txt_supplierID.TabIndex = 0;
            // 
            // txt_companyname
            // 
            this.txt_companyname.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_companyname.Location = new System.Drawing.Point(299, 117);
            this.txt_companyname.Margin = new System.Windows.Forms.Padding(5);
            this.txt_companyname.Name = "txt_companyname";
            this.txt_companyname.ReadOnly = true;
            this.txt_companyname.Size = new System.Drawing.Size(233, 42);
            this.txt_companyname.TabIndex = 2;
            // 
            // txt_companytel
            // 
            this.txt_companytel.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_companytel.Location = new System.Drawing.Point(299, 184);
            this.txt_companytel.Margin = new System.Windows.Forms.Padding(5);
            this.txt_companytel.Name = "txt_companytel";
            this.txt_companytel.ReadOnly = true;
            this.txt_companytel.Size = new System.Drawing.Size(233, 42);
            this.txt_companytel.TabIndex = 3;
            // 
            // lbl_companytel
            // 
            this.lbl_companytel.AutoSize = true;
            this.lbl_companytel.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_companytel.Location = new System.Drawing.Point(109, 184);
            this.lbl_companytel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_companytel.Name = "lbl_companytel";
            this.lbl_companytel.Size = new System.Drawing.Size(226, 51);
            this.lbl_companytel.TabIndex = 12;
            this.lbl_companytel.Text = "（電話番号）";
            // 
            // lbl_companyname
            // 
            this.lbl_companyname.AutoSize = true;
            this.lbl_companyname.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_companyname.Location = new System.Drawing.Point(109, 117);
            this.lbl_companyname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_companyname.Name = "lbl_companyname";
            this.lbl_companyname.Size = new System.Drawing.Size(192, 51);
            this.lbl_companyname.TabIndex = 11;
            this.lbl_companyname.Text = "（会社名）";
            // 
            // btn_Suppliersearch
            // 
            this.btn_Suppliersearch.BackColor = System.Drawing.Color.White;
            this.btn_Suppliersearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Suppliersearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Suppliersearch.Location = new System.Drawing.Point(539, 46);
            this.btn_Suppliersearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Suppliersearch.Name = "btn_Suppliersearch";
            this.btn_Suppliersearch.Size = new System.Drawing.Size(53, 42);
            this.btn_Suppliersearch.TabIndex = 1;
            this.btn_Suppliersearch.Text = "🔍";
            this.btn_Suppliersearch.UseVisualStyleBackColor = false;
            this.btn_Suppliersearch.Click += new System.EventHandler(this.btn_Suppliersearch_Click);
            // 
            // txt_ItemId
            // 
            this.txt_ItemId.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ItemId.Location = new System.Drawing.Point(291, 240);
            this.txt_ItemId.Margin = new System.Windows.Forms.Padding(5);
            this.txt_ItemId.Name = "txt_ItemId";
            this.txt_ItemId.Size = new System.Drawing.Size(233, 42);
            this.txt_ItemId.TabIndex = 4;
            // 
            // lbl_ItemId
            // 
            this.lbl_ItemId.AutoSize = true;
            this.lbl_ItemId.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ItemId.Location = new System.Drawing.Point(42, 240);
            this.lbl_ItemId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_ItemId.Name = "lbl_ItemId";
            this.lbl_ItemId.Size = new System.Drawing.Size(144, 57);
            this.lbl_ItemId.TabIndex = 13;
            this.lbl_ItemId.Text = "商品ID";
            // 
            // CarOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_ItemId);
            this.Controls.Add(this.lbl_ItemId);
            this.Controls.Add(this.btn_Suppliersearch);
            this.Controls.Add(this.lbl_companyname);
            this.Controls.Add(this.lbl_companytel);
            this.Controls.Add(this.txt_companytel);
            this.Controls.Add(this.txt_companyname);
            this.Controls.Add(this.txt_supplierID);
            this.Controls.Add(this.txt_PersonID);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lbl_number);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dtp_admissionday);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.lbl_productname);
            this.Controls.Add(this.lbl_orderdate);
            this.Controls.Add(this.lbl_PersonID);
            this.Controls.Add(this.lbl_supplierID);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CarOrder";
            this.Size = new System.Drawing.Size(1230, 735);
            this.Load += new System.EventHandler(this.CarOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_supplierID;
        private System.Windows.Forms.Label lbl_PersonID;
        private System.Windows.Forms.Label lbl_orderdate;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.DateTimePicker dtp_admissionday;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TextBox txt_PersonID;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.TextBox txt_supplierID;
        private System.Windows.Forms.TextBox txt_companyname;
        private System.Windows.Forms.TextBox txt_companytel;
        private System.Windows.Forms.Label lbl_companytel;
        private System.Windows.Forms.Label lbl_companyname;
        private System.Windows.Forms.Button btn_Suppliersearch;
        private System.Windows.Forms.TextBox txt_ItemId;
        private System.Windows.Forms.Label lbl_ItemId;
    }
}
