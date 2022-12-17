
namespace GUI
{
    partial class FrmNganHangCauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNganHangCauHoi));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.gbDapAn = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdoBtnA = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoBtnB = new System.Windows.Forms.RadioButton();
            this.txtB = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoBtnC = new System.Windows.Forms.RadioButton();
            this.txtC = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdoBtnD = new System.Windows.Forms.RadioButton();
            this.txtD = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachCauHoi = new System.Windows.Forms.DataGridView();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAnDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAnD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAnC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAnB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAnA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbMonHoc = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdoDe = new System.Windows.Forms.RadioButton();
            this.rdoKho = new System.Windows.Forms.RadioButton();
            this.rdoTrungBinh = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDapAn.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCauHoi)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-add-new-100.png");
            this.imageList1.Images.SetKeyName(1, "icons8-microsoft-excel-100.png");
            this.imageList1.Images.SetKeyName(2, "icons8-synchronize-100.png");
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnImportExcel);
            this.flowLayoutPanel2.Controls.Add(this.btnLuu);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(597, 767);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(745, 54);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.Teal;
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::GUI.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(462, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(104, 52);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.AutoSize = true;
            this.btnImportExcel.BackColor = System.Drawing.Color.Teal;
            this.btnImportExcel.FlatAppearance.BorderSize = 0;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Image = global::GUI.Properties.Resources.excel1;
            this.btnImportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportExcel.Location = new System.Drawing.Point(572, 3);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnImportExcel.Size = new System.Drawing.Size(170, 52);
            this.btnImportExcel.TabIndex = 8;
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // panel2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.gbDapAn);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 578);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtNoiDung);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10, 15, 20, 10);
            this.groupBox4.Size = new System.Drawing.Size(588, 171);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nội dung câu hỏi";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiDung.Location = new System.Drawing.Point(10, 37);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(558, 124);
            this.txtNoiDung.TabIndex = 0;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // gbDapAn
            // 
            this.gbDapAn.AutoSize = true;
            this.gbDapAn.Controls.Add(this.panel5);
            this.gbDapAn.Controls.Add(this.panel4);
            this.gbDapAn.Controls.Add(this.panel3);
            this.gbDapAn.Controls.Add(this.panel6);
            this.gbDapAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDapAn.Location = new System.Drawing.Point(0, 171);
            this.gbDapAn.Name = "gbDapAn";
            this.gbDapAn.Padding = new System.Windows.Forms.Padding(10, 15, 1, 10);
            this.gbDapAn.Size = new System.Drawing.Size(588, 407);
            this.gbDapAn.TabIndex = 3;
            this.gbDapAn.TabStop = false;
            this.gbDapAn.Text = "Đáp án";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtA);
            this.panel6.Controls.Add(this.rdoBtnA);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 37);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.panel6.Size = new System.Drawing.Size(577, 64);
            this.panel6.TabIndex = 3;
            // 
            // rdoBtnA
            // 
            this.rdoBtnA.AutoSize = true;
            this.rdoBtnA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnA.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoBtnA.Location = new System.Drawing.Point(0, 10);
            this.rdoBtnA.Name = "rdoBtnA";
            this.rdoBtnA.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.rdoBtnA.Size = new System.Drawing.Size(57, 44);
            this.rdoBtnA.TabIndex = 0;
            this.rdoBtnA.TabStop = true;
            this.rdoBtnA.Text = "A";
            this.rdoBtnA.UseVisualStyleBackColor = true;
            this.rdoBtnA.Click += new System.EventHandler(this.rdoBtnA_Click);
            // 
            // txtA
            // 
            this.txtA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtA.Location = new System.Drawing.Point(57, 10);
            this.txtA.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(500, 44);
            this.txtA.TabIndex = 7;
            this.txtA.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtB);
            this.panel3.Controls.Add(this.rdoBtnB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 101);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.panel3.Size = new System.Drawing.Size(577, 64);
            this.panel3.TabIndex = 4;
            // 
            // rdoBtnB
            // 
            this.rdoBtnB.AutoSize = true;
            this.rdoBtnB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnB.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoBtnB.Location = new System.Drawing.Point(0, 10);
            this.rdoBtnB.Name = "rdoBtnB";
            this.rdoBtnB.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.rdoBtnB.Size = new System.Drawing.Size(57, 44);
            this.rdoBtnB.TabIndex = 0;
            this.rdoBtnB.TabStop = true;
            this.rdoBtnB.Text = "B";
            this.rdoBtnB.UseVisualStyleBackColor = true;
            this.rdoBtnB.Click += new System.EventHandler(this.rdoBtnA_Click);
            // 
            // txtB
            // 
            this.txtB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtB.Location = new System.Drawing.Point(57, 10);
            this.txtB.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(500, 44);
            this.txtB.TabIndex = 7;
            this.txtB.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtC);
            this.panel4.Controls.Add(this.rdoBtnC);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 165);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.panel4.Size = new System.Drawing.Size(577, 64);
            this.panel4.TabIndex = 5;
            // 
            // rdoBtnC
            // 
            this.rdoBtnC.AutoSize = true;
            this.rdoBtnC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnC.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoBtnC.Location = new System.Drawing.Point(0, 10);
            this.rdoBtnC.Name = "rdoBtnC";
            this.rdoBtnC.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.rdoBtnC.Size = new System.Drawing.Size(57, 44);
            this.rdoBtnC.TabIndex = 0;
            this.rdoBtnC.TabStop = true;
            this.rdoBtnC.Text = "C";
            this.rdoBtnC.UseVisualStyleBackColor = true;
            this.rdoBtnC.Click += new System.EventHandler(this.rdoBtnA_Click);
            // 
            // txtC
            // 
            this.txtC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtC.Location = new System.Drawing.Point(57, 10);
            this.txtC.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(500, 44);
            this.txtC.TabIndex = 7;
            this.txtC.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtD);
            this.panel5.Controls.Add(this.rdoBtnD);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 229);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 10, 20, 10);
            this.panel5.Size = new System.Drawing.Size(577, 64);
            this.panel5.TabIndex = 6;
            // 
            // rdoBtnD
            // 
            this.rdoBtnD.AutoSize = true;
            this.rdoBtnD.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnD.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoBtnD.Location = new System.Drawing.Point(0, 10);
            this.rdoBtnD.Name = "rdoBtnD";
            this.rdoBtnD.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.rdoBtnD.Size = new System.Drawing.Size(58, 44);
            this.rdoBtnD.TabIndex = 0;
            this.rdoBtnD.TabStop = true;
            this.rdoBtnD.Text = "D";
            this.rdoBtnD.UseVisualStyleBackColor = true;
            this.rdoBtnD.Click += new System.EventHandler(this.rdoBtnA_Click);
            // 
            // txtD
            // 
            this.txtD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtD.Location = new System.Drawing.Point(58, 10);
            this.txtD.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(499, 44);
            this.txtD.TabIndex = 7;
            this.txtD.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvDanhSachCauHoi);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(597, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.SetRowSpan(this.groupBox5, 3);
            this.groupBox5.Size = new System.Drawing.Size(745, 748);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách câu hỏi";
            // 
            // dgvDanhSachCauHoi
            // 
            this.dgvDanhSachCauHoi.AllowUserToAddRows = false;
            this.dgvDanhSachCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DapAnA,
            this.DapAnB,
            this.DapAnC,
            this.DapAnD,
            this.DapAnDung,
            this.MucDo,
            this.MaMonHoc,
            this.MaChuong,
            this.MaGiaoVien});
            this.dgvDanhSachCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachCauHoi.Location = new System.Drawing.Point(10, 32);
            this.dgvDanhSachCauHoi.Name = "dgvDanhSachCauHoi";
            this.dgvDanhSachCauHoi.RowHeadersVisible = false;
            this.dgvDanhSachCauHoi.RowHeadersWidth = 51;
            this.dgvDanhSachCauHoi.RowTemplate.Height = 24;
            this.dgvDanhSachCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachCauHoi.Size = new System.Drawing.Size(725, 706);
            this.dgvDanhSachCauHoi.TabIndex = 0;
            this.dgvDanhSachCauHoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachCauHoi_CellContentClick);
            this.dgvDanhSachCauHoi.Click += new System.EventHandler(this.dgvDanhSachCauHoi_Click);
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.MaGiaoVien.HeaderText = "Mã giáo viên";
            this.MaGiaoVien.MinimumWidth = 6;
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.Visible = false;
            this.MaGiaoVien.Width = 125;
            // 
            // MaChuong
            // 
            this.MaChuong.DataPropertyName = "MaChuong";
            this.MaChuong.HeaderText = "Mã chương";
            this.MaChuong.MinimumWidth = 6;
            this.MaChuong.Name = "MaChuong";
            this.MaChuong.Visible = false;
            this.MaChuong.Width = 125;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "Mã môn học";
            this.MaMonHoc.MinimumWidth = 6;
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.Visible = false;
            this.MaMonHoc.Width = 125;
            // 
            // MucDo
            // 
            this.MucDo.DataPropertyName = "MucDo";
            this.MucDo.HeaderText = "Mức độ";
            this.MucDo.MinimumWidth = 6;
            this.MucDo.Name = "MucDo";
            this.MucDo.Width = 125;
            // 
            // DapAnDung
            // 
            this.DapAnDung.DataPropertyName = "DapAnDung";
            this.DapAnDung.HeaderText = "Đáp án đúng";
            this.DapAnDung.MinimumWidth = 6;
            this.DapAnDung.Name = "DapAnDung";
            this.DapAnDung.Width = 125;
            // 
            // DapAnD
            // 
            this.DapAnD.DataPropertyName = "DapAnD";
            this.DapAnD.HeaderText = "Đáp án D";
            this.DapAnD.MinimumWidth = 6;
            this.DapAnD.Name = "DapAnD";
            this.DapAnD.Width = 125;
            // 
            // DapAnC
            // 
            this.DapAnC.DataPropertyName = "DapAnC";
            this.DapAnC.HeaderText = "Đáp án C";
            this.DapAnC.MinimumWidth = 6;
            this.DapAnC.Name = "DapAnC";
            this.DapAnC.Width = 125;
            // 
            // DapAnB
            // 
            this.DapAnB.DataPropertyName = "DapAnB";
            this.DapAnB.HeaderText = "Đáp án B";
            this.DapAnB.MinimumWidth = 6;
            this.DapAnB.Name = "DapAnB";
            this.DapAnB.Width = 125;
            // 
            // DapAnA
            // 
            this.DapAnA.DataPropertyName = "DapAnA";
            this.DapAnA.HeaderText = "Đáp án A";
            this.DapAnA.MinimumWidth = 6;
            this.DapAnA.Name = "DapAnA";
            this.DapAnA.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CauHoi";
            this.Column1.HeaderText = "Câu hỏi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbMonHoc);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.groupBox2.Size = new System.Drawing.Size(306, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Môn học";
            // 
            // cbbMonHoc
            // 
            this.cbbMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbbMonHoc.FormattingEnabled = true;
            this.cbbMonHoc.Location = new System.Drawing.Point(10, 37);
            this.cbbMonHoc.Name = "cbbMonHoc";
            this.cbbMonHoc.Size = new System.Drawing.Size(286, 30);
            this.cbbMonHoc.TabIndex = 3;
            this.cbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.cbbMonHoc_SelectedIndexChanged_1);
            // 
            // flowLayoutPanel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel3, 2);
            this.flowLayoutPanel3.Controls.Add(this.btnThem);
            this.flowLayoutPanel3.Controls.Add(this.btnNhapLai);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 767);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(588, 54);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.AutoSize = true;
            this.btnNhapLai.BackColor = System.Drawing.Color.Teal;
            this.btnNhapLai.FlatAppearance.BorderSize = 0;
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.ForeColor = System.Drawing.Color.White;
            this.btnNhapLai.Image = global::GUI.Properties.Resources.Refresh_icon;
            this.btnNhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapLai.Location = new System.Drawing.Point(312, 3);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhapLai.Size = new System.Drawing.Size(147, 52);
            this.btnNhapLai.TabIndex = 7;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = true;
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::GUI.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(465, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(120, 52);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 751F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1345, 824);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rdoTrungBinh);
            this.flowLayoutPanel1.Controls.Add(this.rdoKho);
            this.flowLayoutPanel1.Controls.Add(this.rdoDe);
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(256, 108);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 99);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(140, 26);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vận dụng cao";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdoDe
            // 
            this.rdoDe.AutoSize = true;
            this.rdoDe.Location = new System.Drawing.Point(3, 67);
            this.rdoDe.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.rdoDe.Name = "rdoDe";
            this.rdoDe.Size = new System.Drawing.Size(107, 26);
            this.rdoDe.TabIndex = 3;
            this.rdoDe.TabStop = true;
            this.rdoDe.Text = "Vận dụng";
            this.rdoDe.UseVisualStyleBackColor = true;
            // 
            // rdoKho
            // 
            this.rdoKho.AutoSize = true;
            this.rdoKho.Location = new System.Drawing.Point(3, 35);
            this.rdoKho.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.rdoKho.Name = "rdoKho";
            this.rdoKho.Size = new System.Drawing.Size(121, 26);
            this.rdoKho.TabIndex = 4;
            this.rdoKho.TabStop = true;
            this.rdoKho.Text = "Thông hiểu";
            this.rdoKho.UseVisualStyleBackColor = true;
            // 
            // rdoTrungBinh
            // 
            this.rdoTrungBinh.AutoSize = true;
            this.rdoTrungBinh.Location = new System.Drawing.Point(3, 3);
            this.rdoTrungBinh.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.rdoTrungBinh.Name = "rdoTrungBinh";
            this.rdoTrungBinh.Size = new System.Drawing.Size(107, 26);
            this.rdoTrungBinh.TabIndex = 5;
            this.rdoTrungBinh.TabStop = true;
            this.rdoTrungBinh.Text = "Nhận biết";
            this.rdoTrungBinh.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.flowLayoutPanel1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(315, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.groupBox6.Size = new System.Drawing.Size(276, 155);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Mức độ";
            // 
            // FrmNganHangCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 834);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNganHangCauHoi";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.Text = "Ngân hàng câu hỏi";
            this.Load += new System.EventHandler(this.FrmNganHangCauHoi_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbDapAn.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachCauHoi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbMonHoc;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rdoTrungBinh;
        private System.Windows.Forms.RadioButton rdoKho;
        private System.Windows.Forms.RadioButton rdoDe;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvDanhSachCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAnA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAnB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAnC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAnD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAnDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.GroupBox gbDapAn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.RadioButton rdoBtnD;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.RadioButton rdoBtnC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.RadioButton rdoBtnB;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.RadioButton rdoBtnA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNoiDung;
    }
}