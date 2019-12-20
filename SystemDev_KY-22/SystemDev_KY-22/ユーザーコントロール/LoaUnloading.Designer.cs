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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaunloading)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_storing
            // 
            this.rbt_storing.AutoSize = true;
            this.rbt_storing.Checked = true;
            this.rbt_storing.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbt_storing.Location = new System.Drawing.Point(19, 26);
            this.rbt_storing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbt_storing.Name = "rbt_storing";
            this.rbt_storing.Size = new System.Drawing.Size(102, 37);
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
            this.rbt_Issue.Location = new System.Drawing.Point(155, 26);
            this.rbt_Issue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbt_Issue.Name = "rbt_Issue";
            this.rbt_Issue.Size = new System.Drawing.Size(102, 37);
            this.rbt_Issue.TabIndex = 3;
            this.rbt_Issue.Text = "出庫";
            this.rbt_Issue.UseVisualStyleBackColor = true;
            this.rbt_Issue.CheckedChanged += new System.EventHandler(this.rbt_Issue_CheckedChanged);
            // 
            // dgv_loaunloading
            // 
            this.dgv_loaunloading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaunloading.Location = new System.Drawing.Point(19, 87);
            this.dgv_loaunloading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_loaunloading.Name = "dgv_loaunloading";
            this.dgv_loaunloading.RowHeadersWidth = 62;
            this.dgv_loaunloading.RowTemplate.Height = 24;
            this.dgv_loaunloading.Size = new System.Drawing.Size(1715, 805);
            this.dgv_loaunloading.TabIndex = 4;
            // 
            // LoaUnloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_loaunloading);
            this.Controls.Add(this.rbt_Issue);
            this.Controls.Add(this.rbt_storing);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoaUnloading";
            this.Size = new System.Drawing.Size(1747, 929);
            this.Load += new System.EventHandler(this.LoaUnloading_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaunloading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbt_storing;
        private System.Windows.Forms.RadioButton rbt_Issue;
        private System.Windows.Forms.DataGridView dgv_loaunloading;
    }
}
