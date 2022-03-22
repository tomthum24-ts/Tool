
namespace TachInfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnLoc = new System.Windows.Forms.Button();
            this.TxtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(10, 23);
            this.TxtInput.Multiline = true;
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(325, 355);
            this.TxtInput.TabIndex = 0;
            this.TxtInput.TextChanged += new System.EventHandler(this.TxtInput_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLoc);
            this.groupBox1.Controls.Add(this.TxtOutput);
            this.groupBox1.Controls.Add(this.TxtInput);
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnLoc
            // 
            this.BtnLoc.Location = new System.Drawing.Point(341, 125);
            this.BtnLoc.Name = "BtnLoc";
            this.BtnLoc.Size = new System.Drawing.Size(88, 45);
            this.BtnLoc.TabIndex = 2;
            this.BtnLoc.Text = "Lọc thông tin";
            this.BtnLoc.UseVisualStyleBackColor = true;
            this.BtnLoc.Click += new System.EventHandler(this.BtnLoc_Click);
            // 
            // TxtOutput
            // 
            this.TxtOutput.Location = new System.Drawing.Point(435, 28);
            this.TxtOutput.Multiline = true;
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(320, 349);
            this.TxtOutput.TabIndex = 1;
            this.TxtOutput.TextChanged += new System.EventHandler(this.TxtOutput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnLoc;
        private System.Windows.Forms.TextBox TxtOutput;
    }
}

