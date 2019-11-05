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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textB_shopID = new System.Windows.Forms.TextBox();
            this.textB_position = new System.Windows.Forms.TextBox();
            this.textB_dept = new System.Windows.Forms.TextBox();
            this.comboB_sex = new System.Windows.Forms.ComboBox();
            this.textB_tell = new System.Windows.Forms.TextBox();
            this.textB_post = new System.Windows.Forms.TextBox();
            this.textB_address = new System.Windows.Forms.TextBox();
            this.textB_ename = new System.Windows.Forms.TextBox();
            this.textB_enameID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emp_name
            // 
            this.emp_name.AutoSize = true;
            this.emp_name.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emp_name.Location = new System.Drawing.Point(94, 119);
            this.emp_name.Name = "emp_name";
            this.emp_name.Size = new System.Drawing.Size(110, 28);
            this.emp_name.TabIndex = 1;
            this.emp_name.Text = "社員名：";
            // 
            // emp_address
            // 
            this.emp_address.AutoSize = true;
            this.emp_address.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emp_address.Location = new System.Drawing.Point(122, 175);
            this.emp_address.Name = "emp_address";
            this.emp_address.Size = new System.Drawing.Size(82, 28);
            this.emp_address.TabIndex = 2;
            this.emp_address.Text = "住所：";
            // 
            // emp_tell
            // 
            this.emp_tell.AutoSize = true;
            this.emp_tell.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emp_tell.Location = new System.Drawing.Point(66, 287);
            this.emp_tell.Name = "emp_tell";
            this.emp_tell.Size = new System.Drawing.Size(138, 28);
            this.emp_tell.TabIndex = 3;
            this.emp_tell.Text = "電話番号：";
            // 
            // emp_sex
            // 
            this.emp_sex.AutoSize = true;
            this.emp_sex.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emp_sex.Location = new System.Drawing.Point(122, 340);
            this.emp_sex.Name = "emp_sex";
            this.emp_sex.Size = new System.Drawing.Size(82, 28);
            this.emp_sex.TabIndex = 4;
            this.emp_sex.Text = "性別：";
            // 
            // emp_department
            // 
            this.emp_department.AutoSize = true;
            this.emp_department.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emp_department.Location = new System.Drawing.Point(122, 397);
            this.emp_department.Name = "emp_department";
            this.emp_department.Size = new System.Drawing.Size(82, 28);
            this.emp_department.TabIndex = 5;
            this.emp_department.Text = "部署：";
            // 
            // emp_job
            // 
            this.emp_job.AutoSize = true;
            this.emp_job.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.emp_job.Location = new System.Drawing.Point(122, 453);
            this.emp_job.Name = "emp_job";
            this.emp_job.Size = new System.Drawing.Size(82, 28);
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
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textB_shopID);
            this.groupBox1.Controls.Add(this.textB_position);
            this.groupBox1.Controls.Add(this.textB_dept);
            this.groupBox1.Controls.Add(this.comboB_sex);
            this.groupBox1.Controls.Add(this.textB_tell);
            this.groupBox1.Controls.Add(this.textB_post);
            this.groupBox1.Controls.Add(this.textB_address);
            this.groupBox1.Controls.Add(this.textB_ename);
            this.groupBox1.Controls.Add(this.textB_enameID);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(94, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "社員ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(94, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "店舗ID：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(66, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "郵便番号：";
            // 
            // textB_shopID
            // 
            this.textB_shopID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_shopID.Location = new System.Drawing.Point(236, 503);
            this.textB_shopID.Name = "textB_shopID";
            this.textB_shopID.Size = new System.Drawing.Size(611, 37);
            this.textB_shopID.TabIndex = 15;
            // 
            // textB_position
            // 
            this.textB_position.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_position.Location = new System.Drawing.Point(236, 447);
            this.textB_position.Name = "textB_position";
            this.textB_position.Size = new System.Drawing.Size(611, 37);
            this.textB_position.TabIndex = 14;
            // 
            // textB_dept
            // 
            this.textB_dept.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_dept.Location = new System.Drawing.Point(236, 391);
            this.textB_dept.Name = "textB_dept";
            this.textB_dept.Size = new System.Drawing.Size(611, 37);
            this.textB_dept.TabIndex = 13;
            // 
            // comboB_sex
            // 
            this.comboB_sex.FormattingEnabled = true;
            this.comboB_sex.Location = new System.Drawing.Point(236, 337);
            this.comboB_sex.Name = "comboB_sex";
            this.comboB_sex.Size = new System.Drawing.Size(121, 35);
            this.comboB_sex.TabIndex = 12;
            // 
            // textB_tell
            // 
            this.textB_tell.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_tell.Location = new System.Drawing.Point(236, 281);
            this.textB_tell.Name = "textB_tell";
            this.textB_tell.Size = new System.Drawing.Size(611, 37);
            this.textB_tell.TabIndex = 11;
            // 
            // textB_post
            // 
            this.textB_post.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_post.Location = new System.Drawing.Point(236, 225);
            this.textB_post.Name = "textB_post";
            this.textB_post.Size = new System.Drawing.Size(611, 37);
            this.textB_post.TabIndex = 10;
            // 
            // textB_address
            // 
            this.textB_address.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_address.Location = new System.Drawing.Point(236, 169);
            this.textB_address.Name = "textB_address";
            this.textB_address.Size = new System.Drawing.Size(611, 37);
            this.textB_address.TabIndex = 9;
            // 
            // textB_ename
            // 
            this.textB_ename.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_ename.Location = new System.Drawing.Point(236, 113);
            this.textB_ename.Name = "textB_ename";
            this.textB_ename.Size = new System.Drawing.Size(611, 37);
            this.textB_ename.TabIndex = 8;
            // 
            // textB_enameID
            // 
            this.textB_enameID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_enameID.Location = new System.Drawing.Point(236, 57);
            this.textB_enameID.Name = "textB_enameID";
            this.textB_enameID.Size = new System.Drawing.Size(611, 37);
            this.textB_enameID.TabIndex = 7;
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
        private System.Windows.Forms.TextBox textB_shopID;
        private System.Windows.Forms.TextBox textB_position;
        private System.Windows.Forms.TextBox textB_dept;
        private System.Windows.Forms.ComboBox comboB_sex;
        private System.Windows.Forms.TextBox textB_tell;
        private System.Windows.Forms.TextBox textB_post;
        private System.Windows.Forms.TextBox textB_address;
        private System.Windows.Forms.TextBox textB_ename;
        private System.Windows.Forms.TextBox textB_enameID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
