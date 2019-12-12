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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_itemregister = new System.Windows.Forms.Button();
            this.txt_receipt = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_supplier = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.txt_storing = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_receipt = new System.Windows.Forms.Label();
            this.lbl_storing = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(4, 485);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(2176, 626);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_itemregister);
            this.panel1.Controls.Add(this.txt_receipt);
            this.panel1.Controls.Add(this.lbl_color);
            this.panel1.Controls.Add(this.txt_num);
            this.panel1.Controls.Add(this.lbl_model);
            this.panel1.Controls.Add(this.txt_color);
            this.panel1.Controls.Add(this.txt_model);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_supplier);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.txt_supplier);
            this.panel1.Controls.Add(this.txt_storing);
            this.panel1.Controls.Add(this.lbl_num);
            this.panel1.Controls.Add(this.lbl_receipt);
            this.panel1.Controls.Add(this.lbl_storing);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2184, 478);
            this.panel1.TabIndex = 1;
            // 
            // btn_itemregister
            // 
            this.btn_itemregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemregister.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_itemregister.Location = new System.Drawing.Point(1397, 378);
            this.btn_itemregister.Margin = new System.Windows.Forms.Padding(4);
            this.btn_itemregister.Name = "btn_itemregister";
            this.btn_itemregister.Size = new System.Drawing.Size(198, 72);
            this.btn_itemregister.TabIndex = 34;
            this.btn_itemregister.Text = "商品登録";
            this.btn_itemregister.UseVisualStyleBackColor = true;
            this.btn_itemregister.Click += new System.EventHandler(this.Btn_itemregister_Click_1);
            // 
            // txt_receipt
            // 
            this.txt_receipt.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_receipt.Location = new System.Drawing.Point(933, 297);
            this.txt_receipt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_receipt.Name = "txt_receipt";
            this.txt_receipt.Size = new System.Drawing.Size(393, 61);
            this.txt_receipt.TabIndex = 33;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_color.Location = new System.Drawing.Point(1355, 156);
            this.lbl_color.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(74, 68);
            this.lbl_color.TabIndex = 32;
            this.lbl_color.Text = "色";
            // 
            // txt_num
            // 
            this.txt_num.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_num.Location = new System.Drawing.Point(251, 297);
            this.txt_num.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(393, 61);
            this.txt_num.TabIndex = 31;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_model.Location = new System.Drawing.Point(751, 156);
            this.lbl_model.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(164, 68);
            this.lbl_model.TabIndex = 30;
            this.lbl_model.Text = "モデル";
            // 
            // txt_color
            // 
            this.txt_color.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_color.Location = new System.Drawing.Point(1441, 161);
            this.txt_color.Margin = new System.Windows.Forms.Padding(4);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(393, 61);
            this.txt_color.TabIndex = 29;
            // 
            // txt_model
            // 
            this.txt_model.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_model.Location = new System.Drawing.Point(933, 161);
            this.txt_model.Margin = new System.Windows.Forms.Padding(4);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(393, 61);
            this.txt_model.TabIndex = 28;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_name.Location = new System.Drawing.Point(70, 156);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(164, 68);
            this.lbl_name.TabIndex = 27;
            this.lbl_name.Text = "商品名";
            // 
            // lbl_supplier
            // 
            this.lbl_supplier.AutoSize = true;
            this.lbl_supplier.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_supplier.Location = new System.Drawing.Point(697, 31);
            this.lbl_supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_supplier.Name = "lbl_supplier";
            this.lbl_supplier.Size = new System.Drawing.Size(216, 68);
            this.lbl_supplier.TabIndex = 26;
            this.lbl_supplier.Text = "仕入先ID";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_name.Location = new System.Drawing.Point(251, 161);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(393, 61);
            this.txt_name.TabIndex = 25;
            // 
            // txt_supplier
            // 
            this.txt_supplier.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_supplier.Location = new System.Drawing.Point(933, 36);
            this.txt_supplier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.Size = new System.Drawing.Size(393, 61);
            this.txt_supplier.TabIndex = 24;
            // 
            // txt_storing
            // 
            this.txt_storing.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_storing.Location = new System.Drawing.Point(251, 36);
            this.txt_storing.Margin = new System.Windows.Forms.Padding(4);
            this.txt_storing.Name = "txt_storing";
            this.txt_storing.Size = new System.Drawing.Size(393, 61);
            this.txt_storing.TabIndex = 23;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_num.Location = new System.Drawing.Point(70, 297);
            this.lbl_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(164, 68);
            this.lbl_num.TabIndex = 22;
            this.lbl_num.Text = "入庫数";
            // 
            // lbl_receipt
            // 
            this.lbl_receipt.AutoSize = true;
            this.lbl_receipt.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_receipt.Location = new System.Drawing.Point(656, 297);
            this.lbl_receipt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_receipt.Name = "lbl_receipt";
            this.lbl_receipt.Size = new System.Drawing.Size(254, 68);
            this.lbl_receipt.TabIndex = 21;
            this.lbl_receipt.Text = "入庫年月日";
            // 
            // lbl_storing
            // 
            this.lbl_storing.AutoSize = true;
            this.lbl_storing.Font = new System.Drawing.Font("メイリオ", 22.2F);
            this.lbl_storing.Location = new System.Drawing.Point(64, 31);
            this.lbl_storing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_storing.Name = "lbl_storing";
            this.lbl_storing.Size = new System.Drawing.Size(171, 68);
            this.lbl_storing.TabIndex = 20;
            this.lbl_storing.Text = "入庫ID";
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("メイリオ", 18F);
            this.btn_update.Location = new System.Drawing.Point(1905, 378);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(198, 72);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "更新";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_register.Location = new System.Drawing.Point(1635, 378);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(198, 72);
            this.btn_register.TabIndex = 18;
            this.btn_register.Text = "登録";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // Storing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Storing";
            this.Size = new System.Drawing.Size(2184, 1115);
            this.Load += new System.EventHandler(this.Storing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_itemregister;
        private System.Windows.Forms.TextBox txt_receipt;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_supplier;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.TextBox txt_storing;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_receipt;
        private System.Windows.Forms.Label lbl_storing;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_register;
    }
}
