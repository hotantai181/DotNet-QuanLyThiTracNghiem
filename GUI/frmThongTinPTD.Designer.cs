namespace GUI
{
    partial class frmThongTinPTD
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnThongTinPhieu = new System.Windows.Forms.Panel();
            this.drvSoLuongCauHoi = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCauHoi_md = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnThongTinChung = new System.Windows.Forms.Panel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuongDe = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuongCauHoi = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTgianLamBai = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2.SuspendLayout();
            this.pnThongTinPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvSoLuongCauHoi)).BeginInit();
            this.pnThongTinChung.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnThongTinPhieu);
            this.groupBox2.Controls.Add(this.flowLayoutPanel10);
            this.groupBox2.Controls.Add(this.pnThongTinChung);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(1414, 742);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::GUI.Properties.Resources.back;
            this.btnThoat.Location = new System.Drawing.Point(1244, 16);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 54);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnThongTinPhieu
            // 
            this.pnThongTinPhieu.Controls.Add(this.drvSoLuongCauHoi);
            this.pnThongTinPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTinPhieu.Location = new System.Drawing.Point(10, 231);
            this.pnThongTinPhieu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnThongTinPhieu.Name = "pnThongTinPhieu";
            this.pnThongTinPhieu.Size = new System.Drawing.Size(1394, 425);
            this.pnThongTinPhieu.TabIndex = 5;
            // 
            // drvSoLuongCauHoi
            // 
            this.drvSoLuongCauHoi.AllowUserToAddRows = false;
            this.drvSoLuongCauHoi.AllowUserToDeleteRows = false;
            this.drvSoLuongCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvSoLuongCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvSoLuongCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoCauHoi_md,
            this.Ma,
            this.Chuong,
            this.MaChuong,
            this.SoLuong});
            this.drvSoLuongCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvSoLuongCauHoi.Location = new System.Drawing.Point(0, 0);
            this.drvSoLuongCauHoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.drvSoLuongCauHoi.Name = "drvSoLuongCauHoi";
            this.drvSoLuongCauHoi.RowHeadersWidth = 51;
            this.drvSoLuongCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvSoLuongCauHoi.Size = new System.Drawing.Size(1394, 425);
            this.drvSoLuongCauHoi.TabIndex = 0;
            this.drvSoLuongCauHoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvSoLuongCauHoi_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // SoCauHoi_md
            // 
            this.SoCauHoi_md.HeaderText = "Số câu hỏi mức độ";
            this.SoCauHoi_md.MinimumWidth = 6;
            this.SoCauHoi_md.Name = "SoCauHoi_md";
            this.SoCauHoi_md.ReadOnly = true;
            this.SoCauHoi_md.Visible = false;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Ma";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            this.Ma.Visible = false;
            // 
            // Chuong
            // 
            this.Chuong.DataPropertyName = "TenChuong";
            this.Chuong.HeaderText = "Chương";
            this.Chuong.MinimumWidth = 6;
            this.Chuong.Name = "Chuong";
            this.Chuong.ReadOnly = true;
            // 
            // MaChuong
            // 
            this.MaChuong.DataPropertyName = "MaChuong";
            this.MaChuong.HeaderText = "Mã chương";
            this.MaChuong.MinimumWidth = 6;
            this.MaChuong.Name = "MaChuong";
            this.MaChuong.ReadOnly = true;
            this.MaChuong.Visible = false;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoCauHoi";
            this.SoLuong.HeaderText = "Số câu hỏi";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // pnThongTinChung
            // 
            this.pnThongTinChung.Controls.Add(this.flowLayoutPanel9);
            this.pnThongTinChung.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThongTinChung.Enabled = false;
            this.pnThongTinChung.Location = new System.Drawing.Point(10, 32);
            this.pnThongTinChung.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnThongTinChung.Name = "pnThongTinChung";
            this.pnThongTinChung.Padding = new System.Windows.Forms.Padding(5);
            this.pnThongTinChung.Size = new System.Drawing.Size(1394, 199);
            this.pnThongTinChung.TabIndex = 4;
            this.pnThongTinChung.Paint += new System.Windows.Forms.PaintEventHandler(this.pnThongTinChung_Paint);
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(1384, 189);
            this.flowLayoutPanel9.TabIndex = 25;
            this.flowLayoutPanel9.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel9_Paint);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Controls.Add(this.txtMaPhieu);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 10);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(208, 41);
            this.flowLayoutPanel5.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã phiếu:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(103, 6);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(100, 29);
            this.txtMaPhieu.TabIndex = 16;
            this.txtMaPhieu.Text = "PH01";
            this.txtMaPhieu.TextChanged += new System.EventHandler(this.txtMaPhieu_TextChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.txtNgayLap);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(244, 10);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(259, 41);
            this.flowLayoutPanel4.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày lập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLap.Location = new System.Drawing.Point(94, 6);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(160, 29);
            this.txtNgayLap.TabIndex = 11;
            this.txtNgayLap.Text = "27/05/2022";
            this.txtNgayLap.TextChanged += new System.EventHandler(this.txtNgayLap_TextChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.txtKhoa);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(536, 10);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(470, 41);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khoa";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtKhoa
            // 
            this.txtKhoa.Enabled = false;
            this.txtKhoa.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Location = new System.Drawing.Point(65, 6);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(400, 29);
            this.txtKhoa.TabIndex = 14;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.label5);
            this.flowLayoutPanel6.Controls.Add(this.txtMonHoc);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 71);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(464, 41);
            this.flowLayoutPanel6.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Môn học:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Enabled = false;
            this.txtMonHoc.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonHoc.Location = new System.Drawing.Point(99, 6);
            this.txtMonHoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(360, 29);
            this.txtMonHoc.TabIndex = 14;
            this.txtMonHoc.TextChanged += new System.EventHandler(this.txtMonHoc_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtTrangThai);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(500, 71);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(337, 41);
            this.flowLayoutPanel2.TabIndex = 18;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng thái:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(112, 6);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(220, 29);
            this.txtTrangThai.TabIndex = 14;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.label3);
            this.flowLayoutPanel7.Controls.Add(this.txtSoLuongDe);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(870, 71);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(201, 41);
            this.flowLayoutPanel7.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số lượng đề:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSoLuongDe
            // 
            this.txtSoLuongDe.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongDe.Location = new System.Drawing.Point(127, 6);
            this.txtSoLuongDe.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSoLuongDe.Name = "txtSoLuongDe";
            this.txtSoLuongDe.Size = new System.Drawing.Size(69, 29);
            this.txtSoLuongDe.TabIndex = 15;
            this.txtSoLuongDe.Text = "10";
            this.txtSoLuongDe.TextChanged += new System.EventHandler(this.txtSoLuongDe_TextChanged);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.label4);
            this.flowLayoutPanel8.Controls.Add(this.txtSoLuongCauHoi);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(1104, 71);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(234, 41);
            this.flowLayoutPanel8.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng câu hỏi:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSoLuongCauHoi
            // 
            this.txtSoLuongCauHoi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongCauHoi.Location = new System.Drawing.Point(165, 6);
            this.txtSoLuongCauHoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSoLuongCauHoi.Name = "txtSoLuongCauHoi";
            this.txtSoLuongCauHoi.Size = new System.Drawing.Size(64, 29);
            this.txtSoLuongCauHoi.TabIndex = 13;
            this.txtSoLuongCauHoi.Text = "10";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.txtTgianLamBai);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 132);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 41);
            this.flowLayoutPanel1.TabIndex = 17;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thời gian làm bài (phút):";
            // 
            // txtTgianLamBai
            // 
            this.txtTgianLamBai.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTgianLamBai.Location = new System.Drawing.Point(224, 6);
            this.txtTgianLamBai.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTgianLamBai.Name = "txtTgianLamBai";
            this.txtTgianLamBai.Size = new System.Drawing.Size(64, 29);
            this.txtTgianLamBai.TabIndex = 12;
            this.txtTgianLamBai.Text = "120";
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.AutoSize = true;
            this.flowLayoutPanel10.Controls.Add(this.btnThoat);
            this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(10, 656);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel10.Size = new System.Drawing.Size(1394, 76);
            this.flowLayoutPanel10.TabIndex = 7;
            // 
            // frmThongTinPTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 762);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongTinPTD";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Thông tin phiếu tạo đề";
            this.Load += new System.EventHandler(this.frmThongTinPTD_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnThongTinPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvSoLuongCauHoi)).EndInit();
            this.pnThongTinChung.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel pnThongTinPhieu;
        private System.Windows.Forms.DataGridView drvSoLuongCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCauHoi_md;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Panel pnThongTinChung;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTgianLamBai;
        private System.Windows.Forms.TextBox txtSoLuongCauHoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
    }
}