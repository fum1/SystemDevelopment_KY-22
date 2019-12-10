namespace SystemDev_KY_22
{
    partial class ReceiveList
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
            this.dtp_orderdate = new System.Windows.Forms.DateTimePicker();
            this.dgv_receivelist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_orderdate = new System.Windows.Forms.Label();
            this.txt_ordernumber = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.lbl_ordernumber = new System.Windows.Forms.Label();
            this.lbl_customername = new System.Windows.Forms.Label();
            this.txt_customername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receivelist)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_orderdate
            // 
            this.dtp_orderdate.CalendarFont = new System.Drawing.Font("メイリオ", 12F);
            this.dtp_orderdate.Font = new System.Drawing.Font("メイリオ", 14.2F);
            this.dtp_orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate.Location = new System.Drawing.Point(102, 51);
            this.dtp_orderdate.Name = "dtp_orderdate";
            this.dtp_orderdate.Size = new System.Drawing.Size(159, 36);
            this.dtp_orderdate.TabIndex = 22;
            // 
            // dgv_receivelist
            // 
            this.dgv_receivelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receivelist.Location = new System.Drawing.Point(0, 144);
            this.dgv_receivelist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_receivelist.Name = "dgv_receivelist";
            this.dgv_receivelist.RowTemplate.Height = 24;
            this.dgv_receivelist.Size = new System.Drawing.Size(763, 322);
            this.dgv_receivelist.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 22F);
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "受注確認画面";
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lbl_orderdate.Location = new System.Drawing.Point(13, 62);
            this.lbl_orderdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(82, 24);
            this.lbl_orderdate.TabIndex = 25;
            this.lbl_orderdate.Text = "受注日";
            // 
            // txt_ordernumber
            // 
            this.txt_ordernumber.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txt_ordernumber.Location = new System.Drawing.Point(413, 58);
            this.txt_ordernumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ordernumber.Name = "txt_ordernumber";
            this.txt_ordernumber.Size = new System.Drawing.Size(138, 29);
            this.txt_ordernumber.TabIndex = 26;
            // 
            // lbl_ordernumber
            // 
            this.lbl_ordernumber.AutoSize = true;
            this.lbl_ordernumber.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lbl_ordernumber.Location = new System.Drawing.Point(292, 62);
            this.lbl_ordernumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ordernumber.Name = "lbl_ordernumber";
            this.lbl_ordernumber.Size = new System.Drawing.Size(106, 24);
            this.lbl_ordernumber.TabIndex = 27;
            this.lbl_ordernumber.Text = "受注番号";
            // 
            // lbl_customername
            // 
            this.lbl_customername.AutoSize = true;
            this.lbl_customername.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lbl_customername.Location = new System.Drawing.Point(13, 105);
            this.lbl_customername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_customername.Name = "lbl_customername";
            this.lbl_customername.Size = new System.Drawing.Size(82, 24);
            this.lbl_customername.TabIndex = 28;
            this.lbl_customername.Text = "顧客名";
            // 
            // txt_customername
            // 
            this.txt_customername.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.txt_customername.Location = new System.Drawing.Point(102, 105);
            this.txt_customername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_customername.Name = "txt_customername";
            this.txt_customername.Size = new System.Drawing.Size(159, 29);
            this.txt_customername.TabIndex = 30;
            // 
            // ReceiveList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_customername);
            this.Controls.Add(this.lbl_customername);
            this.Controls.Add(this.lbl_ordernumber);
            this.Controls.Add(this.txt_ordernumber);
            this.Controls.Add(this.lbl_orderdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_receivelist);
            this.Controls.Add(this.dtp_orderdate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReceiveList";
            this.Size = new System.Drawing.Size(765, 468);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receivelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_orderdate;
        private System.Windows.Forms.DataGridView dgv_receivelist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_orderdate;
        private System.Windows.Forms.TextBox txt_ordernumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label lbl_ordernumber;
        private System.Windows.Forms.Label lbl_customername;
        private System.Windows.Forms.TextBox txt_customername;
    }
}
