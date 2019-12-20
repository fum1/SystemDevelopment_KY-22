namespace SystemDev_KY_22.ユーザーコントロール
{
    partial class OrderHistory
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ClientIDSeach = new System.Windows.Forms.Button();
            this.btn_EmpIDSeach = new System.Windows.Forms.Button();
            this.btn_StoreIDSeach = new System.Windows.Forms.Button();
            this.btn_DateTimeSeach = new System.Windows.Forms.Button();
            this.cmb_StoreID = new System.Windows.Forms.ComboBox();
            this.txt_ClientID = new System.Windows.Forms.TextBox();
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_StoreID = new System.Windows.Forms.Label();
            this.lbl_EmpID = new System.Windows.Forms.Label();
            this.lbl_ClientID = new System.Windows.Forms.Label();
            this.lbl_OrderDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 24);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 709);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 26);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1206, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 685);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 685);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Clear);
            this.panel5.Controls.Add(this.btn_ClientIDSeach);
            this.panel5.Controls.Add(this.btn_EmpIDSeach);
            this.panel5.Controls.Add(this.btn_StoreIDSeach);
            this.panel5.Controls.Add(this.btn_DateTimeSeach);
            this.panel5.Controls.Add(this.cmb_StoreID);
            this.panel5.Controls.Add(this.txt_ClientID);
            this.panel5.Controls.Add(this.txt_EmpID);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.lbl_StoreID);
            this.panel5.Controls.Add(this.lbl_EmpID);
            this.panel5.Controls.Add(this.lbl_ClientID);
            this.panel5.Controls.Add(this.lbl_OrderDate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(23, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1183, 133);
            this.panel5.TabIndex = 4;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(1000, 74);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(179, 53);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "条件クリア";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ClientIDSeach
            // 
            this.btn_ClientIDSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientIDSeach.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.btn_ClientIDSeach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ClientIDSeach.Location = new System.Drawing.Point(844, 74);
            this.btn_ClientIDSeach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ClientIDSeach.Name = "btn_ClientIDSeach";
            this.btn_ClientIDSeach.Size = new System.Drawing.Size(37, 37);
            this.btn_ClientIDSeach.TabIndex = 11;
            this.btn_ClientIDSeach.Text = "🔍";
            this.btn_ClientIDSeach.UseVisualStyleBackColor = true;
            this.btn_ClientIDSeach.Click += new System.EventHandler(this.btn_ClientID_Click);
            // 
            // btn_EmpIDSeach
            // 
            this.btn_EmpIDSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EmpIDSeach.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.btn_EmpIDSeach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_EmpIDSeach.Location = new System.Drawing.Point(844, 22);
            this.btn_EmpIDSeach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EmpIDSeach.Name = "btn_EmpIDSeach";
            this.btn_EmpIDSeach.Size = new System.Drawing.Size(37, 37);
            this.btn_EmpIDSeach.TabIndex = 10;
            this.btn_EmpIDSeach.Text = "🔍";
            this.btn_EmpIDSeach.UseVisualStyleBackColor = true;
            this.btn_EmpIDSeach.Click += new System.EventHandler(this.btn_EmpIDSeach_Click);
            // 
            // btn_StoreIDSeach
            // 
            this.btn_StoreIDSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StoreIDSeach.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.btn_StoreIDSeach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_StoreIDSeach.Location = new System.Drawing.Point(362, 74);
            this.btn_StoreIDSeach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_StoreIDSeach.Name = "btn_StoreIDSeach";
            this.btn_StoreIDSeach.Size = new System.Drawing.Size(37, 37);
            this.btn_StoreIDSeach.TabIndex = 9;
            this.btn_StoreIDSeach.Text = "🔍";
            this.btn_StoreIDSeach.UseVisualStyleBackColor = true;
            this.btn_StoreIDSeach.Click += new System.EventHandler(this.btn_StoreIDSeach_Click);
            // 
            // btn_DateTimeSeach
            // 
            this.btn_DateTimeSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DateTimeSeach.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.btn_DateTimeSeach.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_DateTimeSeach.Location = new System.Drawing.Point(362, 22);
            this.btn_DateTimeSeach.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DateTimeSeach.Name = "btn_DateTimeSeach";
            this.btn_DateTimeSeach.Size = new System.Drawing.Size(37, 37);
            this.btn_DateTimeSeach.TabIndex = 8;
            this.btn_DateTimeSeach.Text = "🔍";
            this.btn_DateTimeSeach.UseVisualStyleBackColor = true;
            this.btn_DateTimeSeach.Click += new System.EventHandler(this.btn_DateTimeSeach_Click);
            // 
            // cmb_StoreID
            // 
            this.cmb_StoreID.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_StoreID.FormattingEnabled = true;
            this.cmb_StoreID.Location = new System.Drawing.Point(146, 74);
            this.cmb_StoreID.Name = "cmb_StoreID";
            this.cmb_StoreID.Size = new System.Drawing.Size(209, 38);
            this.cmb_StoreID.TabIndex = 7;
            // 
            // txt_ClientID
            // 
            this.txt_ClientID.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ClientID.Location = new System.Drawing.Point(637, 74);
            this.txt_ClientID.Name = "txt_ClientID";
            this.txt_ClientID.Size = new System.Drawing.Size(200, 37);
            this.txt_ClientID.TabIndex = 6;
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_EmpID.Location = new System.Drawing.Point(637, 22);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.Size = new System.Drawing.Size(200, 37);
            this.txt_EmpID.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 37);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lbl_StoreID
            // 
            this.lbl_StoreID.AutoSize = true;
            this.lbl_StoreID.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_StoreID.Location = new System.Drawing.Point(55, 77);
            this.lbl_StoreID.Name = "lbl_StoreID";
            this.lbl_StoreID.Size = new System.Drawing.Size(76, 30);
            this.lbl_StoreID.TabIndex = 3;
            this.lbl_StoreID.Text = "店舗ID";
            // 
            // lbl_EmpID
            // 
            this.lbl_EmpID.AutoSize = true;
            this.lbl_EmpID.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_EmpID.Location = new System.Drawing.Point(555, 27);
            this.lbl_EmpID.Name = "lbl_EmpID";
            this.lbl_EmpID.Size = new System.Drawing.Size(76, 30);
            this.lbl_EmpID.TabIndex = 2;
            this.lbl_EmpID.Text = "社員ID";
            // 
            // lbl_ClientID
            // 
            this.lbl_ClientID.AutoSize = true;
            this.lbl_ClientID.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ClientID.Location = new System.Drawing.Point(555, 77);
            this.lbl_ClientID.Name = "lbl_ClientID";
            this.lbl_ClientID.Size = new System.Drawing.Size(76, 30);
            this.lbl_ClientID.TabIndex = 1;
            this.lbl_ClientID.Text = "顧客ID";
            // 
            // lbl_OrderDate
            // 
            this.lbl_OrderDate.AutoSize = true;
            this.lbl_OrderDate.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_OrderDate.Location = new System.Drawing.Point(58, 27);
            this.lbl_OrderDate.Name = "lbl_OrderDate";
            this.lbl_OrderDate.Size = new System.Drawing.Size(73, 30);
            this.lbl_OrderDate.TabIndex = 0;
            this.lbl_OrderDate.Text = "注文日";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(23, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1183, 552);
            this.dataGridView1.TabIndex = 5;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderHistory";
            this.Size = new System.Drawing.Size(1230, 735);
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_OrderDate;
        private System.Windows.Forms.Label lbl_ClientID;
        private System.Windows.Forms.Label lbl_EmpID;
        private System.Windows.Forms.Label lbl_StoreID;
        private System.Windows.Forms.ComboBox cmb_StoreID;
        private System.Windows.Forms.TextBox txt_ClientID;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_ClientIDSeach;
        private System.Windows.Forms.Button btn_EmpIDSeach;
        private System.Windows.Forms.Button btn_StoreIDSeach;
        private System.Windows.Forms.Button btn_DateTimeSeach;
        private System.Windows.Forms.Button btn_Clear;
    }
}
