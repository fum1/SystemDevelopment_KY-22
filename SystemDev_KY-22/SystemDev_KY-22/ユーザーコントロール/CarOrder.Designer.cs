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
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.dtp_admissionday = new System.Windows.Forms.DateTimePicker();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_option = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_option = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btn_preview = new System.Windows.Forms.Button();
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.txt_PersonID = new System.Windows.Forms.TextBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.txt_supplierID = new System.Windows.Forms.TextBox();
            this.txt_suppliername = new System.Windows.Forms.TextBox();
            this.txt_suppliertel = new System.Windows.Forms.TextBox();
            this.lbl_suppliertel = new System.Windows.Forms.Label();
            this.lbl_txt_suppliername = new System.Windows.Forms.Label();
            this.btn_Suppliersearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_supplierID
            // 
            this.lbl_supplierID.AutoSize = true;
            this.lbl_supplierID.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_supplierID.Location = new System.Drawing.Point(42, 83);
            this.lbl_supplierID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_supplierID.Name = "lbl_supplierID";
            this.lbl_supplierID.Size = new System.Drawing.Size(144, 45);
            this.lbl_supplierID.TabIndex = 0;
            this.lbl_supplierID.Text = "仕入先ID";
            // 
            // lbl_PersonID
            // 
            this.lbl_PersonID.AutoSize = true;
            this.lbl_PersonID.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_PersonID.Location = new System.Drawing.Point(42, 237);
            this.lbl_PersonID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_PersonID.Name = "lbl_PersonID";
            this.lbl_PersonID.Size = new System.Drawing.Size(114, 45);
            this.lbl_PersonID.TabIndex = 12;
            this.lbl_PersonID.Text = "社員ID";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_orderdate.Location = new System.Drawing.Point(42, 291);
            this.lbl_orderdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(170, 45);
            this.lbl_orderdate.TabIndex = 14;
            this.lbl_orderdate.Text = "発注年月日";
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_productname.Location = new System.Drawing.Point(42, 345);
            this.lbl_productname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(110, 45);
            this.lbl_productname.TabIndex = 18;
            this.lbl_productname.Text = "商品名";
            // 
            // txt_productname
            // 
            this.txt_productname.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_productname.Location = new System.Drawing.Point(291, 345);
            this.txt_productname.Margin = new System.Windows.Forms.Padding(5);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(233, 35);
            this.txt_productname.TabIndex = 19;
            // 
            // dtp_admissionday
            // 
            this.dtp_admissionday.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_admissionday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_admissionday.Location = new System.Drawing.Point(291, 291);
            this.dtp_admissionday.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_admissionday.Name = "dtp_admissionday";
            this.dtp_admissionday.Size = new System.Drawing.Size(233, 40);
            this.dtp_admissionday.TabIndex = 21;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(352, 567);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(172, 56);
            this.btn_clear.TabIndex = 25;
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
            this.btn_order.TabIndex = 26;
            this.btn_order.Text = "発注";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_color.Location = new System.Drawing.Point(42, 453);
            this.lbl_color.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(50, 45);
            this.lbl_color.TabIndex = 29;
            this.lbl_color.Text = "色";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_model.Location = new System.Drawing.Point(42, 399);
            this.lbl_model.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(110, 45);
            this.lbl_model.TabIndex = 33;
            this.lbl_model.Text = "モデル";
            // 
            // lbl_option
            // 
            this.lbl_option.AutoSize = true;
            this.lbl_option.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_option.Location = new System.Drawing.Point(42, 507);
            this.lbl_option.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_option.Name = "lbl_option";
            this.lbl_option.Size = new System.Drawing.Size(170, 45);
            this.lbl_option.TabIndex = 34;
            this.lbl_option.Text = "オプション";
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_model.Location = new System.Drawing.Point(291, 399);
            this.txt_model.Margin = new System.Windows.Forms.Padding(5);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(233, 35);
            this.txt_model.TabIndex = 35;
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_color.Location = new System.Drawing.Point(291, 453);
            this.txt_color.Margin = new System.Windows.Forms.Padding(5);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(233, 35);
            this.txt_color.TabIndex = 36;
            // 
            // txt_option
            // 
            this.txt_option.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_option.Location = new System.Drawing.Point(291, 507);
            this.txt_option.Margin = new System.Windows.Forms.Padding(5);
            this.txt_option.Name = "txt_option";
            this.txt_option.Size = new System.Drawing.Size(233, 35);
            this.txt_option.TabIndex = 37;
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
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_print.Location = new System.Drawing.Point(352, 629);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(172, 56);
            this.btn_print.TabIndex = 39;
            this.btn_print.Text = "印刷";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_preview.Location = new System.Drawing.Point(174, 629);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(172, 56);
            this.btn_preview.TabIndex = 41;
            this.btn_preview.Text = "プレビュー";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_orderID.Location = new System.Drawing.Point(42, 29);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(114, 45);
            this.lbl_orderID.TabIndex = 42;
            this.lbl_orderID.Text = "発注ID";
            // 
            // txt_orderID
            // 
            this.txt_orderID.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_orderID.Location = new System.Drawing.Point(291, 29);
            this.txt_orderID.Margin = new System.Windows.Forms.Padding(5);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(233, 35);
            this.txt_orderID.TabIndex = 43;
            // 
            // txt_PersonID
            // 
            this.txt_PersonID.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_PersonID.Location = new System.Drawing.Point(291, 237);
            this.txt_PersonID.Margin = new System.Windows.Forms.Padding(5);
            this.txt_PersonID.Name = "txt_PersonID";
            this.txt_PersonID.Size = new System.Drawing.Size(233, 35);
            this.txt_PersonID.TabIndex = 44;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // txt_supplierID
            // 
            this.txt_supplierID.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_supplierID.Location = new System.Drawing.Point(291, 83);
            this.txt_supplierID.Margin = new System.Windows.Forms.Padding(5);
            this.txt_supplierID.Name = "txt_supplierID";
            this.txt_supplierID.Size = new System.Drawing.Size(233, 35);
            this.txt_supplierID.TabIndex = 45;
            // 
            // txt_suppliername
            // 
            this.txt_suppliername.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_suppliername.Location = new System.Drawing.Point(291, 137);
            this.txt_suppliername.Margin = new System.Windows.Forms.Padding(5);
            this.txt_suppliername.Name = "txt_suppliername";
            this.txt_suppliername.ReadOnly = true;
            this.txt_suppliername.Size = new System.Drawing.Size(233, 35);
            this.txt_suppliername.TabIndex = 46;
            // 
            // txt_suppliertel
            // 
            this.txt_suppliertel.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_suppliertel.Location = new System.Drawing.Point(291, 187);
            this.txt_suppliertel.Margin = new System.Windows.Forms.Padding(5);
            this.txt_suppliertel.Name = "txt_suppliertel";
            this.txt_suppliertel.ReadOnly = true;
            this.txt_suppliertel.Size = new System.Drawing.Size(233, 35);
            this.txt_suppliertel.TabIndex = 47;
            // 
            // lbl_suppliertel
            // 
            this.lbl_suppliertel.AutoSize = true;
            this.lbl_suppliertel.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_suppliertel.Location = new System.Drawing.Point(101, 187);
            this.lbl_suppliertel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_suppliertel.Name = "lbl_suppliertel";
            this.lbl_suppliertel.Size = new System.Drawing.Size(180, 41);
            this.lbl_suppliertel.TabIndex = 48;
            this.lbl_suppliertel.Text = "（電話番号）";
            // 
            // lbl_txt_suppliername
            // 
            this.lbl_txt_suppliername.AutoSize = true;
            this.lbl_txt_suppliername.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_txt_suppliername.Location = new System.Drawing.Point(101, 137);
            this.lbl_txt_suppliername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_txt_suppliername.Name = "lbl_txt_suppliername";
            this.lbl_txt_suppliername.Size = new System.Drawing.Size(153, 41);
            this.lbl_txt_suppliername.TabIndex = 49;
            this.lbl_txt_suppliername.Text = "（会社名）";
            // 
            // btn_Suppliersearch
            // 
            this.btn_Suppliersearch.BackColor = System.Drawing.Color.White;
            this.btn_Suppliersearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Suppliersearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Suppliersearch.Location = new System.Drawing.Point(531, 83);
            this.btn_Suppliersearch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Suppliersearch.Name = "btn_Suppliersearch";
            this.btn_Suppliersearch.Size = new System.Drawing.Size(41, 36);
            this.btn_Suppliersearch.TabIndex = 50;
            this.btn_Suppliersearch.Text = "🔍";
            this.btn_Suppliersearch.UseVisualStyleBackColor = false;
            // 
            // CarOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_Suppliersearch);
            this.Controls.Add(this.lbl_txt_suppliername);
            this.Controls.Add(this.lbl_suppliertel);
            this.Controls.Add(this.txt_suppliertel);
            this.Controls.Add(this.txt_suppliername);
            this.Controls.Add(this.txt_supplierID);
            this.Controls.Add(this.txt_PersonID);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.lbl_orderID);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txt_option);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.lbl_option);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dtp_admissionday);
            this.Controls.Add(this.txt_productname);
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
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.DateTimePicker dtp_admissionday;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_option;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_option;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.TextBox txt_PersonID;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.TextBox txt_supplierID;
        private System.Windows.Forms.TextBox txt_suppliername;
        private System.Windows.Forms.TextBox txt_suppliertel;
        private System.Windows.Forms.Label lbl_suppliertel;
        private System.Windows.Forms.Label lbl_txt_suppliername;
        private System.Windows.Forms.Button btn_Suppliersearch;
    }
}
