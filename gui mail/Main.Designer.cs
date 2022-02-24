
namespace gui_mail
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NbThread = new System.Windows.Forms.NumericUpDown();
            this.TxtSoluongmail = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.LbThatbai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbThanhcong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtContent = new System.Windows.Forms.TextBox();
            this.TxtTieude = new System.Windows.Forms.TextBox();
            this.TxtMailNhan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnOpenloi = new System.Windows.Forms.Button();
            this.BtnDeleteAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtPassWord = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.BTcheck = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddMultiMail = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdYahoo = new System.Windows.Forms.RadioButton();
            this.RdOutlook = new System.Windows.Forms.RadioButton();
            this.RdGmail = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TxtChuDe = new System.Windows.Forms.TextBox();
            this.TxtNoiDung = new System.Windows.Forms.TextBox();
            this.BtnAddContent = new System.Windows.Forms.Button();
            this.BtnDelConTent = new System.Windows.Forms.Button();
            this.CBTuDong = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbThread)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoluongmail)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CBTuDong);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.NbThread);
            this.groupBox1.Controls.Add(this.TxtSoluongmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LbThatbai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LbThanhcong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtContent);
            this.groupBox1.Controls.Add(this.TxtTieude);
            this.groupBox1.Controls.Add(this.TxtMailNhan);
            this.groupBox1.Location = new System.Drawing.Point(18, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(414, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gửi mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Số Thread";
            // 
            // NbThread
            // 
            this.NbThread.Location = new System.Drawing.Point(300, 32);
            this.NbThread.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NbThread.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NbThread.Name = "NbThread";
            this.NbThread.Size = new System.Drawing.Size(62, 20);
            this.NbThread.TabIndex = 12;
            this.NbThread.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TxtSoluongmail
            // 
            this.TxtSoluongmail.Location = new System.Drawing.Point(105, 32);
            this.TxtSoluongmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSoluongmail.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TxtSoluongmail.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TxtSoluongmail.Name = "TxtSoluongmail";
            this.TxtSoluongmail.Size = new System.Drawing.Size(49, 20);
            this.TxtSoluongmail.TabIndex = 11;
            this.TxtSoluongmail.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lần lặp lại";
            // 
            // LbThatbai
            // 
            this.LbThatbai.AutoSize = true;
            this.LbThatbai.Location = new System.Drawing.Point(86, 388);
            this.LbThatbai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbThatbai.Name = "LbThatbai";
            this.LbThatbai.Size = new System.Drawing.Size(13, 13);
            this.LbThatbai.TabIndex = 1;
            this.LbThatbai.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 388);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Gửi thất bại";
            // 
            // LbThanhcong
            // 
            this.LbThanhcong.AutoSize = true;
            this.LbThanhcong.Location = new System.Drawing.Point(86, 366);
            this.LbThanhcong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbThanhcong.Name = "LbThanhcong";
            this.LbThanhcong.Size = new System.Drawing.Size(13, 13);
            this.LbThanhcong.TabIndex = 8;
            this.LbThanhcong.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email đã gửi";
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(307, 366);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(2);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(55, 28);
            this.BtnStop.TabIndex = 6;
            this.BtnStop.Text = "Dừng";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Gửi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nội dung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiêu đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mail Nhận";
            // 
            // TxtContent
            // 
            this.TxtContent.Location = new System.Drawing.Point(74, 237);
            this.TxtContent.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContent.Multiline = true;
            this.TxtContent.Name = "TxtContent";
            this.TxtContent.Size = new System.Drawing.Size(288, 109);
            this.TxtContent.TabIndex = 4;
            // 
            // TxtTieude
            // 
            this.TxtTieude.Location = new System.Drawing.Point(74, 186);
            this.TxtTieude.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTieude.Name = "TxtTieude";
            this.TxtTieude.Size = new System.Drawing.Size(288, 20);
            this.TxtTieude.TabIndex = 3;
            // 
            // TxtMailNhan
            // 
            this.TxtMailNhan.Location = new System.Drawing.Point(74, 120);
            this.TxtMailNhan.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMailNhan.Multiline = true;
            this.TxtMailNhan.Name = "TxtMailNhan";
            this.TxtMailNhan.Size = new System.Drawing.Size(288, 31);
            this.TxtMailNhan.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.BtnOpenloi);
            this.groupBox2.Controls.Add(this.BtnDeleteAll);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.BtnDelete);
            this.groupBox2.Controls.Add(this.TxtPassWord);
            this.groupBox2.Controls.Add(this.TxtUserName);
            this.groupBox2.Controls.Add(this.BTcheck);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.AddMultiMail);
            this.groupBox2.Controls.Add(this.TxtEmail);
            this.groupBox2.Location = new System.Drawing.Point(460, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(371, 484);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(45, 76);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = " Lưu ý: Mail dạng user veri pass";
            // 
            // BtnOpenloi
            // 
            this.BtnOpenloi.Location = new System.Drawing.Point(134, 437);
            this.BtnOpenloi.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOpenloi.Name = "BtnOpenloi";
            this.BtnOpenloi.Size = new System.Drawing.Size(110, 35);
            this.BtnOpenloi.TabIndex = 19;
            this.BtnOpenloi.Text = "Mail lỗi";
            this.BtnOpenloi.UseVisualStyleBackColor = true;
            this.BtnOpenloi.Click += new System.EventHandler(this.BtnOpenloi_Click);
            // 
            // BtnDeleteAll
            // 
            this.BtnDeleteAll.Location = new System.Drawing.Point(243, 400);
            this.BtnDeleteAll.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteAll.Name = "BtnDeleteAll";
            this.BtnDeleteAll.Size = new System.Drawing.Size(74, 28);
            this.BtnDeleteAll.TabIndex = 18;
            this.BtnDeleteAll.Text = "Xóa hết";
            this.BtnDeleteAll.UseVisualStyleBackColor = true;
            this.BtnDeleteAll.Click += new System.EventHandler(this.BtnDeleteAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 346);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 346);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Email";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(152, 400);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(74, 28);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Xóa";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtPassWord
            // 
            this.TxtPassWord.Location = new System.Drawing.Point(194, 369);
            this.TxtPassWord.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPassWord.Name = "TxtPassWord";
            this.TxtPassWord.Size = new System.Drawing.Size(124, 20);
            this.TxtPassWord.TabIndex = 14;
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(47, 369);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(143, 20);
            this.TxtUserName.TabIndex = 13;
            // 
            // BTcheck
            // 
            this.BTcheck.Location = new System.Drawing.Point(58, 398);
            this.BTcheck.Margin = new System.Windows.Forms.Padding(2);
            this.BTcheck.Name = "BTcheck";
            this.BTcheck.Size = new System.Drawing.Size(74, 29);
            this.BTcheck.TabIndex = 12;
            this.BTcheck.Text = "Thêm";
            this.BTcheck.UseVisualStyleBackColor = true;
            this.BTcheck.Click += new System.EventHandler(this.BTcheck_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(274, 212);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AddMultiMail
            // 
            this.AddMultiMail.Location = new System.Drawing.Point(244, 76);
            this.AddMultiMail.Margin = new System.Windows.Forms.Padding(2);
            this.AddMultiMail.Name = "AddMultiMail";
            this.AddMultiMail.Size = new System.Drawing.Size(78, 30);
            this.AddMultiMail.TabIndex = 9;
            this.AddMultiMail.Text = "Thêm nhiều";
            this.AddMultiMail.UseVisualStyleBackColor = true;
            this.AddMultiMail.Click += new System.EventHandler(this.AddMultiMail_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(47, 23);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Multiline = true;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(276, 45);
            this.TxtEmail.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdYahoo);
            this.groupBox3.Controls.Add(this.RdOutlook);
            this.groupBox3.Controls.Add(this.RdGmail);
            this.groupBox3.Location = new System.Drawing.Point(18, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(414, 50);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Mail";
            // 
            // RdYahoo
            // 
            this.RdYahoo.AutoSize = true;
            this.RdYahoo.Enabled = false;
            this.RdYahoo.Location = new System.Drawing.Point(246, 20);
            this.RdYahoo.Margin = new System.Windows.Forms.Padding(2);
            this.RdYahoo.Name = "RdYahoo";
            this.RdYahoo.Size = new System.Drawing.Size(56, 17);
            this.RdYahoo.TabIndex = 2;
            this.RdYahoo.TabStop = true;
            this.RdYahoo.Text = "Yahoo";
            this.RdYahoo.UseVisualStyleBackColor = true;
            // 
            // RdOutlook
            // 
            this.RdOutlook.AutoSize = true;
            this.RdOutlook.Enabled = false;
            this.RdOutlook.Location = new System.Drawing.Point(119, 20);
            this.RdOutlook.Margin = new System.Windows.Forms.Padding(2);
            this.RdOutlook.Name = "RdOutlook";
            this.RdOutlook.Size = new System.Drawing.Size(62, 17);
            this.RdOutlook.TabIndex = 1;
            this.RdOutlook.TabStop = true;
            this.RdOutlook.Text = "Outlook";
            this.RdOutlook.UseVisualStyleBackColor = true;
            // 
            // RdGmail
            // 
            this.RdGmail.AutoSize = true;
            this.RdGmail.Location = new System.Drawing.Point(9, 20);
            this.RdGmail.Margin = new System.Windows.Forms.Padding(2);
            this.RdGmail.Name = "RdGmail";
            this.RdGmail.Size = new System.Drawing.Size(51, 17);
            this.RdGmail.TabIndex = 0;
            this.RdGmail.TabStop = true;
            this.RdGmail.Text = "Gmail";
            this.RdGmail.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnDelConTent);
            this.groupBox4.Controls.Add(this.BtnAddContent);
            this.groupBox4.Controls.Add(this.TxtNoiDung);
            this.groupBox4.Controls.Add(this.TxtChuDe);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(857, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 483);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiêu đề và nội dung gửi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(26, 205);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(246, 189);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // TxtChuDe
            // 
            this.TxtChuDe.Location = new System.Drawing.Point(26, 21);
            this.TxtChuDe.Multiline = true;
            this.TxtChuDe.Name = "TxtChuDe";
            this.TxtChuDe.Size = new System.Drawing.Size(246, 41);
            this.TxtChuDe.TabIndex = 1;
            // 
            // TxtNoiDung
            // 
            this.TxtNoiDung.Location = new System.Drawing.Point(26, 76);
            this.TxtNoiDung.Multiline = true;
            this.TxtNoiDung.Name = "TxtNoiDung";
            this.TxtNoiDung.Size = new System.Drawing.Size(246, 79);
            this.TxtNoiDung.TabIndex = 2;
            // 
            // BtnAddContent
            // 
            this.BtnAddContent.Location = new System.Drawing.Point(186, 165);
            this.BtnAddContent.Name = "BtnAddContent";
            this.BtnAddContent.Size = new System.Drawing.Size(86, 27);
            this.BtnAddContent.TabIndex = 3;
            this.BtnAddContent.Text = "Thêm";
            this.BtnAddContent.UseVisualStyleBackColor = true;
            this.BtnAddContent.Click += new System.EventHandler(this.BtnAddContent_Click);
            // 
            // BtnDelConTent
            // 
            this.BtnDelConTent.Location = new System.Drawing.Point(186, 414);
            this.BtnDelConTent.Name = "BtnDelConTent";
            this.BtnDelConTent.Size = new System.Drawing.Size(86, 27);
            this.BtnDelConTent.TabIndex = 3;
            this.BtnDelConTent.Text = "Xóa";
            this.BtnDelConTent.UseVisualStyleBackColor = true;
            this.BtnDelConTent.Click += new System.EventHandler(this.BtnDelConTent_Click);
            // 
            // CBTuDong
            // 
            this.CBTuDong.AutoSize = true;
            this.CBTuDong.Location = new System.Drawing.Point(20, 76);
            this.CBTuDong.Name = "CBTuDong";
            this.CBTuDong.Size = new System.Drawing.Size(143, 17);
            this.CBTuDong.TabIndex = 14;
            this.CBTuDong.Text = "Tự điền tiêu đề nội dung";
            this.CBTuDong.UseVisualStyleBackColor = true;
            this.CBTuDong.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(71, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lưu ý: Gửi nhiều mail dạng Mail/Mail";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 505);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NbThread)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoluongmail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtContent;
        private System.Windows.Forms.TextBox TxtTieude;
        private System.Windows.Forms.TextBox TxtMailNhan;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label LbThatbai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbThanhcong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddMultiMail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTcheck;
        private System.Windows.Forms.TextBox TxtPassWord;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnDeleteAll;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdYahoo;
        private System.Windows.Forms.RadioButton RdOutlook;
        private System.Windows.Forms.RadioButton RdGmail;
        private System.Windows.Forms.Button BtnOpenloi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown TxtSoluongmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NbThread;
        private System.Windows.Forms.CheckBox CBTuDong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnDelConTent;
        private System.Windows.Forms.Button BtnAddContent;
        private System.Windows.Forms.TextBox TxtNoiDung;
        private System.Windows.Forms.TextBox TxtChuDe;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
    }
}

