namespace SystemDev_KY_22.ユーザーコントロール
{
    partial class OrderCheck
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_ordercheck = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtp_orderdate2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_stretchingrod = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.mxt_productname = new System.Windows.Forms.MaskedTextBox();
            this.lbl_productname = new System.Windows.Forms.Label();
            this.dtp_orderdate1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_orderdate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordercheck)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 703);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1032, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 703);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 685);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1022, 18);
            this.panel3.TabIndex = 0;
            // 
            // dgv_ordercheck
            // 
            this.dgv_ordercheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordercheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ordercheck.Location = new System.Drawing.Point(10, 0);
            this.dgv_ordercheck.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ordercheck.Name = "dgv_ordercheck";
            this.dgv_ordercheck.RowTemplate.Height = 21;
            this.dgv_ordercheck.Size = new System.Drawing.Size(1022, 685);
            this.dgv_ordercheck.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip2";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtp_orderdate2);
            this.panel4.Controls.Add(this.lbl_stretchingrod);
            this.panel4.Controls.Add(this.btn_search);
            this.panel4.Controls.Add(this.btn_delete);
            this.panel4.Controls.Add(this.mxt_productname);
            this.panel4.Controls.Add(this.lbl_productname);
            this.panel4.Controls.Add(this.dtp_orderdate1);
            this.panel4.Controls.Add(this.lbl_orderdate);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1022, 62);
            this.panel4.TabIndex = 2;
            // 
            // dtp_orderdate2
            // 
            this.dtp_orderdate2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_orderdate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate2.Location = new System.Drawing.Point(741, 13);
            this.dtp_orderdate2.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_orderdate2.Name = "dtp_orderdate2";
            this.dtp_orderdate2.Size = new System.Drawing.Size(201, 34);
            this.dtp_orderdate2.TabIndex = 29;
            // 
            // lbl_stretchingrod
            // 
            this.lbl_stretchingrod.AutoSize = true;
            this.lbl_stretchingrod.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_stretchingrod.Location = new System.Drawing.Point(693, 18);
            this.lbl_stretchingrod.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_stretchingrod.Name = "lbl_stretchingrod";
            this.lbl_stretchingrod.Size = new System.Drawing.Size(39, 27);
            this.lbl_stretchingrod.TabIndex = 28;
            this.lbl_stretchingrod.Text = "～";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_search.Location = new System.Drawing.Point(730, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(143, 54);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_delete.Location = new System.Drawing.Point(879, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(143, 54);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "削除";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // mxt_productname
            // 
            this.mxt_productname.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mxt_productname.Location = new System.Drawing.Point(132, 9);
            this.mxt_productname.Name = "mxt_productname";
            this.mxt_productname.Size = new System.Drawing.Size(196, 34);
            this.mxt_productname.TabIndex = 25;
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_productname.Location = new System.Drawing.Point(7, 12);
            this.lbl_productname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(93, 27);
            this.lbl_productname.TabIndex = 24;
            this.lbl_productname.Text = "商品名";
            // 
            // dtp_orderdate1
            // 
            this.dtp_orderdate1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_orderdate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate1.Location = new System.Drawing.Point(488, 12);
            this.dtp_orderdate1.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_orderdate1.Name = "dtp_orderdate1";
            this.dtp_orderdate1.Size = new System.Drawing.Size(196, 34);
            this.dtp_orderdate1.TabIndex = 23;
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_orderdate.Location = new System.Drawing.Point(363, 12);
            this.lbl_orderdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(93, 27);
            this.lbl_orderdate.TabIndex = 22;
            this.lbl_orderdate.Text = "受注日";
            // 
            // OrderCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_ordercheck);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderCheck";
            this.Size = new System.Drawing.Size(1042, 703);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordercheck)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_ordercheck;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtp_orderdate2;
        private System.Windows.Forms.Label lbl_stretchingrod;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.MaskedTextBox mxt_productname;
        private System.Windows.Forms.Label lbl_productname;
        private System.Windows.Forms.DateTimePicker dtp_orderdate1;
        private System.Windows.Forms.Label lbl_orderdate;
    }
}
