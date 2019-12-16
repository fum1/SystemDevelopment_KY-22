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
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 879);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1376, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 879);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(13, 857);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1363, 22);
            this.panel3.TabIndex = 0;
            // 
            // dgv_ordercheck
            // 
            this.dgv_ordercheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordercheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ordercheck.Location = new System.Drawing.Point(13, 0);
            this.dgv_ordercheck.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgv_ordercheck.Name = "dgv_ordercheck";
            this.dgv_ordercheck.RowTemplate.Height = 21;
            this.dgv_ordercheck.Size = new System.Drawing.Size(1363, 857);
            this.dgv_ordercheck.TabIndex = 0;
            this.dgv_ordercheck.Click += new System.EventHandler(this.dgv_ordercheck_Click);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.panel4.Location = new System.Drawing.Point(13, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1363, 78);
            this.panel4.TabIndex = 2;
            // 
            // dtp_orderdate2
            // 
            this.dtp_orderdate2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_orderdate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate2.Location = new System.Drawing.Point(988, 16);
            this.dtp_orderdate2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtp_orderdate2.Name = "dtp_orderdate2";
            this.dtp_orderdate2.Size = new System.Drawing.Size(267, 40);
            this.dtp_orderdate2.TabIndex = 29;
            // 
            // lbl_stretchingrod
            // 
            this.lbl_stretchingrod.AutoSize = true;
            this.lbl_stretchingrod.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_stretchingrod.Location = new System.Drawing.Point(924, 22);
            this.lbl_stretchingrod.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_stretchingrod.Name = "lbl_stretchingrod";
            this.lbl_stretchingrod.Size = new System.Drawing.Size(48, 33);
            this.lbl_stretchingrod.TabIndex = 28;
            this.lbl_stretchingrod.Text = "～";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_search.Location = new System.Drawing.Point(973, 6);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(191, 68);
            this.btn_search.TabIndex = 27;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_delete.Location = new System.Drawing.Point(1172, 6);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(191, 68);
            this.btn_delete.TabIndex = 26;
            this.btn_delete.Text = "削除";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // mxt_productname
            // 
            this.mxt_productname.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mxt_productname.Location = new System.Drawing.Point(176, 11);
            this.mxt_productname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mxt_productname.Name = "mxt_productname";
            this.mxt_productname.Size = new System.Drawing.Size(260, 40);
            this.mxt_productname.TabIndex = 25;
            // 
            // lbl_productname
            // 
            this.lbl_productname.AutoSize = true;
            this.lbl_productname.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_productname.Location = new System.Drawing.Point(9, 15);
            this.lbl_productname.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_productname.Name = "lbl_productname";
            this.lbl_productname.Size = new System.Drawing.Size(114, 33);
            this.lbl_productname.TabIndex = 24;
            this.lbl_productname.Text = "商品名";
            // 
            // dtp_orderdate1
            // 
            this.dtp_orderdate1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_orderdate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderdate1.Location = new System.Drawing.Point(651, 15);
            this.dtp_orderdate1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtp_orderdate1.Name = "dtp_orderdate1";
            this.dtp_orderdate1.Size = new System.Drawing.Size(260, 40);
            this.dtp_orderdate1.TabIndex = 23;
            // 
            // lbl_orderdate
            // 
            this.lbl_orderdate.AutoSize = true;
            this.lbl_orderdate.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_orderdate.Location = new System.Drawing.Point(484, 15);
            this.lbl_orderdate.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbl_orderdate.Name = "lbl_orderdate";
            this.lbl_orderdate.Size = new System.Drawing.Size(114, 33);
            this.lbl_orderdate.TabIndex = 22;
            this.lbl_orderdate.Text = "受注日";
            // 
            // OrderCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_ordercheck);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OrderCheck";
            this.Size = new System.Drawing.Size(1389, 879);
            this.Load += new System.EventHandler(this.OrderCheck_Load);
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
