﻿namespace SystemDev_KY_22
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
            this.PictB_Logo = new System.Windows.Forms.PictureBox();
            this.textB_id = new System.Windows.Forms.TextBox();
            this.MaskedTextB_PassWord = new System.Windows.Forms.MaskedTextBox();
            this.lB_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictB_Logo
            // 
            this.PictB_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictB_Logo.Image = global::SystemDev_KY_22.Properties.Resources.チェリー;
            this.PictB_Logo.Location = new System.Drawing.Point(218, 52);
            this.PictB_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.PictB_Logo.Name = "PictB_Logo";
            this.PictB_Logo.Size = new System.Drawing.Size(830, 276);
            this.PictB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictB_Logo.TabIndex = 0;
            this.PictB_Logo.TabStop = false;
            this.PictB_Logo.Click += new System.EventHandler(this.PictB_Logo_Click);
            // 
            // textB_id
            // 
            this.textB_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textB_id.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_id.Location = new System.Drawing.Point(472, 377);
            this.textB_id.Margin = new System.Windows.Forms.Padding(4);
            this.textB_id.Name = "textB_id";
            this.textB_id.Size = new System.Drawing.Size(580, 64);
            this.textB_id.TabIndex = 1;
            this.textB_id.TextChanged += new System.EventHandler(this.TextB_id_TextChanged);
            // 
            // MaskedTextB_PassWord
            // 
            this.MaskedTextB_PassWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskedTextB_PassWord.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaskedTextB_PassWord.Location = new System.Drawing.Point(472, 497);
            this.MaskedTextB_PassWord.Margin = new System.Windows.Forms.Padding(4);
            this.MaskedTextB_PassWord.Name = "MaskedTextB_PassWord";
            this.MaskedTextB_PassWord.Size = new System.Drawing.Size(580, 64);
            this.MaskedTextB_PassWord.TabIndex = 2;
            this.MaskedTextB_PassWord.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MaskedTextB_PassWord_MaskInputRejected);
            // 
            // lB_ID
            // 
            this.lB_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lB_ID.AutoSize = true;
            this.lB_ID.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lB_ID.Location = new System.Drawing.Point(208, 377);
            this.lB_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lB_ID.Name = "lB_ID";
            this.lB_ID.Size = new System.Drawing.Size(190, 57);
            this.lB_ID.TabIndex = 3;
            this.lB_ID.Text = "社員ID";
            this.lB_ID.Click += new System.EventHandler(this.LB_ID_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(165, 504);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "パスワード";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_login.Location = new System.Drawing.Point(653, 613);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(395, 74);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "ログイン";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(218, 613);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "キャンセル";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lB_ID);
            this.Controls.Add(this.MaskedTextB_PassWord);
            this.Controls.Add(this.textB_id);
            this.Controls.Add(this.PictB_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログイン";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictB_Logo;
        private System.Windows.Forms.TextBox textB_id;
        private System.Windows.Forms.MaskedTextBox MaskedTextB_PassWord;
        private System.Windows.Forms.Label lB_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button1;
    }
}

