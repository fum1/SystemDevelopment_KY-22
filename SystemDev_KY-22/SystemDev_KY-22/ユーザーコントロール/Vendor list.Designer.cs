namespace SystemDev_KY_22.ユーザーコントロール
{
    partial class Vendor_list
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_vendorlist = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_telsearch = new System.Windows.Forms.Button();
            this.btn_Suppliersearch = new System.Windows.Forms.Button();
            this.cmb_SupplierID = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_SupplierID = new System.Windows.Forms.Label();
            this.cmb_tel = new System.Windows.Forms.ComboBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.btn_Suppliernamesearch = new System.Windows.Forms.Button();
            this.cmb_Suppliername = new System.Windows.Forms.ComboBox();
            this.lbl_Suppliername = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_registration = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_postalcodesearch = new System.Windows.Forms.Button();
            this.cmb_address = new System.Windows.Forms.ComboBox();
            this.lbl_postalcode = new System.Windows.Forms.Label();
            this.btn_addresssearch = new System.Windows.Forms.Button();
            this.cmb_postalcode = new System.Windows.Forms.ComboBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.btn_productsearch = new System.Windows.Forms.Button();
            this.cmb_product = new System.Windows.Forms.ComboBox();
            this.lbl_product = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendorlist)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 754);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(12, 749);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 15);
            this.panel3.TabIndex = 2;
            // 
            // dgv_vendorlist
            // 
            this.dgv_vendorlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vendorlist.Location = new System.Drawing.Point(12, 10);
            this.dgv_vendorlist.Name = "dgv_vendorlist";
            this.dgv_vendorlist.RowTemplate.Height = 24;
            this.dgv_vendorlist.Size = new System.Drawing.Size(1137, 925);
            this.dgv_vendorlist.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_productsearch);
            this.panel4.Controls.Add(this.cmb_product);
            this.panel4.Controls.Add(this.lbl_product);
            this.panel4.Controls.Add(this.btn_addresssearch);
            this.panel4.Controls.Add(this.cmb_postalcode);
            this.panel4.Controls.Add(this.lbl_address);
            this.panel4.Controls.Add(this.btn_postalcodesearch);
            this.panel4.Controls.Add(this.cmb_address);
            this.panel4.Controls.Add(this.lbl_postalcode);
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Controls.Add(this.btn_registration);
            this.panel4.Controls.Add(this.btn_search);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.btn_Clear);
            this.panel4.Controls.Add(this.btn_telsearch);
            this.panel4.Controls.Add(this.btn_Suppliersearch);
            this.panel4.Controls.Add(this.cmb_SupplierID);
            this.panel4.Controls.Add(this.lbl_id);
            this.panel4.Controls.Add(this.lbl_SupplierID);
            this.panel4.Controls.Add(this.cmb_tel);
            this.panel4.Controls.Add(this.lbl_tel);
            this.panel4.Controls.Add(this.btn_Suppliernamesearch);
            this.panel4.Controls.Add(this.cmb_Suppliername);
            this.panel4.Controls.Add(this.lbl_Suppliername);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(570, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(579, 764);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SystemDev_KY_22.Properties.Resources.チェリー;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(50, 704);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 170);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.Color.White;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Clear.Location = new System.Drawing.Point(346, 485);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(171, 59);
            this.btn_Clear.TabIndex = 20;
            this.btn_Clear.Text = "クリア";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // btn_telsearch
            // 
            this.btn_telsearch.BackColor = System.Drawing.Color.White;
            this.btn_telsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_telsearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_telsearch.Location = new System.Drawing.Point(462, 261);
            this.btn_telsearch.Name = "btn_telsearch";
            this.btn_telsearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_telsearch.Size = new System.Drawing.Size(55, 48);
            this.btn_telsearch.TabIndex = 5;
            this.btn_telsearch.Text = "🔍";
            this.btn_telsearch.UseVisualStyleBackColor = false;
            // 
            // btn_Suppliersearch
            // 
            this.btn_Suppliersearch.BackColor = System.Drawing.Color.White;
            this.btn_Suppliersearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Suppliersearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Suppliersearch.Location = new System.Drawing.Point(462, 37);
            this.btn_Suppliersearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Suppliersearch.Name = "btn_Suppliersearch";
            this.btn_Suppliersearch.Size = new System.Drawing.Size(55, 48);
            this.btn_Suppliersearch.TabIndex = 5;
            this.btn_Suppliersearch.Text = "🔍";
            this.btn_Suppliersearch.UseVisualStyleBackColor = false;
            // 
            // cmb_SupplierID
            // 
            this.cmb_SupplierID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_SupplierID.FormattingEnabled = true;
            this.cmb_SupplierID.Location = new System.Drawing.Point(220, 38);
            this.cmb_SupplierID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_SupplierID.Name = "cmb_SupplierID";
            this.cmb_SupplierID.Size = new System.Drawing.Size(236, 48);
            this.cmb_SupplierID.TabIndex = 16;
            this.cmb_SupplierID.SelectedIndexChanged += new System.EventHandler(this.cmb_SupplierID_SelectedIndexChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_id.Location = new System.Drawing.Point(6, 389);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 40);
            this.lbl_id.TabIndex = 10;
            // 
            // lbl_SupplierID
            // 
            this.lbl_SupplierID.AutoSize = true;
            this.lbl_SupplierID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SupplierID.Location = new System.Drawing.Point(20, 41);
            this.lbl_SupplierID.Name = "lbl_SupplierID";
            this.lbl_SupplierID.Size = new System.Drawing.Size(173, 40);
            this.lbl_SupplierID.TabIndex = 13;
            this.lbl_SupplierID.Text = "仕入先ID";
            this.lbl_SupplierID.Click += new System.EventHandler(this.lbl_position_Click);
            // 
            // cmb_tel
            // 
            this.cmb_tel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_tel.FormattingEnabled = true;
            this.cmb_tel.Location = new System.Drawing.Point(220, 262);
            this.cmb_tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_tel.Name = "cmb_tel";
            this.cmb_tel.Size = new System.Drawing.Size(236, 48);
            this.cmb_tel.TabIndex = 17;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_tel.Location = new System.Drawing.Point(20, 266);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(177, 40);
            this.lbl_tel.TabIndex = 14;
            this.lbl_tel.Text = "電話番号";
            // 
            // btn_Suppliernamesearch
            // 
            this.btn_Suppliernamesearch.BackColor = System.Drawing.Color.White;
            this.btn_Suppliernamesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Suppliernamesearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Suppliernamesearch.Location = new System.Drawing.Point(462, 111);
            this.btn_Suppliernamesearch.Name = "btn_Suppliernamesearch";
            this.btn_Suppliernamesearch.Size = new System.Drawing.Size(55, 48);
            this.btn_Suppliernamesearch.TabIndex = 5;
            this.btn_Suppliernamesearch.Text = "🔍";
            this.btn_Suppliernamesearch.UseVisualStyleBackColor = false;
            // 
            // cmb_Suppliername
            // 
            this.cmb_Suppliername.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_Suppliername.FormattingEnabled = true;
            this.cmb_Suppliername.Location = new System.Drawing.Point(220, 112);
            this.cmb_Suppliername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Suppliername.Name = "cmb_Suppliername";
            this.cmb_Suppliername.Size = new System.Drawing.Size(236, 48);
            this.cmb_Suppliername.TabIndex = 18;
            // 
            // lbl_Suppliername
            // 
            this.lbl_Suppliername.AutoSize = true;
            this.lbl_Suppliername.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Suppliername.Location = new System.Drawing.Point(20, 116);
            this.lbl_Suppliername.Name = "lbl_Suppliername";
            this.lbl_Suppliername.Size = new System.Drawing.Size(177, 40);
            this.lbl_Suppliername.TabIndex = 15;
            this.lbl_Suppliername.Text = "仕入先名";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_search.Location = new System.Drawing.Point(169, 485);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(171, 59);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_registration
            // 
            this.btn_registration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registration.BackColor = System.Drawing.Color.White;
            this.btn_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registration.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_registration.Location = new System.Drawing.Point(169, 550);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(171, 59);
            this.btn_registration.TabIndex = 25;
            this.btn_registration.Text = "登録";
            this.btn_registration.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_update.Location = new System.Drawing.Point(346, 550);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(171, 59);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "更新";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_postalcodesearch
            // 
            this.btn_postalcodesearch.BackColor = System.Drawing.Color.White;
            this.btn_postalcodesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_postalcodesearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_postalcodesearch.Location = new System.Drawing.Point(462, 186);
            this.btn_postalcodesearch.Name = "btn_postalcodesearch";
            this.btn_postalcodesearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_postalcodesearch.Size = new System.Drawing.Size(55, 48);
            this.btn_postalcodesearch.TabIndex = 27;
            this.btn_postalcodesearch.Text = "🔍";
            this.btn_postalcodesearch.UseVisualStyleBackColor = false;
            // 
            // cmb_address
            // 
            this.cmb_address.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_address.FormattingEnabled = true;
            this.cmb_address.Location = new System.Drawing.Point(220, 337);
            this.cmb_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_address.Name = "cmb_address";
            this.cmb_address.Size = new System.Drawing.Size(236, 48);
            this.cmb_address.TabIndex = 29;
            // 
            // lbl_postalcode
            // 
            this.lbl_postalcode.AutoSize = true;
            this.lbl_postalcode.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_postalcode.Location = new System.Drawing.Point(20, 191);
            this.lbl_postalcode.Name = "lbl_postalcode";
            this.lbl_postalcode.Size = new System.Drawing.Size(177, 40);
            this.lbl_postalcode.TabIndex = 28;
            this.lbl_postalcode.Text = "郵便番号";
            // 
            // btn_addresssearch
            // 
            this.btn_addresssearch.BackColor = System.Drawing.Color.White;
            this.btn_addresssearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addresssearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_addresssearch.Location = new System.Drawing.Point(462, 336);
            this.btn_addresssearch.Name = "btn_addresssearch";
            this.btn_addresssearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_addresssearch.Size = new System.Drawing.Size(55, 48);
            this.btn_addresssearch.TabIndex = 30;
            this.btn_addresssearch.Text = "🔍";
            this.btn_addresssearch.UseVisualStyleBackColor = false;
            // 
            // cmb_postalcode
            // 
            this.cmb_postalcode.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_postalcode.FormattingEnabled = true;
            this.cmb_postalcode.Location = new System.Drawing.Point(220, 187);
            this.cmb_postalcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_postalcode.Name = "cmb_postalcode";
            this.cmb_postalcode.Size = new System.Drawing.Size(236, 48);
            this.cmb_postalcode.TabIndex = 32;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_address.Location = new System.Drawing.Point(96, 341);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(97, 40);
            this.lbl_address.TabIndex = 31;
            this.lbl_address.Text = "住所";
            // 
            // btn_productsearch
            // 
            this.btn_productsearch.BackColor = System.Drawing.Color.White;
            this.btn_productsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productsearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_productsearch.Location = new System.Drawing.Point(462, 411);
            this.btn_productsearch.Name = "btn_productsearch";
            this.btn_productsearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_productsearch.Size = new System.Drawing.Size(55, 48);
            this.btn_productsearch.TabIndex = 33;
            this.btn_productsearch.Text = "🔍";
            this.btn_productsearch.UseVisualStyleBackColor = false;
            // 
            // cmb_product
            // 
            this.cmb_product.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_product.FormattingEnabled = true;
            this.cmb_product.Location = new System.Drawing.Point(220, 412);
            this.cmb_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(236, 48);
            this.cmb_product.TabIndex = 35;
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_product.Location = new System.Drawing.Point(60, 416);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(133, 40);
            this.lbl_product.TabIndex = 34;
            this.lbl_product.Text = "商品ID";
            this.lbl_product.Click += new System.EventHandler(this.label3_Click);
            // 
            // Vendor_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_vendorlist);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Vendor_list";
            this.Size = new System.Drawing.Size(1149, 764);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vendorlist)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_vendorlist;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_telsearch;
        private System.Windows.Forms.Button btn_Suppliersearch;
        private System.Windows.Forms.ComboBox cmb_SupplierID;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_SupplierID;
        private System.Windows.Forms.ComboBox cmb_tel;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Button btn_Suppliernamesearch;
        private System.Windows.Forms.ComboBox cmb_Suppliername;
        private System.Windows.Forms.Label lbl_Suppliername;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_productsearch;
        private System.Windows.Forms.ComboBox cmb_product;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Button btn_addresssearch;
        private System.Windows.Forms.ComboBox cmb_postalcode;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Button btn_postalcodesearch;
        private System.Windows.Forms.ComboBox cmb_address;
        private System.Windows.Forms.Label lbl_postalcode;
    }
}
