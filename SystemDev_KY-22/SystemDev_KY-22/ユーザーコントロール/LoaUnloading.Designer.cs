namespace SystemDev_KY_22
{
    partial class LoaUnloading
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
            this.rbt_storing = new System.Windows.Forms.RadioButton();
            this.rbt_Issue = new System.Windows.Forms.RadioButton();
            this.dgv_loaunloading = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaunloading)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_storing
            // 
            this.rbt_storing.AutoSize = true;
            this.rbt_storing.Checked = true;
            this.rbt_storing.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbt_storing.Location = new System.Drawing.Point(826, 46);
            this.rbt_storing.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbt_storing.Name = "rbt_storing";
            this.rbt_storing.Size = new System.Drawing.Size(122, 44);
            this.rbt_storing.TabIndex = 2;
            this.rbt_storing.TabStop = true;
            this.rbt_storing.Text = "入庫";
            this.rbt_storing.UseVisualStyleBackColor = true;
            this.rbt_storing.CheckedChanged += new System.EventHandler(this.rbt_storing_CheckedChanged);
            // 
            // rbt_Issue
            // 
            this.rbt_Issue.AutoSize = true;
            this.rbt_Issue.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbt_Issue.Location = new System.Drawing.Point(996, 46);
            this.rbt_Issue.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rbt_Issue.Name = "rbt_Issue";
            this.rbt_Issue.Size = new System.Drawing.Size(122, 44);
            this.rbt_Issue.TabIndex = 3;
            this.rbt_Issue.Text = "出庫";
            this.rbt_Issue.UseVisualStyleBackColor = true;
            this.rbt_Issue.CheckedChanged += new System.EventHandler(this.rbt_Issue_CheckedChanged);
            // 
            // dgv_loaunloading
            // 
            this.dgv_loaunloading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaunloading.Location = new System.Drawing.Point(24, 104);
            this.dgv_loaunloading.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgv_loaunloading.Name = "dgv_loaunloading";
            this.dgv_loaunloading.RowHeadersWidth = 62;
            this.dgv_loaunloading.RowTemplate.Height = 24;
            this.dgv_loaunloading.Size = new System.Drawing.Size(2144, 966);
            this.dgv_loaunloading.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_search.Location = new System.Drawing.Point(1854, 38);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(154, 61);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(2014, 38);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(154, 61);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // txt_productname
            // 
            this.txt_productname.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_productname.Location = new System.Drawing.Point(1384, 46);
            this.txt_productname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(448, 47);
            this.txt_productname.TabIndex = 7;
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_productname.Location = new System.Drawing.Point(1205, 50);
            this.lbl_productname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(123, 36);
            this.lbl_productname.TabIndex = 8;
            this.lbl_productname.Text = "商品名";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ten.Location = new System.Drawing.Point(1341, 50);
            this.lbl_ten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(33, 36);
            this.lbl_ten.TabIndex = 9;
            this.lbl_ten.Text = "：";
            // 
            // LoaUnloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.lbl_productname);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dgv_loaunloading);
            this.Controls.Add(this.rbt_Issue);
            this.Controls.Add(this.rbt_storing);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "LoaUnloading";
            this.Size = new System.Drawing.Size(2184, 1115);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaunloading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbt_storing;
        private System.Windows.Forms.RadioButton rbt_Issue;
        private System.Windows.Forms.DataGridView dgv_loaunloading;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.Label lbl_ten;
    }
}
