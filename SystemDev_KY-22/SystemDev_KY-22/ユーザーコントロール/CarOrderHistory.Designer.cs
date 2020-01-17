namespace SystemDev_KY_22.ユーザーコントロール
{
    partial class CarOrderHistory
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
            this.txt_EmpID = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.btn_EmpIDSeach = new System.Windows.Forms.Button();
            this.btn_ProductIDSeach = new System.Windows.Forms.Button();
            this.btn_SupplierIDSeach = new System.Windows.Forms.Button();
            this.btn_DateSeach = new System.Windows.Forms.Button();
            this.cmb_SupplierID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 43);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1095);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1384, 32);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 43);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(29, 1052);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1351, 43);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(33, 1052);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_Clear);
            this.panel5.Controls.Add(this.txt_EmpID);
            this.panel5.Controls.Add(this.txt_ProductID);
            this.panel5.Controls.Add(this.btn_EmpIDSeach);
            this.panel5.Controls.Add(this.btn_ProductIDSeach);
            this.panel5.Controls.Add(this.btn_SupplierIDSeach);
            this.panel5.Controls.Add(this.btn_DateSeach);
            this.panel5.Controls.Add(this.cmb_SupplierID);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(29, 43);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1322, 147);
            this.panel5.TabIndex = 28;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.btn_Clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Clear.Location = new System.Drawing.Point(1114, 77);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(208, 64);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "条件クリア";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_EmpID
            // 
            this.txt_EmpID.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_EmpID.Location = new System.Drawing.Point(707, 59);
            this.txt_EmpID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_EmpID.Name = "txt_EmpID";
            this.txt_EmpID.Size = new System.Drawing.Size(194, 35);
            this.txt_EmpID.TabIndex = 6;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ProductID.Location = new System.Drawing.Point(707, 7);
            this.txt_ProductID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.Size = new System.Drawing.Size(194, 35);
            this.txt_ProductID.TabIndex = 4;
            // 
            // btn_EmpIDSeach
            // 
            this.btn_EmpIDSeach.BackColor = System.Drawing.Color.White;
            this.btn_EmpIDSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EmpIDSeach.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_EmpIDSeach.Location = new System.Drawing.Point(920, 58);
            this.btn_EmpIDSeach.Name = "btn_EmpIDSeach";
            this.btn_EmpIDSeach.Size = new System.Drawing.Size(51, 46);
            this.btn_EmpIDSeach.TabIndex = 7;
            this.btn_EmpIDSeach.Text = "🔍";
            this.btn_EmpIDSeach.UseVisualStyleBackColor = false;
            this.btn_EmpIDSeach.Click += new System.EventHandler(this.btn_EmpIDSeach_Click);
            // 
            // btn_ProductIDSeach
            // 
            this.btn_ProductIDSeach.BackColor = System.Drawing.Color.White;
            this.btn_ProductIDSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProductIDSeach.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_ProductIDSeach.Location = new System.Drawing.Point(920, 3);
            this.btn_ProductIDSeach.Name = "btn_ProductIDSeach";
            this.btn_ProductIDSeach.Size = new System.Drawing.Size(51, 46);
            this.btn_ProductIDSeach.TabIndex = 5;
            this.btn_ProductIDSeach.Text = "🔍";
            this.btn_ProductIDSeach.UseVisualStyleBackColor = false;
            this.btn_ProductIDSeach.Click += new System.EventHandler(this.btn_ProductIDSeach_Click);
            // 
            // btn_SupplierIDSeach
            // 
            this.btn_SupplierIDSeach.BackColor = System.Drawing.Color.White;
            this.btn_SupplierIDSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SupplierIDSeach.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_SupplierIDSeach.Location = new System.Drawing.Point(407, 63);
            this.btn_SupplierIDSeach.Name = "btn_SupplierIDSeach";
            this.btn_SupplierIDSeach.Size = new System.Drawing.Size(51, 46);
            this.btn_SupplierIDSeach.TabIndex = 3;
            this.btn_SupplierIDSeach.Text = "🔍";
            this.btn_SupplierIDSeach.UseVisualStyleBackColor = false;
            this.btn_SupplierIDSeach.Click += new System.EventHandler(this.btn_SupplierIDSeach_Click);
            // 
            // btn_DateSeach
            // 
            this.btn_DateSeach.BackColor = System.Drawing.Color.White;
            this.btn_DateSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DateSeach.Font = new System.Drawing.Font("MS UI Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_DateSeach.Location = new System.Drawing.Point(407, 4);
            this.btn_DateSeach.Name = "btn_DateSeach";
            this.btn_DateSeach.Size = new System.Drawing.Size(51, 46);
            this.btn_DateSeach.TabIndex = 1;
            this.btn_DateSeach.Text = "🔍";
            this.btn_DateSeach.UseVisualStyleBackColor = false;
            this.btn_DateSeach.Click += new System.EventHandler(this.btn_DateSeach_Click);
            // 
            // cmb_SupplierID
            // 
            this.cmb_SupplierID.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_SupplierID.FormattingEnabled = true;
            this.cmb_SupplierID.Location = new System.Drawing.Point(145, 68);
            this.cmb_SupplierID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmb_SupplierID.Name = "cmb_SupplierID";
            this.cmb_SupplierID.Size = new System.Drawing.Size(208, 35);
            this.cmb_SupplierID.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 4);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 35);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 19, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(597, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "社員ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(597, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 28);
            this.label3.TabIndex = 30;
            this.label3.Text = "商品ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "仕入先ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "年月日";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(29, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1322, 905);
            this.dataGridView1.TabIndex = 29;
            // 
            // CarOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "CarOrderHistory";
            this.Size = new System.Drawing.Size(1384, 1127);
            this.Load += new System.EventHandler(this.CarOrderHistory_Load);
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
        private System.Windows.Forms.ComboBox cmb_SupplierID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_SupplierIDSeach;
        private System.Windows.Forms.Button btn_DateSeach;
        private System.Windows.Forms.Button btn_EmpIDSeach;
        private System.Windows.Forms.Button btn_ProductIDSeach;
        private System.Windows.Forms.TextBox txt_EmpID;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Button btn_Clear;
    }
}
