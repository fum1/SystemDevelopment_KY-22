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
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.lbl_name = new System.Windows.Forms.Label();
            this.rbtn_woman = new System.Windows.Forms.RadioButton();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.rbtn_man = new System.Windows.Forms.RadioButton();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btn_login);
            this.groupBox.Controls.Add(this.txt_tel);
            this.groupBox.Controls.Add(this.lbl_tel);
            this.groupBox.Controls.Add(this.lbl_address);
            this.groupBox.Controls.Add(this.txt_address);
            this.groupBox.Controls.Add(this.lbl_birthday);
            this.groupBox.Controls.Add(this.dtp_birthday);
            this.groupBox.Controls.Add(this.lbl_name);
            this.groupBox.Controls.Add(this.rbtn_woman);
            this.groupBox.Controls.Add(this.lbl_sex);
            this.groupBox.Controls.Add(this.rbtn_man);
            this.groupBox.Controls.Add(this.txt_id);
            this.groupBox.Controls.Add(this.txt_name);
            this.groupBox.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox.Location = new System.Drawing.Point(20, 20);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(1004, 645);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "顧客情報";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_login.Location = new System.Drawing.Point(308, 535);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(395, 74);
            this.btn_login.TabIndex = 19;
            this.btn_login.Text = "登録";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_tel.Location = new System.Drawing.Point(182, 449);
            this.txt_tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(774, 54);
            this.txt_tel.TabIndex = 18;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_tel.Location = new System.Drawing.Point(40, 449);
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
            this.lbl_address.Location = new System.Drawing.Point(29, 353);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(126, 48);
            this.lbl_address.TabIndex = 16;
            this.lbl_address.Text = "住所:";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_address.Location = new System.Drawing.Point(188, 350);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(768, 54);
            this.txt_address.TabIndex = 15;
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_birthday.Location = new System.Drawing.Point(8, 261);
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
            this.dtp_birthday.Location = new System.Drawing.Point(281, 263);
            this.dtp_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(675, 47);
            this.dtp_birthday.TabIndex = 13;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_name.Location = new System.Drawing.Point(8, 57);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(126, 48);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "氏名:";
            // 
            // rbtn_woman
            // 
            this.rbtn_woman.AutoSize = true;
            this.rbtn_woman.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbtn_woman.Location = new System.Drawing.Point(337, 168);
            this.rbtn_woman.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_woman.Name = "rbtn_woman";
            this.rbtn_woman.Size = new System.Drawing.Size(118, 44);
            this.rbtn_woman.TabIndex = 11;
            this.rbtn_woman.TabStop = true;
            this.rbtn_woman.Text = "女性";
            this.rbtn_woman.UseVisualStyleBackColor = true;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_sex.Location = new System.Drawing.Point(29, 163);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(126, 48);
            this.lbl_sex.TabIndex = 12;
            this.lbl_sex.Text = "性別:";
            // 
            // rbtn_man
            // 
            this.rbtn_man.AutoSize = true;
            this.rbtn_man.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rbtn_man.Location = new System.Drawing.Point(188, 168);
            this.rbtn_man.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_man.Name = "rbtn_man";
            this.rbtn_man.Size = new System.Drawing.Size(118, 44);
            this.rbtn_man.TabIndex = 10;
            this.rbtn_man.TabStop = true;
            this.rbtn_man.Text = "男性";
            this.rbtn_man.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_id.Location = new System.Drawing.Point(182, 68);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(383, 54);
            this.txt_id.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_name.Location = new System.Drawing.Point(573, 68);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(383, 54);
            this.txt_name.TabIndex = 8;
            // 
            // ClientRegister
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox);
            this.Name = "ClientRegister";
            this.Size = new System.Drawing.Size(1042, 703);
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
        private System.Windows.Forms.RadioButton rbtn_woman;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.RadioButton rbtn_man;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
    }
}
