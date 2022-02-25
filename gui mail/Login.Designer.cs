
namespace gui_mail
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TxtGetInfo = new System.Windows.Forms.Button();
            this.TxtKey = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGetKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtGetInfo
            // 
            this.TxtGetInfo.Location = new System.Drawing.Point(51, 181);
            this.TxtGetInfo.Name = "TxtGetInfo";
            this.TxtGetInfo.Size = new System.Drawing.Size(73, 52);
            this.TxtGetInfo.TabIndex = 0;
            this.TxtGetInfo.Text = "Login";
            this.TxtGetInfo.UseVisualStyleBackColor = true;
            this.TxtGetInfo.Click += new System.EventHandler(this.TxtGetInfo_Click);
            // 
            // TxtKey
            // 
            this.TxtKey.Location = new System.Drawing.Point(19, 28);
            this.TxtKey.Multiline = true;
            this.TxtKey.Name = "TxtKey";
            this.TxtKey.Size = new System.Drawing.Size(283, 147);
            this.TxtKey.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGetKey);
            this.groupBox1.Controls.Add(this.TxtKey);
            this.groupBox1.Controls.Add(this.TxtGetInfo);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 253);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // BtnGetKey
            // 
            this.BtnGetKey.Location = new System.Drawing.Point(188, 181);
            this.BtnGetKey.Name = "BtnGetKey";
            this.BtnGetKey.Size = new System.Drawing.Size(73, 52);
            this.BtnGetKey.TabIndex = 2;
            this.BtnGetKey.Text = "GetKey";
            this.BtnGetKey.UseVisualStyleBackColor = true;
            this.BtnGetKey.Click += new System.EventHandler(this.BtnGetKey_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 287);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TxtGetInfo;
        private System.Windows.Forms.TextBox TxtKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnGetKey;
    }
}