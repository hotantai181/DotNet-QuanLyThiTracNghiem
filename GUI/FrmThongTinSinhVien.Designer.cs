namespace GUI
{
    partial class FrmThongTinSinhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.T = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEmail = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMssv = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNgaySinh = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtGT = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.MONTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEMTHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1193, 694);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.T);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 65);
            this.panel2.TabIndex = 0;
            // 
            // T
            // 
            this.T.Dock = System.Windows.Forms.DockStyle.Fill;
            this.T.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.T.Location = new System.Drawing.Point(0, 0);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(1173, 65);
            this.T.TabIndex = 0;
            this.T.Text = "Thông tin học sinh";
            this.T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.T.Click += new System.EventHandler(this.T_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(841, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 609);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật mật khẩu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 609);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 315);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin cá nhân";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(25, 28);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(50, 20, 50, 20);
            this.panel3.Size = new System.Drawing.Size(781, 266);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtGioiTinh, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSDT, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCMND, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDiaChi, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHoTen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLop, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMssv, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNgaySinh, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label19, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtGT, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 226);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(468, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtEmail.Size = new System.Drawing.Size(66, 42);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.Text = "label16";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(342, 136);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label15.Size = new System.Drawing.Size(58, 42);
            this.label15.TabIndex = 14;
            this.label15.Text = "Email:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AutoSize = true;
            this.txtGioiTinh.Location = new System.Drawing.Point(136, 136);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtGioiTinh.Size = new System.Drawing.Size(66, 42);
            this.txtGioiTinh.TabIndex = 13;
            this.txtGioiTinh.Text = "label14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 136);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label13.Size = new System.Drawing.Size(82, 42);
            this.label13.TabIndex = 12;
            this.label13.Text = "Giới tính:";
            // 
            // txtSDT
            // 
            this.txtSDT.AutoSize = true;
            this.txtSDT.Location = new System.Drawing.Point(468, 94);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtSDT.Size = new System.Drawing.Size(66, 42);
            this.txtSDT.TabIndex = 11;
            this.txtSDT.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 94);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label11.Size = new System.Drawing.Size(120, 42);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số điện thoại:";
            // 
            // txtCMND
            // 
            this.txtCMND.AutoSize = true;
            this.txtCMND.Location = new System.Drawing.Point(136, 94);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtCMND.Size = new System.Drawing.Size(66, 42);
            this.txtCMND.TabIndex = 9;
            this.txtCMND.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 94);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label9.Size = new System.Drawing.Size(117, 42);
            this.label9.TabIndex = 8;
            this.label9.Text = "CMND/CCCD:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Location = new System.Drawing.Point(468, 52);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtDiaChi.Size = new System.Drawing.Size(56, 42);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 52);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label7.Size = new System.Drawing.Size(70, 42);
            this.label7.TabIndex = 6;
            this.label7.Text = "Địa chỉ:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Location = new System.Drawing.Point(136, 52);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtHoTen.Size = new System.Drawing.Size(56, 42);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 52);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label5.Size = new System.Drawing.Size(69, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên:";
            // 
            // txtLop
            // 
            this.txtLop.AutoSize = true;
            this.txtLop.Location = new System.Drawing.Point(468, 10);
            this.txtLop.Name = "txtLop";
            this.txtLop.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtLop.Size = new System.Drawing.Size(56, 42);
            this.txtLop.TabIndex = 3;
            this.txtLop.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Size = new System.Drawing.Size(111, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học sinh:";
            // 
            // txtMssv
            // 
            this.txtMssv.AutoSize = true;
            this.txtMssv.Location = new System.Drawing.Point(136, 10);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtMssv.Size = new System.Drawing.Size(56, 42);
            this.txtMssv.TabIndex = 2;
            this.txtMssv.Text = "label3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 178);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label17.Size = new System.Drawing.Size(94, 42);
            this.label17.TabIndex = 16;
            this.label17.Text = "Ngày sinh:";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.AutoSize = true;
            this.txtNgaySinh.Location = new System.Drawing.Point(136, 178);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtNgaySinh.Size = new System.Drawing.Size(82, 42);
            this.txtNgaySinh.TabIndex = 17;
            this.txtNgaySinh.Text = "Giới tính:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(342, 178);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label19.Size = new System.Drawing.Size(82, 42);
            this.label19.TabIndex = 18;
            this.label19.Text = "Giới tính:";
            // 
            // txtGT
            // 
            this.txtGT.AutoSize = true;
            this.txtGT.Location = new System.Drawing.Point(468, 178);
            this.txtGT.Name = "txtGT";
            this.txtGT.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.txtGT.Size = new System.Drawing.Size(82, 42);
            this.txtGT.TabIndex = 19;
            this.txtGT.Text = "Giới tính:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(342, 10);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label21.Size = new System.Drawing.Size(45, 42);
            this.label21.TabIndex = 20;
            this.label21.Text = "Lớp:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 340);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(825, 266);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Các bài ôn đã thực hiên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MONTHI,
            this.DIEMTHI,
            this.SCD,
            this.SCS});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(819, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu mới";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 29);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 29);
            this.textBox2.TabIndex = 3;
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.LightGreen;
            this.btncapnhat.Location = new System.Drawing.Point(56, 251);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(236, 68);
            this.btncapnhat.TabIndex = 4;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = false;
            // 
            // MONTHI
            // 
            this.MONTHI.HeaderText = "Môn thi";
            this.MONTHI.MinimumWidth = 6;
            this.MONTHI.Name = "MONTHI";
            // 
            // DIEMTHI
            // 
            this.DIEMTHI.HeaderText = "Điểm thi";
            this.DIEMTHI.MinimumWidth = 6;
            this.DIEMTHI.Name = "DIEMTHI";
            // 
            // SCD
            // 
            this.SCD.HeaderText = "Số câu đúng";
            this.SCD.MinimumWidth = 6;
            this.SCD.Name = "SCD";
            // 
            // SCS
            // 
            this.SCS.HeaderText = "Số câu sai";
            this.SCS.MinimumWidth = 6;
            this.SCS.Name = "SCS";
            // 
            // FrmThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 694);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmThongTinSinhVien";
            this.Text = "Ứng dụng ôn thi THPTQG";
            this.Load += new System.EventHandler(this.FrmThongTinSinhVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtGioiTinh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtSDT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtCMND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMssv;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label txtNgaySinh;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label txtGT;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEMTHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCS;
    }
}