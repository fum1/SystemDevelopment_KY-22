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
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.lbl_Person = new System.Windows.Forms.Label();
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.lbl_orderID = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.txt_Person = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_supplier.Location = new System.Drawing.Point(42, 81);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(182, 57);
            this.lbl_supplier.TabIndex = 0;
            this.lbl_supplier.Text = "仕入先ID";
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(291, 81);
            this.cmb_supplier.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(233, 42);
            this.cmb_supplier.TabIndex = 2;
            // 
            // lbl_Person
            // 
            this.lbl_Person.AutoSize = true;
            this.lbl_Person.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Person.Location = new System.Drawing.Point(42, 152);
            this.lbl_Person.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Person.Name = "lbl_Person";
            this.lbl_Person.Size = new System.Drawing.Size(144, 57);
            this.lbl_Person.TabIndex = 12;
            this.lbl_Person.Text = "社員ID";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_orderdate.Location = new System.Drawing.Point(42, 223);
            this.lbl_orderdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(215, 57);
            this.lbl_orderdate.TabIndex = 14;
            this.lbl_orderdate.Text = "発注年月日";
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_productname.Location = new System.Drawing.Point(42, 294);
            this.lbl_productname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(139, 57);
            this.lbl_productname.TabIndex = 18;
            this.lbl_productname.Text = "商品名";
            // 
            // txt_productname
            // 
            this.txt_productname.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_productname.Location = new System.Drawing.Point(291, 294);
            this.txt_productname.Margin = new System.Windows.Forms.Padding(5);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(233, 42);
            this.txt_productname.TabIndex = 19;
            // 
            // dtp_admissionday
            // 
            this.dtp_admissionday.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_admissionday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_admissionday.Location = new System.Drawing.Point(291, 223);
            this.dtp_admissionday.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_admissionday.Name = "dtp_admissionday";
            this.dtp_admissionday.Size = new System.Drawing.Size(233, 48);
            this.dtp_admissionday.TabIndex = 21;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(361, 567);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(150, 56);
            this.btn_clear.TabIndex = 25;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.Transparent;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_order.Location = new System.Drawing.Point(205, 567);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(150, 56);
            this.btn_order.TabIndex = 26;
            this.btn_order.Text = "発注";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_color.Location = new System.Drawing.Point(42, 436);
            this.lbl_color.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(63, 57);
            this.lbl_color.TabIndex = 29;
            this.lbl_color.Text = "色";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_model.Location = new System.Drawing.Point(42, 365);
            this.lbl_model.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(139, 57);
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
            this.lbl_option.Size = new System.Drawing.Size(215, 57);
            this.lbl_option.TabIndex = 34;
            this.lbl_option.Text = "オプション";
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_model.Location = new System.Drawing.Point(291, 365);
            this.txt_model.Margin = new System.Windows.Forms.Padding(5);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(233, 42);
            this.txt_model.TabIndex = 35;
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_color.Location = new System.Drawing.Point(291, 436);
            this.txt_color.Margin = new System.Windows.Forms.Padding(5);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(233, 42);
            this.txt_color.TabIndex = 36;
            // 
            // txt_option
            // 
            this.txt_option.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_option.Location = new System.Drawing.Point(291, 507);
            this.txt_option.Margin = new System.Windows.Forms.Padding(5);
            this.txt_option.Name = "txt_option";
            this.txt_option.Size = new System.Drawing.Size(233, 42);
            this.txt_option.TabIndex = 37;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = global::SystemDev_KY_22.Properties.Resources.チェリー;
            this.pictureBox.Location = new System.Drawing.Point(644, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(567, 608);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 38;
            this.pictureBox.TabStop = false;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_print.Location = new System.Drawing.Point(517, 629);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(150, 56);
            this.btn_print.TabIndex = 39;
            this.btn_print.Text = "印刷";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Check.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Check.Location = new System.Drawing.Point(205, 629);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(150, 56);
            this.btn_Check.TabIndex = 40;
            this.btn_Check.Text = "表示";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_preview.Location = new System.Drawing.Point(361, 629);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(150, 56);
            this.btn_preview.TabIndex = 41;
            this.btn_preview.Text = "プレ";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // lbl_orderID
            // 
            this.lbl_orderID.AutoSize = true;
            this.lbl_orderID.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_orderID.Location = new System.Drawing.Point(42, 15);
            this.lbl_orderID.Name = "lbl_orderID";
            this.lbl_orderID.Size = new System.Drawing.Size(144, 57);
            this.lbl_orderID.TabIndex = 42;
            this.lbl_orderID.Text = "発注ID";
            // 
            // txt_orderID
            // 
            this.txt_orderID.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_orderID.Location = new System.Drawing.Point(291, 15);
            this.txt_orderID.Margin = new System.Windows.Forms.Padding(5);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(233, 42);
            this.txt_orderID.TabIndex = 43;
            // 
            // txt_Person
            // 
            this.txt_Person.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Person.Location = new System.Drawing.Point(291, 152);
            this.txt_Person.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Person.Name = "txt_Person";
            this.txt_Person.Size = new System.Drawing.Size(233, 42);
            this.txt_Person.TabIndex = 44;
            // 
            // CarOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_Person);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.lbl_orderID);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.btn_Check);
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
            this.Controls.Add(this.lbl_Person);
            this.Controls.Add(this.cmb_supplier);
            this.Controls.Add(this.lbl_supplier);
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

        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.ComboBox cmb_supplier;
        private System.Windows.Forms.Label lbl_Person;
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label lbl_orderID;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.TextBox txt_Person;
    }
}
