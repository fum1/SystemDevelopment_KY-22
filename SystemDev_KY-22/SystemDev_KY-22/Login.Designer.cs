namespace SystemDev_KY_22
{
    partial class Login
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textB_id = new System.Windows.Forms.TextBox();
            this.MaskedTextB_PassWord = new System.Windows.Forms.MaskedTextBox();
            this.lB_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lB_Close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textB_id
            // 
            this.textB_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textB_id.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_id.Location = new System.Drawing.Point(28, 71);
            this.textB_id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textB_id.Name = "textB_id";
            this.textB_id.Size = new System.Drawing.Size(284, 38);
            this.textB_id.TabIndex = 1;
            this.textB_id.TextChanged += new System.EventHandler(this.TextB_id_TextChanged);
            // 
            // MaskedTextB_PassWord
            // 
            this.MaskedTextB_PassWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaskedTextB_PassWord.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaskedTextB_PassWord.Location = new System.Drawing.Point(28, 168);
            this.MaskedTextB_PassWord.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaskedTextB_PassWord.Name = "MaskedTextB_PassWord";
            this.MaskedTextB_PassWord.PasswordChar = '*';
            this.MaskedTextB_PassWord.Size = new System.Drawing.Size(284, 38);
            this.MaskedTextB_PassWord.TabIndex = 2;
            this.MaskedTextB_PassWord.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextB_PassWord_MaskInputRejected);
            // 
            // lB_ID
            // 
            this.lB_ID.AutoSize = true;
            this.lB_ID.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lB_ID.Location = new System.Drawing.Point(25, 50);
            this.lB_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lB_ID.Name = "lB_ID";
            this.lB_ID.Size = new System.Drawing.Size(58, 18);
            this.lB_ID.TabIndex = 3;
            this.lB_ID.Text = "社員ID";
            this.lB_ID.Click += new System.EventHandler(this.LB_ID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(25, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "パスワード";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("UD デジタル 教科書体 NK-R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_login.Location = new System.Drawing.Point(95, 282);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(153, 37);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "ログイン";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // lB_Close
            // 
            this.lB_Close.AutoSize = true;
            this.lB_Close.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lB_Close.Location = new System.Drawing.Point(737, 6);
            this.lB_Close.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lB_Close.Name = "lB_Close";
            this.lB_Close.Size = new System.Drawing.Size(29, 27);
            this.lB_Close.TabIndex = 7;
            this.lB_Close.Text = "X";
            this.lB_Close.Click += new System.EventHandler(this.LB_Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(28, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(28, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.textB_id);
            this.panel4.Controls.Add(this.lB_ID);
            this.panel4.Controls.Add(this.btn_login);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.MaskedTextB_PassWord);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 203);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(344, 350);
            this.panel4.TabIndex = 10;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SystemDev_KY_22.Properties.Resources.チェリー;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(302, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(30, 29);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "X";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SystemDev_KY_22.Properties.Resources.backgrounds_001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(344, 553);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lB_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログイン";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textB_id;
        private System.Windows.Forms.MaskedTextBox MaskedTextB_PassWord;
        private System.Windows.Forms.Label lB_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lB_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

