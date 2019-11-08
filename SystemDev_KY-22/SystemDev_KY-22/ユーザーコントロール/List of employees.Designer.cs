namespace SystemDev_KY_22.ユーザーコントロール
{
    partial class List_of_employees
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_clerk = new System.Windows.Forms.ComboBox();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.lbl_clerk = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 764);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_clerk);
            this.panel1.Controls.Add(this.cmb_department);
            this.panel1.Controls.Add(this.cmb_position);
            this.panel1.Controls.Add(this.lbl_clerk);
            this.panel1.Controls.Add(this.lbl_department);
            this.panel1.Controls.Add(this.lbl_position);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 72);
            this.panel1.TabIndex = 1;
            // 
            // cmb_clerk
            // 
            this.cmb_clerk.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_clerk.FormattingEnabled = true;
            this.cmb_clerk.Location = new System.Drawing.Point(305, 21);
            this.cmb_clerk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_clerk.Name = "cmb_clerk";
            this.cmb_clerk.Size = new System.Drawing.Size(145, 31);
            this.cmb_clerk.TabIndex = 18;
            // 
            // cmb_department
            // 
            this.cmb_department.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(537, 21);
            this.cmb_department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(121, 31);
            this.cmb_department.TabIndex = 17;
            // 
            // cmb_position
            // 
            this.cmb_position.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Location = new System.Drawing.Point(87, 21);
            this.cmb_position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(121, 31);
            this.cmb_position.TabIndex = 16;
            // 
            // lbl_clerk
            // 
            this.lbl_clerk.AutoSize = true;
            this.lbl_clerk.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_clerk.Location = new System.Drawing.Point(215, 25);
            this.lbl_clerk.Name = "lbl_clerk";
            this.lbl_clerk.Size = new System.Drawing.Size(80, 24);
            this.lbl_clerk.TabIndex = 15;
            this.lbl_clerk.Text = "店舗ID";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_department.Location = new System.Drawing.Point(469, 25);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(58, 24);
            this.lbl_department.TabIndex = 14;
            this.lbl_department.Text = "部署";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_position.Location = new System.Drawing.Point(19, 25);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(58, 24);
            this.lbl_position.TabIndex = 13;
            this.lbl_position.Text = "役職";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_search.Location = new System.Drawing.Point(1000, 11);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(136, 51);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_id.Location = new System.Drawing.Point(772, 21);
            this.txt_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(207, 30);
            this.txt_id.TabIndex = 11;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_id.Location = new System.Drawing.Point(681, 25);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(80, 24);
            this.lbl_id.TabIndex = 10;
            this.lbl_id.Text = "社員ID";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 692);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1136, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 692);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(13, 752);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1123, 12);
            this.panel4.TabIndex = 4;
            // 
            // List_of_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "List_of_employees";
            this.Size = new System.Drawing.Size(1149, 764);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_clerk;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.Label lbl_clerk;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
