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
            this.PictB_Logo = new System.Windows.Forms.PictureBox();
            this.textB_id = new System.Windows.Forms.TextBox();
            this.MaskedTextB_PassWord = new System.Windows.Forms.MaskedTextBox();
            this.lB_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictB_Logo
            // 
            this.PictB_Logo.Image = global::SystemDev_KY_22.Properties.Resources.チェリー;
            this.PictB_Logo.Location = new System.Drawing.Point(172, 62);
            this.PictB_Logo.Name = "PictB_Logo";
            this.PictB_Logo.Size = new System.Drawing.Size(664, 230);
            this.PictB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictB_Logo.TabIndex = 0;
            this.PictB_Logo.TabStop = false;
            // 
            // textB_id
            // 
            this.textB_id.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textB_id.Location = new System.Drawing.Point(378, 330);
            this.textB_id.Name = "textB_id";
            this.textB_id.Size = new System.Drawing.Size(465, 54);
            this.textB_id.TabIndex = 1;
            // 
            // MaskedTextB_PassWord
            // 
            this.MaskedTextB_PassWord.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaskedTextB_PassWord.Location = new System.Drawing.Point(378, 430);
            this.MaskedTextB_PassWord.Name = "MaskedTextB_PassWord";
            this.MaskedTextB_PassWord.Size = new System.Drawing.Size(465, 54);
            this.MaskedTextB_PassWord.TabIndex = 2;
            // 
            // lB_ID
            // 
            this.lB_ID.AutoSize = true;
            this.lB_ID.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lB_ID.Location = new System.Drawing.Point(166, 333);
            this.lB_ID.Name = "lB_ID";
            this.lB_ID.Size = new System.Drawing.Size(159, 48);
            this.lB_ID.TabIndex = 3;
            this.lB_ID.Text = "社員ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(137, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "パスワード";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lB_ID);
            this.Controls.Add(this.MaskedTextB_PassWord);
            this.Controls.Add(this.textB_id);
            this.Controls.Add(this.PictB_Logo);
            this.Name = "Login";
            this.Text = "ログイン";
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
    }
}

