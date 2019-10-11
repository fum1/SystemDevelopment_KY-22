namespace SystemDev_KY_22
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PictB_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_login.Location = new System.Drawing.Point(259, 385);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(316, 62);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "注文履歴";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(259, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(316, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "売上確認";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(182, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "管理者用メインメニュー";
            // 
            // PictB_Logo
            // 
            this.PictB_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PictB_Logo.Image = global::SystemDev_KY_22.Properties.Resources.チェリー;
            this.PictB_Logo.Location = new System.Drawing.Point(115, 52);
            this.PictB_Logo.Name = "PictB_Logo";
            this.PictB_Logo.Size = new System.Drawing.Size(651, 212);
            this.PictB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictB_Logo.TabIndex = 1;
            this.PictB_Logo.TabStop = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.PictB_Logo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            ((System.ComponentModel.ISupportInitialize)(this.PictB_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictB_Logo;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}