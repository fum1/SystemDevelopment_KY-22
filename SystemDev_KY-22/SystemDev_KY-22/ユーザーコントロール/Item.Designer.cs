namespace SystemDev_KY_22.ユーザーコントロール
{
    partial class Item
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
            this.lbl_item = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_maker = new System.Windows.Forms.Label();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_maker = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_register = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_pricesearch = new System.Windows.Forms.Button();
            this.btn_typesearch = new System.Windows.Forms.Button();
            this.btn_makersearch = new System.Windows.Forms.Button();
            this.btn_suppliersearch = new System.Windows.Forms.Button();
            this.btn_itemsearch = new System.Windows.Forms.Button();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_clear2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_itemIDsearch = new System.Windows.Forms.Button();
            this.btn_mileagesearch = new System.Windows.Forms.Button();
            this.btn_releasesearch = new System.Windows.Forms.Button();
            this.btn_optionsearch = new System.Windows.Forms.Button();
            this.btn_colorsearch = new System.Windows.Forms.Button();
            this.btn_modelsearch = new System.Windows.Forms.Button();
            this.btn_actualsearch = new System.Windows.Forms.Button();
            this.btn_vehiclesearch = new System.Windows.Forms.Button();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.btn_register1 = new System.Windows.Forms.Button();
            this.txt_vehicle = new System.Windows.Forms.TextBox();
            this.txt_actual = new System.Windows.Forms.TextBox();
            this.lbl_vehicle = new System.Windows.Forms.Label();
            this.lbl_actual = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_option = new System.Windows.Forms.TextBox();
            this.txt_release = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_option = new System.Windows.Forms.Label();
            this.lbl_release = new System.Windows.Forms.Label();
            this.txt_mileage = new System.Windows.Forms.TextBox();
            this.lbl_mileage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_item.Location = new System.Drawing.Point(64, 62);
            this.lbl_item.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(164, 68);
            this.lbl_item.TabIndex = 21;
            this.lbl_item.Text = "商品名";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_price.Location = new System.Drawing.Point(111, 167);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(119, 68);
            this.lbl_price.TabIndex = 22;
            this.lbl_price.Text = "定価";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_type.Location = new System.Drawing.Point(111, 271);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(119, 68);
            this.lbl_type.TabIndex = 23;
            this.lbl_type.Text = "車種";
            // 
            // lbl_maker
            // 
            this.lbl_maker.AutoSize = true;
            this.lbl_maker.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_maker.Location = new System.Drawing.Point(16, 376);
            this.lbl_maker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_maker.Name = "lbl_maker";
            this.lbl_maker.Size = new System.Drawing.Size(209, 68);
            this.lbl_maker.TabIndex = 24;
            this.lbl_maker.Text = "メーカー";
            // 
            // txt_item
            // 
            this.txt_item.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_item.Location = new System.Drawing.Point(286, 67);
            this.txt_item.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(283, 61);
            this.txt_item.TabIndex = 25;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_price.Location = new System.Drawing.Point(286, 170);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(283, 61);
            this.txt_price.TabIndex = 26;
            // 
            // txt_maker
            // 
            this.txt_maker.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_maker.Location = new System.Drawing.Point(286, 377);
            this.txt_maker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_maker.Name = "txt_maker";
            this.txt_maker.Size = new System.Drawing.Size(283, 61);
            this.txt_maker.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(700, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(2125, 1068);
            this.dataGridView1.TabIndex = 29;
            // 
            // btn_register
            // 
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_register.Location = new System.Drawing.Point(449, 581);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(198, 72);
            this.btn_register.TabIndex = 30;
            this.btn_register.Text = "登録";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tab.Location = new System.Drawing.Point(4, 4);
            this.tab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(2150, 1079);
            this.tab.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.btn_pricesearch);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btn_typesearch);
            this.tabPage1.Controls.Add(this.btn_makersearch);
            this.tabPage1.Controls.Add(this.btn_suppliersearch);
            this.tabPage1.Controls.Add(this.btn_itemsearch);
            this.tabPage1.Controls.Add(this.cmb_type);
            this.tabPage1.Controls.Add(this.txt_supplier);
            this.tabPage1.Controls.Add(this.lbl_supplier);
            this.tabPage1.Controls.Add(this.lbl_item);
            this.tabPage1.Controls.Add(this.btn_register);
            this.tabPage1.Controls.Add(this.txt_item);
            this.tabPage1.Controls.Add(this.lbl_price);
            this.tabPage1.Controls.Add(this.txt_maker);
            this.tabPage1.Controls.Add(this.txt_price);
            this.tabPage1.Controls.Add(this.lbl_maker);
            this.tabPage1.Controls.Add(this.lbl_type);
            this.tabPage1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(2142, 1043);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "商品";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(220, 581);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(198, 72);
            this.btn_clear.TabIndex = 40;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_pricesearch
            // 
            this.btn_pricesearch.BackColor = System.Drawing.Color.White;
            this.btn_pricesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pricesearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_pricesearch.Location = new System.Drawing.Point(578, 170);
            this.btn_pricesearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_pricesearch.Name = "btn_pricesearch";
            this.btn_pricesearch.Size = new System.Drawing.Size(69, 61);
            this.btn_pricesearch.TabIndex = 39;
            this.btn_pricesearch.Text = "🔍";
            this.btn_pricesearch.UseVisualStyleBackColor = false;
            this.btn_pricesearch.Click += new System.EventHandler(this.btn_pricesearch_Click);
            // 
            // btn_typesearch
            // 
            this.btn_typesearch.BackColor = System.Drawing.Color.White;
            this.btn_typesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_typesearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_typesearch.Location = new System.Drawing.Point(578, 275);
            this.btn_typesearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_typesearch.Name = "btn_typesearch";
            this.btn_typesearch.Size = new System.Drawing.Size(69, 61);
            this.btn_typesearch.TabIndex = 38;
            this.btn_typesearch.Text = "🔍";
            this.btn_typesearch.UseVisualStyleBackColor = false;
            this.btn_typesearch.Click += new System.EventHandler(this.btn_typesearch_Click);
            // 
            // btn_makersearch
            // 
            this.btn_makersearch.BackColor = System.Drawing.Color.White;
            this.btn_makersearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_makersearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_makersearch.Location = new System.Drawing.Point(578, 378);
            this.btn_makersearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_makersearch.Name = "btn_makersearch";
            this.btn_makersearch.Size = new System.Drawing.Size(69, 61);
            this.btn_makersearch.TabIndex = 37;
            this.btn_makersearch.Text = "🔍";
            this.btn_makersearch.UseVisualStyleBackColor = false;
            this.btn_makersearch.Click += new System.EventHandler(this.btn_makersearch_Click);
            // 
            // btn_suppliersearch
            // 
            this.btn_suppliersearch.BackColor = System.Drawing.Color.White;
            this.btn_suppliersearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suppliersearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_suppliersearch.Location = new System.Drawing.Point(578, 480);
            this.btn_suppliersearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_suppliersearch.Name = "btn_suppliersearch";
            this.btn_suppliersearch.Size = new System.Drawing.Size(69, 61);
            this.btn_suppliersearch.TabIndex = 36;
            this.btn_suppliersearch.Text = "🔍";
            this.btn_suppliersearch.UseVisualStyleBackColor = false;
            this.btn_suppliersearch.Click += new System.EventHandler(this.btn_suppliersearch_Click);
            // 
            // btn_itemsearch
            // 
            this.btn_itemsearch.BackColor = System.Drawing.Color.White;
            this.btn_itemsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemsearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_itemsearch.Location = new System.Drawing.Point(578, 70);
            this.btn_itemsearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_itemsearch.Name = "btn_itemsearch";
            this.btn_itemsearch.Size = new System.Drawing.Size(69, 61);
            this.btn_itemsearch.TabIndex = 34;
            this.btn_itemsearch.Text = "🔍";
            this.btn_itemsearch.UseVisualStyleBackColor = false;
            this.btn_itemsearch.Click += new System.EventHandler(this.btn_itemsearch_Click);
            // 
            // cmb_type
            // 
            this.cmb_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_type.Font = new System.Drawing.Font("メイリオ", 18F);
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(286, 274);
            this.cmb_type.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(276, 62);
            this.cmb_type.TabIndex = 33;
            // 
            // txt_supplier
            // 
            this.txt_supplier.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_supplier.Location = new System.Drawing.Point(286, 480);
            this.txt_supplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(283, 61);
            this.txt_supplier.TabIndex = 32;
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_supplier.Location = new System.Drawing.Point(16, 480);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(216, 68);
            this.lbl_supplier.TabIndex = 31;
            this.lbl_supplier.Text = "仕入先ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_clear2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btn_itemIDsearch);
            this.tabPage2.Controls.Add(this.btn_mileagesearch);
            this.tabPage2.Controls.Add(this.btn_releasesearch);
            this.tabPage2.Controls.Add(this.btn_optionsearch);
            this.tabPage2.Controls.Add(this.btn_colorsearch);
            this.tabPage2.Controls.Add(this.btn_modelsearch);
            this.tabPage2.Controls.Add(this.btn_actualsearch);
            this.tabPage2.Controls.Add(this.btn_vehiclesearch);
            this.tabPage2.Controls.Add(this.txt_itemID);
            this.tabPage2.Controls.Add(this.lbl_itemID);
            this.tabPage2.Controls.Add(this.btn_register1);
            this.tabPage2.Controls.Add(this.txt_vehicle);
            this.tabPage2.Controls.Add(this.txt_actual);
            this.tabPage2.Controls.Add(this.lbl_vehicle);
            this.tabPage2.Controls.Add(this.lbl_actual);
            this.tabPage2.Controls.Add(this.txt_model);
            this.tabPage2.Controls.Add(this.txt_color);
            this.tabPage2.Controls.Add(this.txt_option);
            this.tabPage2.Controls.Add(this.txt_release);
            this.tabPage2.Controls.Add(this.lbl_model);
            this.tabPage2.Controls.Add(this.lbl_color);
            this.tabPage2.Controls.Add(this.lbl_option);
            this.tabPage2.Controls.Add(this.lbl_release);
            this.tabPage2.Controls.Add(this.txt_mileage);
            this.tabPage2.Controls.Add(this.lbl_mileage);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(2142, 1043);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "商品詳細";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_clear2
            // 
            this.btn_clear2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear2.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear2.Location = new System.Drawing.Point(261, 752);
            this.btn_clear2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear2.Name = "btn_clear2";
            this.btn_clear2.Size = new System.Drawing.Size(198, 72);
            this.btn_clear2.TabIndex = 56;
            this.btn_clear2.Text = "クリア";
            this.btn_clear2.UseVisualStyleBackColor = true;
            this.btn_clear2.Click += new System.EventHandler(this.btn_clear2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(685, 11);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1500, 1020);
            this.dataGridView2.TabIndex = 55;
            // 
            // btn_itemIDsearch
            // 
            this.btn_itemIDsearch.BackColor = System.Drawing.Color.White;
            this.btn_itemIDsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemIDsearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_itemIDsearch.Location = new System.Drawing.Point(596, 11);
            this.btn_itemIDsearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_itemIDsearch.Name = "btn_itemIDsearch";
            this.btn_itemIDsearch.Size = new System.Drawing.Size(69, 61);
            this.btn_itemIDsearch.TabIndex = 54;
            this.btn_itemIDsearch.Text = "🔍";
            this.btn_itemIDsearch.UseVisualStyleBackColor = false;
            this.btn_itemIDsearch.Click += new System.EventHandler(this.btn_itemIDsearch_Click);
            // 
            // btn_mileagesearch
            // 
            this.btn_mileagesearch.BackColor = System.Drawing.Color.White;
            this.btn_mileagesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mileagesearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_mileagesearch.Location = new System.Drawing.Point(596, 97);
            this.btn_mileagesearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_mileagesearch.Name = "btn_mileagesearch";
            this.btn_mileagesearch.Size = new System.Drawing.Size(69, 61);
            this.btn_mileagesearch.TabIndex = 53;
            this.btn_mileagesearch.Text = "🔍";
            this.btn_mileagesearch.UseVisualStyleBackColor = false;
            this.btn_mileagesearch.Click += new System.EventHandler(this.btn_mileagesearch_Click);
            // 
            // btn_releasesearch
            // 
            this.btn_releasesearch.BackColor = System.Drawing.Color.White;
            this.btn_releasesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_releasesearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_releasesearch.Location = new System.Drawing.Point(596, 194);
            this.btn_releasesearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_releasesearch.Name = "btn_releasesearch";
            this.btn_releasesearch.Size = new System.Drawing.Size(69, 61);
            this.btn_releasesearch.TabIndex = 52;
            this.btn_releasesearch.Text = "🔍";
            this.btn_releasesearch.UseVisualStyleBackColor = false;
            this.btn_releasesearch.Click += new System.EventHandler(this.btn_releasesearch_Click);
            // 
            // btn_optionsearch
            // 
            this.btn_optionsearch.BackColor = System.Drawing.Color.White;
            this.btn_optionsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_optionsearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_optionsearch.Location = new System.Drawing.Point(596, 288);
            this.btn_optionsearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_optionsearch.Name = "btn_optionsearch";
            this.btn_optionsearch.Size = new System.Drawing.Size(69, 61);
            this.btn_optionsearch.TabIndex = 51;
            this.btn_optionsearch.Text = "🔍";
            this.btn_optionsearch.UseVisualStyleBackColor = false;
            this.btn_optionsearch.Click += new System.EventHandler(this.btn_optionsearch_Click);
            // 
            // btn_colorsearch
            // 
            this.btn_colorsearch.BackColor = System.Drawing.Color.White;
            this.btn_colorsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colorsearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_colorsearch.Location = new System.Drawing.Point(596, 374);
            this.btn_colorsearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_colorsearch.Name = "btn_colorsearch";
            this.btn_colorsearch.Size = new System.Drawing.Size(69, 61);
            this.btn_colorsearch.TabIndex = 50;
            this.btn_colorsearch.Text = "🔍";
            this.btn_colorsearch.UseVisualStyleBackColor = false;
            this.btn_colorsearch.Click += new System.EventHandler(this.btn_colorsearch_Click);
            // 
            // btn_modelsearch
            // 
            this.btn_modelsearch.BackColor = System.Drawing.Color.White;
            this.btn_modelsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modelsearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_modelsearch.Location = new System.Drawing.Point(596, 472);
            this.btn_modelsearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_modelsearch.Name = "btn_modelsearch";
            this.btn_modelsearch.Size = new System.Drawing.Size(69, 61);
            this.btn_modelsearch.TabIndex = 49;
            this.btn_modelsearch.Text = "🔍";
            this.btn_modelsearch.UseVisualStyleBackColor = false;
            this.btn_modelsearch.Click += new System.EventHandler(this.btn_modelsearch_Click);
            // 
            // btn_actualsearch
            // 
            this.btn_actualsearch.BackColor = System.Drawing.Color.White;
            this.btn_actualsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualsearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_actualsearch.Location = new System.Drawing.Point(596, 559);
            this.btn_actualsearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_actualsearch.Name = "btn_actualsearch";
            this.btn_actualsearch.Size = new System.Drawing.Size(69, 61);
            this.btn_actualsearch.TabIndex = 48;
            this.btn_actualsearch.Text = "🔍";
            this.btn_actualsearch.UseVisualStyleBackColor = false;
            this.btn_actualsearch.Click += new System.EventHandler(this.btn_actualsearch_Click);
            // 
            // btn_vehiclesearch
            // 
            this.btn_vehiclesearch.BackColor = System.Drawing.Color.White;
            this.btn_vehiclesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehiclesearch.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_vehiclesearch.Location = new System.Drawing.Point(596, 661);
            this.btn_vehiclesearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_vehiclesearch.Name = "btn_vehiclesearch";
            this.btn_vehiclesearch.Size = new System.Drawing.Size(69, 61);
            this.btn_vehiclesearch.TabIndex = 47;
            this.btn_vehiclesearch.Text = "🔍";
            this.btn_vehiclesearch.UseVisualStyleBackColor = false;
            this.btn_vehiclesearch.Click += new System.EventHandler(this.btn_vehiclesearch_Click);
            // 
            // txt_itemID
            // 
            this.txt_itemID.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_itemID.Location = new System.Drawing.Point(305, 10);
            this.txt_itemID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.Size = new System.Drawing.Size(283, 61);
            this.txt_itemID.TabIndex = 46;
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_itemID.Location = new System.Drawing.Point(91, 10);
            this.lbl_itemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(171, 68);
            this.lbl_itemID.TabIndex = 45;
            this.lbl_itemID.Text = "商品ID";
            // 
            // btn_register1
            // 
            this.btn_register1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register1.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_register1.Location = new System.Drawing.Point(467, 752);
            this.btn_register1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_register1.Name = "btn_register1";
            this.btn_register1.Size = new System.Drawing.Size(198, 72);
            this.btn_register1.TabIndex = 32;
            this.btn_register1.Text = "登録";
            this.btn_register1.UseVisualStyleBackColor = true;
            this.btn_register1.Click += new System.EventHandler(this.btn_register1_Click);
            // 
            // txt_vehicle
            // 
            this.txt_vehicle.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_vehicle.Location = new System.Drawing.Point(305, 661);
            this.txt_vehicle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_vehicle.Name = "txt_vehicle";
            this.txt_vehicle.Size = new System.Drawing.Size(283, 61);
            this.txt_vehicle.TabIndex = 44;
            // 
            // txt_actual
            // 
            this.txt_actual.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_actual.Location = new System.Drawing.Point(305, 564);
            this.txt_actual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_actual.Name = "txt_actual";
            this.txt_actual.Size = new System.Drawing.Size(283, 61);
            this.txt_actual.TabIndex = 43;
            // 
            // lbl_vehicle
            // 
            this.lbl_vehicle.AutoSize = true;
            this.lbl_vehicle.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_vehicle.Location = new System.Drawing.Point(50, 656);
            this.lbl_vehicle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vehicle.Name = "lbl_vehicle";
            this.lbl_vehicle.Size = new System.Drawing.Size(209, 68);
            this.lbl_vehicle.TabIndex = 42;
            this.lbl_vehicle.Text = "車両状態";
            // 
            // lbl_actual
            // 
            this.lbl_actual.AutoSize = true;
            this.lbl_actual.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_actual.Location = new System.Drawing.Point(50, 564);
            this.lbl_actual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_actual.Name = "lbl_actual";
            this.lbl_actual.Size = new System.Drawing.Size(209, 68);
            this.lbl_actual.TabIndex = 41;
            this.lbl_actual.Text = "実売価格";
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_model.Location = new System.Drawing.Point(305, 472);
            this.txt_model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(283, 61);
            this.txt_model.TabIndex = 40;
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_color.Location = new System.Drawing.Point(305, 379);
            this.txt_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(283, 61);
            this.txt_color.TabIndex = 39;
            // 
            // txt_option
            // 
            this.txt_option.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_option.Location = new System.Drawing.Point(305, 287);
            this.txt_option.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_option.Name = "txt_option";
            this.txt_option.Size = new System.Drawing.Size(283, 61);
            this.txt_option.TabIndex = 38;
            // 
            // txt_release
            // 
            this.txt_release.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_release.Location = new System.Drawing.Point(305, 194);
            this.txt_release.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_release.Name = "txt_release";
            this.txt_release.Size = new System.Drawing.Size(283, 61);
            this.txt_release.TabIndex = 37;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_model.Location = new System.Drawing.Point(98, 472);
            this.lbl_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(164, 68);
            this.lbl_model.TabIndex = 36;
            this.lbl_model.Text = "モデル";
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_color.Location = new System.Drawing.Point(192, 379);
            this.lbl_color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(74, 68);
            this.lbl_color.TabIndex = 35;
            this.lbl_color.Text = "色";
            // 
            // lbl_option
            // 
            this.lbl_option.AutoSize = true;
            this.lbl_option.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_option.Location = new System.Drawing.Point(2, 287);
            this.lbl_option.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_option.Name = "lbl_option";
            this.lbl_option.Size = new System.Drawing.Size(254, 68);
            this.lbl_option.TabIndex = 34;
            this.lbl_option.Text = "オプション";
            // 
            // lbl_release
            // 
            this.lbl_release.AutoSize = true;
            this.lbl_release.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_release.Location = new System.Drawing.Point(98, 194);
            this.lbl_release.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_release.Name = "lbl_release";
            this.lbl_release.Size = new System.Drawing.Size(164, 68);
            this.lbl_release.TabIndex = 33;
            this.lbl_release.Text = "発売日";
            // 
            // txt_mileage
            // 
            this.txt_mileage.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_mileage.Location = new System.Drawing.Point(305, 102);
            this.txt_mileage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mileage.Name = "txt_mileage";
            this.txt_mileage.Size = new System.Drawing.Size(283, 61);
            this.txt_mileage.TabIndex = 31;
            // 
            // lbl_mileage
            // 
            this.lbl_mileage.AutoSize = true;
            this.lbl_mileage.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_mileage.Location = new System.Drawing.Point(50, 102);
            this.lbl_mileage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mileage.Name = "lbl_mileage";
            this.lbl_mileage.Size = new System.Drawing.Size(209, 68);
            this.lbl_mileage.TabIndex = 32;
            this.lbl_mileage.Text = "走行距離";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tab);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Item";
            this.Size = new System.Drawing.Size(2291, 1087);
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_maker;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_maker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_vehicle;
        private System.Windows.Forms.TextBox txt_actual;
        private System.Windows.Forms.Label lbl_vehicle;
        private System.Windows.Forms.Label lbl_actual;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_option;
        private System.Windows.Forms.TextBox txt_release;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_option;
        private System.Windows.Forms.Label lbl_release;
        private System.Windows.Forms.TextBox txt_mileage;
        private System.Windows.Forms.Label lbl_mileage;
        private System.Windows.Forms.Button btn_register1;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Button btn_pricesearch;
        private System.Windows.Forms.Button btn_typesearch;
        private System.Windows.Forms.Button btn_makersearch;
        private System.Windows.Forms.Button btn_suppliersearch;
        private System.Windows.Forms.Button btn_itemsearch;
        private System.Windows.Forms.Button btn_itemIDsearch;
        private System.Windows.Forms.Button btn_mileagesearch;
        private System.Windows.Forms.Button btn_releasesearch;
        private System.Windows.Forms.Button btn_optionsearch;
        private System.Windows.Forms.Button btn_colorsearch;
        private System.Windows.Forms.Button btn_modelsearch;
        private System.Windows.Forms.Button btn_actualsearch;
        private System.Windows.Forms.Button btn_vehiclesearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_clear2;
    }
}
