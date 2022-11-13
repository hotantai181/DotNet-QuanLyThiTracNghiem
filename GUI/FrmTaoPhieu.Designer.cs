namespace GUI
{
    partial class FrmTaoPhieu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contentmnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmSốCâuHỏiChươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaSốCâuHỏiHỏiChươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSốCâuHỏiChươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnThongTinPhieu = new System.Windows.Forms.Panel();
            this.drvSoLuongCauHoi = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCauHoi_md = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.pnThongTinChung = new System.Windows.Forms.Panel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTgianLamBai = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuongCauHoi = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuongDe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drvDSPhieu = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.làmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.contentmnu.SuspendLayout();
            this.pnThongTinPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvSoLuongCauHoi)).BeginInit();
            this.flowLayoutPanel10.SuspendLayout();
            this.pnThongTinChung.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvDSPhieu)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.ContextMenuStrip = this.contentmnu;
            this.groupBox2.Controls.Add(this.pnThongTinPhieu);
            this.groupBox2.Controls.Add(this.flowLayoutPanel10);
            this.groupBox2.Controls.Add(this.pnThongTinChung);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(479, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(1007, 778);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu";
            // 
            // contentmnu
            // 
            this.contentmnu.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentmnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contentmnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaToolStripMenuItem,
            this.thêmSốCâuHỏiChươngToolStripMenuItem,
            this.sửaSốCâuHỏiHỏiChươngToolStripMenuItem,
            this.xóaSốCâuHỏiChươngToolStripMenuItem});
            this.contentmnu.Name = "contentmnu";
            this.contentmnu.Size = new System.Drawing.Size(282, 108);
            this.contentmnu.Opening += new System.ComponentModel.CancelEventHandler(this.contentmnu_Opening);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chỉnhSửaToolStripMenuItem.Image = global::GUI.Properties.Resources.Flat_Icons_com_Flat_Pencil;
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa thông tin";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem_Click);
            // 
            // thêmSốCâuHỏiChươngToolStripMenuItem
            // 
            this.thêmSốCâuHỏiChươngToolStripMenuItem.Image = global::GUI.Properties.Resources.add;
            this.thêmSốCâuHỏiChươngToolStripMenuItem.Name = "thêmSốCâuHỏiChươngToolStripMenuItem";
            this.thêmSốCâuHỏiChươngToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.thêmSốCâuHỏiChươngToolStripMenuItem.Text = "Thêm số câu hỏi chương";
            this.thêmSốCâuHỏiChươngToolStripMenuItem.Click += new System.EventHandler(this.thêmSốCâuHỏiChươngToolStripMenuItem_Click);
            // 
            // sửaSốCâuHỏiHỏiChươngToolStripMenuItem
            // 
            this.sửaSốCâuHỏiHỏiChươngToolStripMenuItem.Image = global::GUI.Properties.Resources.Custom_Icon_Design_Pretty_Office_10_Pencil;
            this.sửaSốCâuHỏiHỏiChươngToolStripMenuItem.Name = "sửaSốCâuHỏiHỏiChươngToolStripMenuItem";
            this.sửaSốCâuHỏiHỏiChươngToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.sửaSốCâuHỏiHỏiChươngToolStripMenuItem.Text = "Sửa số câu hỏi chương";
            this.sửaSốCâuHỏiHỏiChươngToolStripMenuItem.Click += new System.EventHandler(this.sửaSốCâuHỏiHỏiChươngToolStripMenuItem_Click);
            // 
            // xóaSốCâuHỏiChươngToolStripMenuItem
            // 
            this.xóaSốCâuHỏiChươngToolStripMenuItem.Image = global::GUI.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_2;
            this.xóaSốCâuHỏiChươngToolStripMenuItem.Name = "xóaSốCâuHỏiChươngToolStripMenuItem";
            this.xóaSốCâuHỏiChươngToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.xóaSốCâuHỏiChươngToolStripMenuItem.Text = "Xóa số câu hỏi chương";
            this.xóaSốCâuHỏiChươngToolStripMenuItem.Click += new System.EventHandler(this.xóaSốCâuHỏiChươngToolStripMenuItem_Click);
            // 
            // pnThongTinPhieu
            // 
            this.pnThongTinPhieu.Controls.Add(this.drvSoLuongCauHoi);
            this.pnThongTinPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTinPhieu.Enabled = false;
            this.pnThongTinPhieu.Location = new System.Drawing.Point(10, 239);
            this.pnThongTinPhieu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnThongTinPhieu.Name = "pnThongTinPhieu";
            this.pnThongTinPhieu.Size = new System.Drawing.Size(987, 457);
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
            this.drvSoLuongCauHoi.ReadOnly = true;
            this.drvSoLuongCauHoi.RowHeadersVisible = false;
            this.drvSoLuongCauHoi.RowHeadersWidth = 51;
            this.drvSoLuongCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvSoLuongCauHoi.Size = new System.Drawing.Size(987, 457);
            this.drvSoLuongCauHoi.TabIndex = 0;
            this.drvSoLuongCauHoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvSoLuongCauHoi_CellContentClick);
            this.drvSoLuongCauHoi.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.drvSoLuongCauHoi_RowPostPaint);
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
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.AutoSize = true;
            this.flowLayoutPanel10.Controls.Add(this.btnThoat);
            this.flowLayoutPanel10.Controls.Add(this.btnLuu);
            this.flowLayoutPanel10.Controls.Add(this.btnTaoMoi);
            this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(10, 696);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(987, 72);
            this.flowLayoutPanel10.TabIndex = 7;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::GUI.Properties.Resources.back;
            this.btnThoat.Location = new System.Drawing.Point(871, 15);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 15, 5, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 51);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.Teal;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::GUI.Properties.Resources.save;
            this.btnLuu.Location = new System.Drawing.Point(724, 15);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5, 15, 5, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(137, 51);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Xác nhận";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoMoi.AutoSize = true;
            this.btnTaoMoi.BackColor = System.Drawing.Color.Teal;
            this.btnTaoMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoi.Image = global::GUI.Properties.Resources.add;
            this.btnTaoMoi.Location = new System.Drawing.Point(527, 15);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(5, 15, 5, 6);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(187, 51);
            this.btnTaoMoi.TabIndex = 6;
            this.btnTaoMoi.Text = "Tạo phiếu mới";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // pnThongTinChung
            // 
            this.pnThongTinChung.Controls.Add(this.flowLayoutPanel9);
            this.pnThongTinChung.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnThongTinChung.Enabled = false;
            this.pnThongTinChung.Location = new System.Drawing.Point(10, 32);
            this.pnThongTinChung.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnThongTinChung.Name = "pnThongTinChung";
            this.pnThongTinChung.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.pnThongTinChung.Size = new System.Drawing.Size(987, 207);
            this.pnThongTinChung.TabIndex = 4;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel9.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(987, 197);
            this.flowLayoutPanel9.TabIndex = 27;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.label6);
            this.flowLayoutPanel8.Controls.Add(this.txtKhoa);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 10);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(374, 37);
            this.flowLayoutPanel8.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khoa";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Enabled = false;
            this.txtKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Location = new System.Drawing.Point(68, 4);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(302, 29);
            this.txtKhoa.TabIndex = 14;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.label2);
            this.flowLayoutPanel7.Controls.Add(this.txtNgayLap);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(410, 10);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(264, 41);
            this.flowLayoutPanel7.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ngày lập";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Enabled = false;
            this.txtNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayLap.Location = new System.Drawing.Point(99, 6);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(160, 29);
            this.txtNgayLap.TabIndex = 11;
            this.txtNgayLap.Text = "27/05/2022";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.label1);
            this.flowLayoutPanel6.Controls.Add(this.txtMaPhieu);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(707, 10);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(214, 41);
            this.flowLayoutPanel6.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieu.Location = new System.Drawing.Point(109, 6);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(100, 29);
            this.txtMaPhieu.TabIndex = 16;
            this.txtMaPhieu.Text = "PH01";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.cboMonHoc);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 71);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(504, 44);
            this.flowLayoutPanel5.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Môn học:";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMonHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(105, 6);
            this.cboMonHoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(394, 32);
            this.cboMonHoc.TabIndex = 18;
            this.cboMonHoc.Text = "thực hành phân tích thiết kế hệ thống thông tin";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.txtTrangThai);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 135);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(434, 41);
            this.flowLayoutPanel4.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Trạng thái:";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Location = new System.Drawing.Point(114, 6);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(315, 29);
            this.txtTrangThai.TabIndex = 14;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.txtTgianLamBai);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(470, 135);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(297, 41);
            this.flowLayoutPanel3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 10);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thời gian làm bài (phút):";
            // 
            // txtTgianLamBai
            // 
            this.txtTgianLamBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTgianLamBai.Location = new System.Drawing.Point(228, 6);
            this.txtTgianLamBai.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTgianLamBai.Name = "txtTgianLamBai";
            this.txtTgianLamBai.Size = new System.Drawing.Size(64, 29);
            this.txtTgianLamBai.TabIndex = 12;
            this.txtTgianLamBai.Text = "120";
            this.txtTgianLamBai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtSoLuongCauHoi);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 196);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(242, 41);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng câu hỏi:";
            // 
            // txtSoLuongCauHoi
            // 
            this.txtSoLuongCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongCauHoi.Location = new System.Drawing.Point(173, 6);
            this.txtSoLuongCauHoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSoLuongCauHoi.Name = "txtSoLuongCauHoi";
            this.txtSoLuongCauHoi.Size = new System.Drawing.Size(64, 29);
            this.txtSoLuongCauHoi.TabIndex = 13;
            this.txtSoLuongCauHoi.Text = "10";
            this.txtSoLuongCauHoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.txtSoLuongDe);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(278, 196);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 30, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(208, 41);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số lượng đề:";
            // 
            // txtSoLuongDe
            // 
            this.txtSoLuongDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongDe.Location = new System.Drawing.Point(134, 6);
            this.txtSoLuongDe.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSoLuongDe.Name = "txtSoLuongDe";
            this.txtSoLuongDe.Size = new System.Drawing.Size(69, 29);
            this.txtSoLuongDe.TabIndex = 15;
            this.txtSoLuongDe.Text = "10";
            this.txtSoLuongDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkNumber);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drvDSPhieu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(469, 778);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu";
            // 
            // drvDSPhieu
            // 
            this.drvDSPhieu.AllowUserToAddRows = false;
            this.drvDSPhieu.AllowUserToDeleteRows = false;
            this.drvDSPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvDSPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvDSPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.NgayLap,
            this.TrangThai});
            this.drvDSPhieu.ContextMenuStrip = this.contextMenuStrip;
            this.drvDSPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvDSPhieu.Location = new System.Drawing.Point(5, 28);
            this.drvDSPhieu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.drvDSPhieu.Name = "drvDSPhieu";
            this.drvDSPhieu.ReadOnly = true;
            this.drvDSPhieu.RowHeadersVisible = false;
            this.drvDSPhieu.RowHeadersWidth = 51;
            this.drvDSPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvDSPhieu.Size = new System.Drawing.Size(459, 744);
            this.drvDSPhieu.TabIndex = 0;
            this.drvDSPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvDSPhieu_CellClick);
            // 
            // MaPhieu
            // 
            this.MaPhieu.DataPropertyName = "MaPhieu";
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.MinimumWidth = 6;
            this.MaPhieu.Name = "MaPhieu";
            this.MaPhieu.ReadOnly = true;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.MinimumWidth = 6;
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmMớiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 56);
            // 
            // làmMớiToolStripMenuItem
            // 
            this.làmMớiToolStripMenuItem.Image = global::GUI.Properties.Resources.Refresh_icon;
            this.làmMớiToolStripMenuItem.Name = "làmMớiToolStripMenuItem";
            this.làmMớiToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.làmMớiToolStripMenuItem.Text = "Làm mới";
            this.làmMớiToolStripMenuItem.Click += new System.EventHandler(this.làmMớiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::GUI.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_2;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItem1.Text = "Xóa";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // FrmTaoPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 798);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTaoPhieu";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Tạo phiếu";
            this.Load += new System.EventHandler(this.frmTaoPhieu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contentmnu.ResumeLayout(false);
            this.pnThongTinPhieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvSoLuongCauHoi)).EndInit();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.pnThongTinChung.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvDSPhieu)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnThongTinPhieu;
        private System.Windows.Forms.DataGridView drvSoLuongCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCauHoi_md;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Panel pnThongTinChung;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTgianLamBai;
        private System.Windows.Forms.TextBox txtSoLuongCauHoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView drvDSPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.ContextMenuStrip contentmnu;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSốCâuHỏiChươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaSốCâuHỏiHỏiChươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSốCâuHỏiChươngToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem làmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}