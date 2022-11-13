namespace GUI
{
    partial class frmThongTinMucDoCau
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboChuong = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drvMucDo = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MucDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSoLuongCauHoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvMucDo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboChuong
            // 
            this.cboChuong.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChuong.FormattingEnabled = true;
            this.cboChuong.Location = new System.Drawing.Point(16, 18);
            this.cboChuong.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cboChuong.Name = "cboChuong";
            this.cboChuong.Size = new System.Drawing.Size(790, 30);
            this.cboChuong.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drvMucDo);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(15, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(799, 500);
            this.groupBox1.TabIndex = 13;
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
            this.drvMucDo.Location = new System.Drawing.Point(5, 28);
            this.drvMucDo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.drvMucDo.Name = "drvMucDo";
            this.drvMucDo.RowHeadersWidth = 51;
            this.drvMucDo.Size = new System.Drawing.Size(789, 466);
            this.drvMucDo.TabIndex = 4;
            this.drvMucDo.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.drvMucDo_RowPostPaint_1);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.SoCau.DefaultCellStyle = dataGridViewCellStyle3;
            this.SoCau.HeaderText = "Số câu";
            this.SoCau.MinimumWidth = 6;
            this.SoCau.Name = "SoCau";
            // 
            // txtSoLuongCauHoi
            // 
            this.txtSoLuongCauHoi.Enabled = false;
            this.txtSoLuongCauHoi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongCauHoi.Location = new System.Drawing.Point(230, 72);
            this.txtSoLuongCauHoi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSoLuongCauHoi.Name = "txtSoLuongCauHoi";
            this.txtSoLuongCauHoi.Size = new System.Drawing.Size(119, 29);
            this.txtSoLuongCauHoi.TabIndex = 12;
            this.txtSoLuongCauHoi.TextChanged += new System.EventHandler(this.txtSoLuongCauHoi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số lượng câu hỏi:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Transparent;
            this.btnThoat.Image = global::GUI.Properties.Resources.back;
            this.btnThoat.Location = new System.Drawing.Point(661, 645);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 46);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongTinMucDoCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 706);
            this.Controls.Add(this.cboChuong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoLuongCauHoi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThongTinMucDoCau";
            this.Text = "Thông tin mức độ";
            this.Load += new System.EventHandler(this.frmThongTinMucDoCau_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvMucDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView drvMucDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MucDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCau;
        private System.Windows.Forms.TextBox txtSoLuongCauHoi;
        private System.Windows.Forms.Label label1;
    }
}