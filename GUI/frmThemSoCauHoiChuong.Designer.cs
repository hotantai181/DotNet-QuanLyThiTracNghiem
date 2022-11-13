namespace GUI
{
    partial class frmThemSoCauHoiChuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.ckPhanLoai = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drvMucDo = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuongCauHoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChuong = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvMucDo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AutoSize = true;
            this.btnXacNhan.BackColor = System.Drawing.Color.Teal;
            this.btnXacNhan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(450, 6);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(161, 50);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // ckPhanLoai
            // 
            this.ckPhanLoai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ckPhanLoai.AutoSize = true;
            this.ckPhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckPhanLoai.Location = new System.Drawing.Point(389, 72);
            this.ckPhanLoai.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ckPhanLoai.Name = "ckPhanLoai";
            this.ckPhanLoai.Size = new System.Drawing.Size(222, 28);
            this.ckPhanLoai.TabIndex = 11;
            this.ckPhanLoai.Text = "Phân loại theo mức độ";
            this.ckPhanLoai.UseVisualStyleBackColor = true;
            this.ckPhanLoai.CheckedChanged += new System.EventHandler(this.ckPhanLoai_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drvMucDo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(10, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(621, 514);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mức độ câu hỏi";
            // 
            // drvMucDo
            // 
            this.drvMucDo.AllowUserToAddRows = false;
            this.drvMucDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvMucDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvMucDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MucDo,
            this.SoCau});
            this.drvMucDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvMucDo.Location = new System.Drawing.Point(10, 32);
            this.drvMucDo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.drvMucDo.Name = "drvMucDo";
            this.drvMucDo.RowHeadersWidth = 51;
            this.drvMucDo.Size = new System.Drawing.Size(601, 472);
            this.drvMucDo.TabIndex = 4;
            this.drvMucDo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvMucDo_CellContentClick);
            this.drvMucDo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvMucDo_CellEndEdit);
            this.drvMucDo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.drvMucDo_RowPostPaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MucDo
            // 
            this.MucDo.HeaderText = "Mức độ";
            this.MucDo.MinimumWidth = 6;
            this.MucDo.Name = "MucDo";
            this.MucDo.ReadOnly = true;
            // 
            // SoCau
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.SoCau.DefaultCellStyle = dataGridViewCellStyle1;
            this.SoCau.HeaderText = "Số câu";
            this.SoCau.MinimumWidth = 6;
            this.SoCau.Name = "SoCau";
            // 
            // txtSoLuongCauHoi
            // 
            this.txtSoLuongCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongCauHoi.Location = new System.Drawing.Point(173, 6);
            this.txtSoLuongCauHoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSoLuongCauHoi.Name = "txtSoLuongCauHoi";
            this.txtSoLuongCauHoi.Size = new System.Drawing.Size(170, 30);
            this.txtSoLuongCauHoi.TabIndex = 8;
            this.txtSoLuongCauHoi.TextChanged += new System.EventHandler(this.txtSoLuongCauHoi_TextChanged);
            this.txtSoLuongCauHoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongCauHoi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số lượng câu hỏi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboChuong
            // 
            this.cboChuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboChuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboChuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboChuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuong.FormattingEnabled = true;
            this.cboChuong.Location = new System.Drawing.Point(70, 10);
            this.cboChuong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboChuong.Name = "cboChuong";
            this.cboChuong.Size = new System.Drawing.Size(480, 32);
            this.cboChuong.TabIndex = 6;
            this.cboChuong.SelectedIndexChanged += new System.EventHandler(this.cboChuong_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtSoLuongCauHoi);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 66);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(348, 42);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.ckPhanLoai);
            this.panel1.Controls.Add(this.cboChuong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 117);
            this.panel1.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btnXacNhan);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 641);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(621, 62);
            this.flowLayoutPanel2.TabIndex = 14;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // frmThemSoCauHoiChuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 713);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemSoCauHoiChuong";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm số câu hỏi theo chương";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmThemSoCauHoiChuong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvMucDo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.CheckBox ckPhanLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView drvMucDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCau;
        private System.Windows.Forms.TextBox txtSoLuongCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChuong;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}