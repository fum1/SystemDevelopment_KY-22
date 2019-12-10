namespace SystemDev_KY_22.ユーザーコントロール
{
    partial class shipping
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cmb_Shipping_Vol = new System.Windows.Forms.ComboBox();
            this.btn_shipping = new System.Windows.Forms.Button();
            this.lbl_Productid = new System.Windows.Forms.Label();
            this.lbl_Shipping_Vol = new System.Windows.Forms.Label();
            this.txt_Product = new System.Windows.Forms.TextBox();
            this.btn_IDcheck = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btn_IDcheck);
            this.groupBox.Controls.Add(this.cmb_Shipping_Vol);
            this.groupBox.Controls.Add(this.btn_shipping);
            this.groupBox.Controls.Add(this.lbl_Productid);
            this.groupBox.Controls.Add(this.lbl_Shipping_Vol);
            this.groupBox.Controls.Add(this.txt_Product);
            this.groupBox.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox.Location = new System.Drawing.Point(98, 231);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(776, 335);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "出庫情報";
            // 
            // cmb_Shipping_Vol
            // 
            this.cmb_Shipping_Vol.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_Shipping_Vol.FormattingEnabled = true;
            this.cmb_Shipping_Vol.Items.AddRange(new object[] {
            "男性",
            "女性"});
            this.cmb_Shipping_Vol.Location = new System.Drawing.Point(330, 133);
            this.cmb_Shipping_Vol.Name = "cmb_Shipping_Vol";
            this.cmb_Shipping_Vol.Size = new System.Drawing.Size(213, 55);
            this.cmb_Shipping_Vol.TabIndex = 25;
            // 
            // btn_shipping
            // 
            this.btn_shipping.BackColor = System.Drawing.Color.Transparent;
            this.btn_shipping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shipping.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_shipping.Location = new System.Drawing.Point(199, 226);
            this.btn_shipping.Margin = new System.Windows.Forms.Padding(4);
            this.btn_shipping.Name = "btn_shipping";
            this.btn_shipping.Size = new System.Drawing.Size(395, 74);
            this.btn_shipping.TabIndex = 19;
            this.btn_shipping.Text = "出庫情報登録";
            this.btn_shipping.UseVisualStyleBackColor = false;
            this.btn_shipping.Click += new System.EventHandler(this.btn_shipping_Click);
            // 
            // lbl_Productid
            // 
            this.lbl_Productid.AutoSize = true;
            this.lbl_Productid.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Productid.Location = new System.Drawing.Point(58, 54);
            this.lbl_Productid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Productid.Name = "lbl_Productid";
            this.lbl_Productid.Size = new System.Drawing.Size(265, 48);
            this.lbl_Productid.TabIndex = 7;
            this.lbl_Productid.Text = "商品詳細ID:";
            // 
            // lbl_Shipping_Vol
            // 
            this.lbl_Shipping_Vol.AutoSize = true;
            this.lbl_Shipping_Vol.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Shipping_Vol.Location = new System.Drawing.Point(149, 133);
            this.lbl_Shipping_Vol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Shipping_Vol.Name = "lbl_Shipping_Vol";
            this.lbl_Shipping_Vol.Size = new System.Drawing.Size(174, 48);
            this.lbl_Shipping_Vol.TabIndex = 12;
            this.lbl_Shipping_Vol.Text = "出庫数:";
            // 
            // txt_Product
            // 
            this.txt_Product.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Product.Location = new System.Drawing.Point(330, 55);
            this.txt_Product.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Product.Name = "txt_Product";
            this.txt_Product.Size = new System.Drawing.Size(350, 54);
            this.txt_Product.TabIndex = 5;
            // 
            // btn_IDcheck
            // 
            this.btn_IDcheck.BackColor = System.Drawing.Color.Transparent;
            this.btn_IDcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IDcheck.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_IDcheck.Location = new System.Drawing.Point(688, 55);
            this.btn_IDcheck.Margin = new System.Windows.Forms.Padding(4);
            this.btn_IDcheck.Name = "btn_IDcheck";
            this.btn_IDcheck.Size = new System.Drawing.Size(80, 54);
            this.btn_IDcheck.TabIndex = 26;
            this.btn_IDcheck.Text = "✅";
            this.btn_IDcheck.UseVisualStyleBackColor = false;
            this.btn_IDcheck.Click += new System.EventHandler(this.btn_IDcheck_Click);
            // 
            // shipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "shipping";
            this.Size = new System.Drawing.Size(1356, 768);
            this.Load += new System.EventHandler(this.shipping_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cmb_Shipping_Vol;
        private System.Windows.Forms.Button btn_shipping;
        private System.Windows.Forms.Label lbl_Productid;
        private System.Windows.Forms.Label lbl_Shipping_Vol;
        private System.Windows.Forms.TextBox txt_Product;
        private System.Windows.Forms.Button btn_IDcheck;
    }
}
