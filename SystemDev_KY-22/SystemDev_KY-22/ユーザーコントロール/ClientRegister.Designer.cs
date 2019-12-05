namespace SystemDev_KY_22
{
    partial class ClientRegister
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.txt_pos = new System.Windows.Forms.TextBox();
            this.lbl_pos = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btn_clear);
            this.groupBox.Controls.Add(this.cmb_sex);
            this.groupBox.Controls.Add(this.txt_pos);
            this.groupBox.Controls.Add(this.lbl_pos);
            this.groupBox.Controls.Add(this.txt_id);
            this.groupBox.Controls.Add(this.lbl_id);
            this.groupBox.Controls.Add(this.btn_login);
            this.groupBox.Controls.Add(this.txt_tel);
            this.groupBox.Controls.Add(this.lbl_tel);
            this.groupBox.Controls.Add(this.lbl_address);
            this.groupBox.Controls.Add(this.txt_address);
            this.groupBox.Controls.Add(this.lbl_birthday);
            this.groupBox.Controls.Add(this.dtp_birthday);
            this.groupBox.Controls.Add(this.lbl_name);
            this.groupBox.Controls.Add(this.lbl_sex);
            this.groupBox.Controls.Add(this.txt_name);
            this.groupBox.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox.Location = new System.Drawing.Point(22, 20);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(1275, 673);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "顧客情報";
            // 
            // cmb_sex
            // 
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Items.AddRange(new object[] {
            "男性",
            "女性"});
            this.cmb_sex.Location = new System.Drawing.Point(325, 241);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(213, 35);
            this.cmb_sex.TabIndex = 25;
            // 
            // txt_pos
            // 
            this.txt_pos.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_pos.Location = new System.Drawing.Point(325, 312);
            this.txt_pos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pos.Name = "txt_pos";
            this.txt_pos.Size = new System.Drawing.Size(383, 54);
            this.txt_pos.TabIndex = 24;
            this.txt_pos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pos_KeyDown);
            // 
            // lbl_pos
            // 
            this.lbl_pos.AutoSize = true;
            this.lbl_pos.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_pos.Location = new System.Drawing.Point(141, 312);
            this.lbl_pos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pos.Name = "lbl_pos";
            this.lbl_pos.Size = new System.Drawing.Size(236, 48);
            this.lbl_pos.TabIndex = 23;
            this.lbl_pos.Text = "郵便番号：";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_id.Location = new System.Drawing.Point(325, 61);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(383, 54);
            this.txt_id.TabIndex = 22;
            this.txt_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyDown);
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_id.Location = new System.Drawing.Point(183, 61);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(183, 48);
            this.lbl_id.TabIndex = 21;
            this.lbl_id.Text = "顧客ID：";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_login.Location = new System.Drawing.Point(149, 564);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(395, 74);
            this.btn_login.TabIndex = 19;
            this.btn_login.Text = "登録";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_tel.Location = new System.Drawing.Point(325, 482);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(497, 54);
            this.txt_tel.TabIndex = 18;
            this.txt_tel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tel_KeyDown);
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_tel.Location = new System.Drawing.Point(234, 482);
            this.lbl_tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(111, 48);
            this.lbl_tel.TabIndex = 17;
            this.lbl_tel.Text = "TEL:";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_address.Location = new System.Drawing.Point(223, 396);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(126, 48);
            this.lbl_address.TabIndex = 16;
            this.lbl_address.Text = "住所:";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_address.Location = new System.Drawing.Point(325, 395);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(768, 54);
            this.txt_address.TabIndex = 15;
            this.txt_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_address_KeyDown);
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_birthday.Location = new System.Drawing.Point(586, 229);
            this.lbl_birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(222, 48);
            this.lbl_birthday.TabIndex = 14;
            this.lbl_birthday.Text = "生年月日:";
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.CalendarFont = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_birthday.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtp_birthday.Location = new System.Drawing.Point(764, 229);
            this.dtp_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(308, 47);
            this.dtp_birthday.TabIndex = 13;
            this.dtp_birthday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_birthday_KeyDown);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_name.Location = new System.Drawing.Point(223, 147);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(126, 48);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "氏名:";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_sex.Location = new System.Drawing.Point(224, 228);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(126, 48);
            this.lbl_sex.TabIndex = 12;
            this.lbl_sex.Text = "性別:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_name.Location = new System.Drawing.Point(326, 147);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(383, 54);
            this.txt_name.TabIndex = 5;
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(571, 564);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(395, 74);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // ClientRegister
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox);
            this.Name = "ClientRegister";
            this.Size = new System.Drawing.Size(1314, 768);
            this.Load += new System.EventHandler(this.ClientRegister_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_pos;
        private System.Windows.Forms.Label lbl_pos;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.Button btn_clear;
    }
}
