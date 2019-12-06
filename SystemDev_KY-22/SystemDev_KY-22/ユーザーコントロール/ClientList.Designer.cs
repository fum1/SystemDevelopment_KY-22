namespace SystemDev_KY_22
{
    partial class ClientList
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
            this.dgv_clientlist = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbx_refine = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.txt_postalcode = new System.Windows.Forms.TextBox();
            this.lbl_postalcode = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_clientID = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.txt_clientID = new System.Windows.Forms.TextBox();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientlist)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbx_refine.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_clientlist
            // 
            this.dgv_clientlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_clientlist.Location = new System.Drawing.Point(0, 0);
            this.dgv_clientlist.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_clientlist.Name = "dgv_clientlist";
            this.dgv_clientlist.RowTemplate.Height = 24;
            this.dgv_clientlist.Size = new System.Drawing.Size(900, 448);
            this.dgv_clientlist.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbx_refine);
            this.panel2.Controls.Add(this.lbl_birthday);
            this.panel2.Controls.Add(this.dtp_birthday);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 113);
            this.panel2.TabIndex = 43;
            // 
            // gbx_refine
            // 
            this.gbx_refine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_refine.Controls.Add(this.btn_search);
            this.gbx_refine.Controls.Add(this.cmb_sex);
            this.gbx_refine.Controls.Add(this.txt_postalcode);
            this.gbx_refine.Controls.Add(this.lbl_postalcode);
            this.gbx_refine.Controls.Add(this.txt_id);
            this.gbx_refine.Controls.Add(this.lbl_clientID);
            this.gbx_refine.Controls.Add(this.txt_tel);
            this.gbx_refine.Controls.Add(this.lbl_tel);
            this.gbx_refine.Controls.Add(this.lbl_address);
            this.gbx_refine.Controls.Add(this.txt_address);
            this.gbx_refine.Controls.Add(this.lbl_name);
            this.gbx_refine.Controls.Add(this.lbl_sex);
            this.gbx_refine.Controls.Add(this.txt_clientID);
            this.gbx_refine.Location = new System.Drawing.Point(68, -1);
            this.gbx_refine.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_refine.Name = "gbx_refine";
            this.gbx_refine.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_refine.Size = new System.Drawing.Size(764, 115);
            this.gbx_refine.TabIndex = 48;
            this.gbx_refine.TabStop = false;
            this.gbx_refine.Text = "絞り込み";
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 13.8F);
            this.btn_search.Location = new System.Drawing.Point(641, 29);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(110, 54);
            this.btn_search.TabIndex = 69;
            this.btn_search.Text = "検索";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // cmb_sex
            // 
            this.cmb_sex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_sex.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Items.AddRange(new object[] {
            "男性",
            "女性"});
            this.cmb_sex.Location = new System.Drawing.Point(665, 17);
            this.cmb_sex.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(161, 24);
            this.cmb_sex.TabIndex = 68;
            // 
            // txt_postalcode
            // 
            this.txt_postalcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_postalcode.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_postalcode.Location = new System.Drawing.Point(76, 61);
            this.txt_postalcode.Name = "txt_postalcode";
            this.txt_postalcode.Size = new System.Drawing.Size(218, 23);
            this.txt_postalcode.TabIndex = 67;
            // 
            // lbl_postalcode
            // 
            this.lbl_postalcode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_postalcode.AutoSize = true;
            this.lbl_postalcode.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_postalcode.Location = new System.Drawing.Point(-15, 60);
            this.lbl_postalcode.Name = "lbl_postalcode";
            this.lbl_postalcode.Size = new System.Drawing.Size(95, 19);
            this.lbl_postalcode.TabIndex = 66;
            this.lbl_postalcode.Text = "郵便番号：";
            // 
            // txt_id
            // 
            this.txt_id.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_id.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_id.Location = new System.Drawing.Point(369, 16);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(218, 23);
            this.txt_id.TabIndex = 65;
            // 
            // lbl_clientID
            // 
            this.lbl_clientID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_clientID.AutoSize = true;
            this.lbl_clientID.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_clientID.Location = new System.Drawing.Point(4, 14);
            this.lbl_clientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_clientID.Name = "lbl_clientID";
            this.lbl_clientID.Size = new System.Drawing.Size(74, 19);
            this.lbl_clientID.TabIndex = 64;
            this.lbl_clientID.Text = "顧客ID：";
            // 
            // txt_tel
            // 
            this.txt_tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_tel.Location = new System.Drawing.Point(661, 66);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(165, 23);
            this.txt_tel.TabIndex = 63;
            // 
            // lbl_tel
            // 
            this.lbl_tel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_tel.Location = new System.Drawing.Point(613, 66);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(45, 19);
            this.lbl_tel.TabIndex = 62;
            this.lbl_tel.Text = "TEL:";
            // 
            // lbl_address
            // 
            this.lbl_address.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_address.Location = new System.Drawing.Point(316, 61);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(51, 19);
            this.lbl_address.TabIndex = 61;
            this.lbl_address.Text = "住所:";
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_address.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_address.Location = new System.Drawing.Point(369, 60);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(218, 23);
            this.txt_address.TabIndex = 60;
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_name.Location = new System.Drawing.Point(316, 14);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 19);
            this.lbl_name.TabIndex = 58;
            this.lbl_name.Text = "氏名:";
            // 
            // lbl_sex
            // 
            this.lbl_sex.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_sex.Location = new System.Drawing.Point(613, 17);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(51, 19);
            this.lbl_sex.TabIndex = 59;
            this.lbl_sex.Text = "性別:";
            // 
            // txt_clientID
            // 
            this.txt_clientID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_clientID.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_clientID.Location = new System.Drawing.Point(76, 14);
            this.txt_clientID.Name = "txt_clientID";
            this.txt_clientID.Size = new System.Drawing.Size(218, 23);
            this.txt_clientID.TabIndex = 57;
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.lbl_birthday.Location = new System.Drawing.Point(509, 18);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(111, 24);
            this.lbl_birthday.TabIndex = 46;
            this.lbl_birthday.Text = "生年月日:";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.CalendarFont = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_birthday.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.dtp_birthday.Location = new System.Drawing.Point(626, 13);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(218, 31);
            this.dtp_birthday.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(892, 113);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 335);
            this.panel3.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 335);
            this.panel1.TabIndex = 45;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(8, 438);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 10);
            this.panel4.TabIndex = 46;
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_clientlist);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientList";
            this.Size = new System.Drawing.Size(900, 448);
            this.Load += new System.EventHandler(this.ClientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientlist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbx_refine.ResumeLayout(false);
            this.gbx_refine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_clientlist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gbx_refine;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.TextBox txt_postalcode;
        private System.Windows.Forms.Label lbl_postalcode;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_clientID;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.TextBox txt_clientID;
    }
}
