namespace SystemDev_KY_22
{
    partial class EmpRegister
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
            this.emp_name = new System.Windows.Forms.Label();
            this.emp_address = new System.Windows.Forms.Label();
            this.emp_tell = new System.Windows.Forms.Label();
            this.emp_sex = new System.Windows.Forms.Label();
            this.emp_department = new System.Windows.Forms.Label();
            this.emp_job = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_name
            // 
            this.emp_name.AutoSize = true;
            this.emp_name.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.emp_name.Location = new System.Drawing.Point(65, 82);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(165, 42);
            this.emp_name.TabIndex = 1;
            this.emp_name.Text = "社員名：";
            // 
            // emp_address
            // 
            this.emp_address.AutoSize = true;
            this.emp_address.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.emp_address.Location = new System.Drawing.Point(107, 250);
            this.emp_address.Name = "emp_address";
            this.emp_address.Size = new System.Drawing.Size(123, 42);
            this.emp_address.TabIndex = 2;
            this.emp_address.Text = "住所：";
            // 
            // emp_tell
            // 
            this.emp_tell.AutoSize = true;
            this.emp_tell.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.emp_tell.Location = new System.Drawing.Point(23, 502);
            this.emp_tell.Name = "emp_tell";
            this.emp_tell.Size = new System.Drawing.Size(207, 42);
            this.emp_tell.TabIndex = 3;
            this.emp_tell.Text = "電話番号：";
            // 
            // emp_sex
            // 
            this.emp_sex.AutoSize = true;
            this.emp_sex.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.emp_sex.Location = new System.Drawing.Point(107, 166);
            this.emp_sex.Name = "emp_sex";
            this.emp_sex.Size = new System.Drawing.Size(123, 42);
            this.emp_sex.TabIndex = 4;
            this.emp_sex.Text = "性別：";
            // 
            // emp_department
            // 
            this.emp_department.AutoSize = true;
            this.emp_department.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.emp_department.Location = new System.Drawing.Point(107, 418);
            this.emp_department.Name = "emp_department";
            this.emp_department.Size = new System.Drawing.Size(123, 42);
            this.emp_department.TabIndex = 5;
            this.emp_department.Text = "部署：";
            // 
            // emp_job
            // 
            this.emp_job.AutoSize = true;
            this.emp_job.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.emp_job.Location = new System.Drawing.Point(107, 334);
            this.emp_job.Name = "emp_job";
            this.emp_job.Size = new System.Drawing.Size(123, 42);
            this.emp_job.TabIndex = 6;
            this.emp_job.Text = "役職：";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("MS UI Gothic", 19.8F);
            this.btn_login.Location = new System.Drawing.Point(321, 598);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(395, 74);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "登録";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.emp_tell);
            this.groupBox1.Controls.Add(this.emp_name);
            this.groupBox1.Controls.Add(this.emp_address);
            this.groupBox1.Controls.Add(this.emp_job);
            this.groupBox1.Controls.Add(this.emp_sex);
            this.groupBox1.Controls.Add(this.emp_department);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F);
            this.groupBox1.Location = new System.Drawing.Point(21, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(999, 659);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "社員登録画面";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(237, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 54);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(519, 75);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 54);
            this.textBox2.TabIndex = 10;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton1.Location = new System.Drawing.Point(237, 166);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(118, 44);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男性";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton2.Location = new System.Drawing.Point(519, 166);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 44);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女性";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(237, 243);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(556, 54);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox4.Location = new System.Drawing.Point(237, 327);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(556, 54);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox5.Location = new System.Drawing.Point(237, 411);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(556, 54);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox6.Location = new System.Drawing.Point(237, 495);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(556, 54);
            this.textBox6.TabIndex = 21;
            // 
            // EmpRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmpRegister";
            this.Size = new System.Drawing.Size(1042, 703);
            this.Load += new System.EventHandler(this.EmpRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label emp_name;
        private System.Windows.Forms.Label emp_address;
        private System.Windows.Forms.Label emp_tell;
        private System.Windows.Forms.Label emp_sex;
        private System.Windows.Forms.Label emp_department;
        private System.Windows.Forms.Label emp_job;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}
