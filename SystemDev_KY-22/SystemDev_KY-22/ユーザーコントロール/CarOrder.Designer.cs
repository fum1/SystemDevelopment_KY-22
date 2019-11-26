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
            this.txt_person = new System.Windows.Forms.TextBox();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_supplier.Location = new System.Drawing.Point(29, 61);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(139, 57);
            this.lbl_supplier.TabIndex = 0;
            this.lbl_supplier.Text = "仕入先";
            // 
            // lbl_Person
            // 
            this.lbl_Person.AutoSize = true;
            this.lbl_Person.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Person.Location = new System.Drawing.Point(29, 132);
            this.lbl_Person.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Person.Name = "lbl_Person";
            this.lbl_Person.Size = new System.Drawing.Size(139, 57);
            this.lbl_Person.TabIndex = 12;
            this.lbl_Person.Text = "担当者";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_orderdate.Location = new System.Drawing.Point(29, 203);
            this.lbl_orderdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(139, 57);
            this.lbl_orderdate.TabIndex = 14;
            this.lbl_orderdate.Text = "発注日";
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("メイリオ", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_productname.Location = new System.Drawing.Point(29, 274);
            this.lbl_productname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(139, 57);
            this.lbl_productname.TabIndex = 18;
            this.lbl_productname.Text = "商品名";
            // 
            // txt_productname
            // 
            this.txt_productname.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_productname.Location = new System.Drawing.Point(278, 274);
            this.txt_productname.Margin = new System.Windows.Forms.Padding(5);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(233, 42);
            this.txt_productname.TabIndex = 19;
            // 
            // dtp_admissionday
            // 
            this.dtp_admissionday.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_admissionday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_admissionday.Location = new System.Drawing.Point(278, 203);
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
            this.btn_clear.Location = new System.Drawing.Point(205, 567);
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
            this.btn_order.Location = new System.Drawing.Point(361, 567);
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
            this.lbl_color.Location = new System.Drawing.Point(29, 416);
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
            this.lbl_model.Location = new System.Drawing.Point(29, 345);
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
            this.lbl_option.Location = new System.Drawing.Point(29, 487);
            this.lbl_option.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_option.Name = "lbl_option";
            this.lbl_option.Size = new System.Drawing.Size(215, 57);
            this.lbl_option.TabIndex = 34;
            this.lbl_option.Text = "オプション";
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_model.Location = new System.Drawing.Point(278, 345);
            this.txt_model.Margin = new System.Windows.Forms.Padding(5);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(233, 42);
            this.txt_model.TabIndex = 35;
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_color.Location = new System.Drawing.Point(278, 416);
            this.txt_color.Margin = new System.Windows.Forms.Padding(5);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(233, 42);
            this.txt_color.TabIndex = 36;
            // 
            // txt_option
            // 
            this.txt_option.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_option.Location = new System.Drawing.Point(278, 487);
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
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 38;
            this.pictureBox.TabStop = false;
            // 
            // txt_person
            // 
            this.txt_person.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_person.Location = new System.Drawing.Point(278, 132);
            this.txt_person.Margin = new System.Windows.Forms.Padding(5);
            this.txt_person.Name = "txt_person";
            this.txt_person.Size = new System.Drawing.Size(233, 42);
            this.txt_person.TabIndex = 42;
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(278, 61);
            this.cmb_supplier.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(233, 42);
            this.cmb_supplier.TabIndex = 39;
            // 
            // CarOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_person);
            this.Controls.Add(this.cmb_supplier);
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
        private System.Windows.Forms.TextBox txt_person;
        private System.Windows.Forms.ComboBox cmb_supplier;
    }
}
