namespace SystemDev_KY_22.ユーザーコントロール
{
    partial class Storing
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_storing = new System.Windows.Forms.Label();
            this.lbl_receipt = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.txt_storing = new System.Windows.Forms.TextBox();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.txt_receipt = new System.Windows.Forms.TextBox();
            this.btn_itemregister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 404);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1741, 522);
            this.dataGridView.TabIndex = 0;
            // 
            // btn_register
            // 
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_register.Location = new System.Drawing.Point(1352, 326);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(158, 60);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "登録";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("メイリオ", 18F);
            this.btn_update.Location = new System.Drawing.Point(1568, 326);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(158, 60);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "更新";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_storing
            // 
            this.lbl_storing.AutoSize = true;
            this.lbl_storing.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_storing.Location = new System.Drawing.Point(95, 37);
            this.lbl_storing.Name = "lbl_storing";
            this.lbl_storing.Size = new System.Drawing.Size(144, 57);
            this.lbl_storing.TabIndex = 3;
            this.lbl_storing.Text = "入庫ID";
            // 
            // lbl_receipt
            // 
            this.lbl_receipt.AutoSize = true;
            this.lbl_receipt.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_receipt.Location = new System.Drawing.Point(569, 258);
            this.lbl_receipt.Name = "lbl_receipt";
            this.lbl_receipt.Size = new System.Drawing.Size(215, 57);
            this.lbl_receipt.TabIndex = 4;
            this.lbl_receipt.Text = "入庫年月日";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_num.Location = new System.Drawing.Point(100, 258);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(139, 57);
            this.lbl_num.TabIndex = 5;
            this.lbl_num.Text = "入庫数";
            // 
            // txt_storing
            // 
            this.txt_storing.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_storing.Location = new System.Drawing.Point(245, 41);
            this.txt_storing.Name = "txt_storing";
            this.txt_storing.Size = new System.Drawing.Size(315, 52);
            this.txt_storing.TabIndex = 6;
            // 
            // txt_supplier
            // 
            this.txt_supplier.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_supplier.Location = new System.Drawing.Point(790, 41);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(315, 52);
            this.txt_supplier.TabIndex = 7;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_name.Location = new System.Drawing.Point(245, 145);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(315, 52);
            this.txt_name.TabIndex = 8;
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_supplier.Location = new System.Drawing.Point(602, 37);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(182, 57);
            this.lbl_supplier.TabIndex = 9;
            this.lbl_supplier.Text = "仕入先ID";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_name.Location = new System.Drawing.Point(100, 141);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(139, 57);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "商品名";
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_model.Location = new System.Drawing.Point(790, 145);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(315, 52);
            this.txt_model.TabIndex = 11;
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_color.Location = new System.Drawing.Point(1197, 145);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(315, 52);
            this.txt_color.TabIndex = 12;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_model.Location = new System.Drawing.Point(645, 141);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(139, 57);
            this.lbl_model.TabIndex = 13;
            this.lbl_model.Text = "モデル";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_num.Location = new System.Drawing.Point(245, 258);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(315, 52);
            this.txt_num.TabIndex = 14;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_color.Location = new System.Drawing.Point(1128, 141);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(63, 57);
            this.lbl_color.TabIndex = 15;
            this.lbl_color.Text = "色";
            // 
            // txt_receipt
            // 
            this.txt_receipt.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_receipt.Location = new System.Drawing.Point(790, 258);
            this.txt_receipt.Name = "txt_receipt";
            this.txt_receipt.Size = new System.Drawing.Size(315, 52);
            this.txt_receipt.TabIndex = 16;
            // 
            // btn_itemregister
            // 
            this.btn_itemregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemregister.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_itemregister.Location = new System.Drawing.Point(1162, 326);
            this.btn_itemregister.Name = "btn_itemregister";
            this.btn_itemregister.Size = new System.Drawing.Size(158, 60);
            this.btn_itemregister.TabIndex = 17;
            this.btn_itemregister.Text = "商品登録";
            this.btn_itemregister.UseVisualStyleBackColor = true;
            this.btn_itemregister.Click += new System.EventHandler(this.btn_itemregister_Click);
            // 
            // Storing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_itemregister);
            this.Controls.Add(this.txt_receipt);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_supplier);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_supplier);
            this.Controls.Add(this.txt_storing);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.lbl_receipt);
            this.Controls.Add(this.lbl_storing);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.dataGridView);
            this.Name = "Storing";
            this.Size = new System.Drawing.Size(1747, 929);
            this.Load += new System.EventHandler(this.Storing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_storing;
        private System.Windows.Forms.Label lbl_receipt;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.TextBox txt_storing;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.TextBox txt_receipt;
        private System.Windows.Forms.Button btn_itemregister;
    }
}
