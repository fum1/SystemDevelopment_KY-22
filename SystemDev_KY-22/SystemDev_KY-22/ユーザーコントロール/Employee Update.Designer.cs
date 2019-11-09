namespace SystemDev_KY_22.ユーザーコントロール
{
    partial class Employee_Update
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            this.lbl_clerk = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_postal = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.cmb_sex = new System.Windows.Forms.ComboBox();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.cmb_position = new System.Windows.Forms.ComboBox();
            this.cmb_clerk = new System.Windows.Forms.ComboBox();
            this.lbl_postal = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(167, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "社員ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(720, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "検索";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(321, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 50);
            this.textBox1.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_name.Location = new System.Drawing.Point(179, 61);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(73, 30);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "氏名";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_address.Location = new System.Drawing.Point(179, 153);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(73, 30);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "住所";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_tel.Location = new System.Drawing.Point(119, 199);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(133, 30);
            this.lbl_tel.TabIndex = 5;
            this.lbl_tel.Text = "電話番号";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_sex.Location = new System.Drawing.Point(179, 245);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(73, 30);
            this.lbl_sex.TabIndex = 6;
            this.lbl_sex.Text = "性別";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_department.Location = new System.Drawing.Point(179, 291);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(73, 30);
            this.lbl_department.TabIndex = 7;
            this.lbl_department.Text = "部署";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_position.Location = new System.Drawing.Point(179, 337);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(73, 30);
            this.lbl_position.TabIndex = 8;
            this.lbl_position.Text = "役職";
            // 
            // lbl_clerk
            // 
            this.lbl_clerk.AutoSize = true;
            this.lbl_clerk.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_clerk.Location = new System.Drawing.Point(153, 383);
            this.lbl_clerk.Name = "lbl_clerk";
            this.lbl_clerk.Size = new System.Drawing.Size(99, 30);
            this.lbl_clerk.TabIndex = 9;
            this.lbl_clerk.Text = "店舗ID";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_name.Location = new System.Drawing.Point(258, 57);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(191, 34);
            this.txt_name.TabIndex = 10;
            // 
            // txt_postal
            // 
            this.txt_postal.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_postal.Location = new System.Drawing.Point(258, 107);
            this.txt_postal.Name = "txt_postal";
            this.txt_postal.Size = new System.Drawing.Size(191, 34);
            this.txt_postal.TabIndex = 11;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_address.Location = new System.Drawing.Point(258, 153);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(640, 34);
            this.txt_address.TabIndex = 12;
            // 
            // cmb_sex
            // 
            this.cmb_sex.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_sex.FormattingEnabled = true;
            this.cmb_sex.Location = new System.Drawing.Point(258, 245);
            this.cmb_sex.Name = "cmb_sex";
            this.cmb_sex.Size = new System.Drawing.Size(74, 35);
            this.cmb_sex.TabIndex = 17;
            // 
            // cmb_department
            // 
            this.cmb_department.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(258, 291);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(136, 35);
            this.cmb_department.TabIndex = 18;
            // 
            // cmb_position
            // 
            this.cmb_position.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_position.FormattingEnabled = true;
            this.cmb_position.Location = new System.Drawing.Point(258, 337);
            this.cmb_position.Name = "cmb_position";
            this.cmb_position.Size = new System.Drawing.Size(136, 35);
            this.cmb_position.TabIndex = 19;
            // 
            // cmb_clerk
            // 
            this.cmb_clerk.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_clerk.FormattingEnabled = true;
            this.cmb_clerk.Location = new System.Drawing.Point(258, 383);
            this.cmb_clerk.Name = "cmb_clerk";
            this.cmb_clerk.Size = new System.Drawing.Size(136, 35);
            this.cmb_clerk.TabIndex = 20;
            // 
            // lbl_postal
            // 
            this.lbl_postal.AutoSize = true;
            this.lbl_postal.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_postal.Location = new System.Drawing.Point(119, 107);
            this.lbl_postal.Name = "lbl_postal";
            this.lbl_postal.Size = new System.Drawing.Size(133, 30);
            this.lbl_postal.TabIndex = 21;
            this.lbl_postal.Text = "郵便番号";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.White;
            this.groupBox.Controls.Add(this.txt_tel);
            this.groupBox.Controls.Add(this.lbl_name);
            this.groupBox.Controls.Add(this.lbl_postal);
            this.groupBox.Controls.Add(this.lbl_address);
            this.groupBox.Controls.Add(this.cmb_clerk);
            this.groupBox.Controls.Add(this.lbl_tel);
            this.groupBox.Controls.Add(this.cmb_position);
            this.groupBox.Controls.Add(this.lbl_sex);
            this.groupBox.Controls.Add(this.cmb_department);
            this.groupBox.Controls.Add(this.lbl_department);
            this.groupBox.Controls.Add(this.cmb_sex);
            this.groupBox.Controls.Add(this.lbl_position);
            this.groupBox.Controls.Add(this.txt_address);
            this.groupBox.Controls.Add(this.lbl_clerk);
            this.groupBox.Controls.Add(this.txt_postal);
            this.groupBox.Controls.Add(this.txt_name);
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(56, 142);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(934, 472);
            this.groupBox.TabIndex = 22;
            this.groupBox.TabStop = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_tel.Location = new System.Drawing.Point(258, 195);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(246, 34);
            this.txt_tel.TabIndex = 22;
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_update.Location = new System.Drawing.Point(835, 631);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(155, 50);
            this.btn_update.TabIndex = 23;
            this.btn_update.Text = "更新";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // Employee_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Employee_Update";
            this.Size = new System.Drawing.Size(1042, 703);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label lbl_clerk;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_postal;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox cmb_sex;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.ComboBox cmb_position;
        private System.Windows.Forms.ComboBox cmb_clerk;
        private System.Windows.Forms.Label lbl_postal;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Button btn_update;
    }
}
