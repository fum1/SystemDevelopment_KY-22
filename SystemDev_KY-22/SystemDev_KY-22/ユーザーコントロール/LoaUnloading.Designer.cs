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
            this.lbl_storing = new System.Windows.Forms.Label();
            this.rbtn_storing = new System.Windows.Forms.RadioButton();
            this.rbtn_Issue = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_productname = new System.Windows.Forms.TextBox();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.lbl_ten = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_storing
            // 
            this.lbl_storing.AutoSize = true;
            this.lbl_storing.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lbl_storing.Location = new System.Drawing.Point(41, 29);
            this.lbl_storing.Name = "lbl_storing";
            this.lbl_storing.Size = new System.Drawing.Size(163, 30);
            this.lbl_storing.TabIndex = 0;
            this.lbl_storing.Text = "入出庫画面";
            // 
            // rbtn_storing
            // 
            this.rbtn_storing.AutoSize = true;
            this.rbtn_storing.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.rbtn_storing.Location = new System.Drawing.Point(46, 131);
            this.rbtn_storing.Name = "rbtn_storing";
            this.rbtn_storing.Size = new System.Drawing.Size(87, 31);
            this.rbtn_storing.TabIndex = 2;
            this.rbtn_storing.TabStop = true;
            this.rbtn_storing.Text = "入庫";
            this.rbtn_storing.UseVisualStyleBackColor = true;
            // 
            // rbtn_Issue
            // 
            this.rbtn_Issue.AutoSize = true;
            this.rbtn_Issue.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.rbtn_Issue.Location = new System.Drawing.Point(155, 133);
            this.rbtn_Issue.Name = "rbtn_Issue";
            this.rbtn_Issue.Size = new System.Drawing.Size(87, 31);
            this.rbtn_Issue.TabIndex = 3;
            this.rbtn_Issue.TabStop = true;
            this.rbtn_Issue.Text = "出庫";
            this.rbtn_Issue.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(996, 422);
            this.dataGridView1.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btn_search.Location = new System.Drawing.Point(908, 124);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(81, 40);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.btn_clear.Location = new System.Drawing.Point(818, 124);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 40);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // txt_productname
            // 
            this.txt_productname.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txt_productname.Location = new System.Drawing.Point(590, 130);
            this.txt_productname.Name = "txt_productname";
            this.txt_productname.Size = new System.Drawing.Size(206, 34);
            this.txt_productname.TabIndex = 7;
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_productname.Location = new System.Drawing.Point(459, 137);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(93, 27);
            this.lbl_productname.TabIndex = 8;
            this.lbl_productname.Text = "商品名";
            // 
            // lbl_ten
            // 
            this.lbl_ten.AutoSize = true;
            this.lbl_ten.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.lbl_ten.Location = new System.Drawing.Point(558, 135);
            this.lbl_ten.Name = "lbl_ten";
            this.lbl_ten.Size = new System.Drawing.Size(26, 27);
            this.lbl_ten.TabIndex = 9;
            this.lbl_ten.Text = "：";
            // 
            // LoaUnloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_ten);
            this.Controls.Add(this.lbl_productname);
            this.Controls.Add(this.txt_productname);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbtn_Issue);
            this.Controls.Add(this.rbtn_storing);
            this.Controls.Add(this.lbl_storing);
            this.Name = "LoaUnloading";
            this.Size = new System.Drawing.Size(1002, 592);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_storing;
        private System.Windows.Forms.RadioButton rbtn_storing;
        private System.Windows.Forms.RadioButton rbtn_Issue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_productname;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.Label lbl_ten;
    }
}
