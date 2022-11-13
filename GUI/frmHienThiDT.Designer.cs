namespace GUI
{
    partial class frmHienThiDT
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
            this.btnShow = new System.Windows.Forms.Button();
            this.drvDeThi = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuTaoDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhieuTaoDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.drvDeThi)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.BackColor = System.Drawing.Color.Teal;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(295, 6);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(145, 48);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Hiển thị";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // drvDeThi
            // 
            this.drvDeThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.drvDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvDeThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDe,
            this.MaPhieuTaoDe,
            this.PhieuTaoDe});
            this.drvDeThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvDeThi.Location = new System.Drawing.Point(10, 10);
            this.drvDeThi.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.drvDeThi.Name = "drvDeThi";
            this.drvDeThi.RowHeadersWidth = 51;
            this.drvDeThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvDeThi.Size = new System.Drawing.Size(445, 405);
            this.drvDeThi.TabIndex = 2;
            this.drvDeThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvDeThi_CellContentClick);
            this.drvDeThi.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.drvDeThi_RowPostPaint_1);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // MaDe
            // 
            this.MaDe.DataPropertyName = "MaDe";
            this.MaDe.HeaderText = "Mã đề";
            this.MaDe.MinimumWidth = 6;
            this.MaDe.Name = "MaDe";
            // 
            // MaPhieuTaoDe
            // 
            this.MaPhieuTaoDe.DataPropertyName = "MaPhieuTaoDe";
            this.MaPhieuTaoDe.HeaderText = "mptd";
            this.MaPhieuTaoDe.MinimumWidth = 6;
            this.MaPhieuTaoDe.Name = "MaPhieuTaoDe";
            this.MaPhieuTaoDe.Visible = false;
            // 
            // PhieuTaoDe
            // 
            this.PhieuTaoDe.DataPropertyName = "PhieuTaoDe";
            this.PhieuTaoDe.HeaderText = "PTD";
            this.PhieuTaoDe.MinimumWidth = 6;
            this.PhieuTaoDe.Name = "PhieuTaoDe";
            this.PhieuTaoDe.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnShow);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 415);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(445, 60);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // frmHienThiDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 485);
            this.Controls.Add(this.drvDeThi);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHienThiDT";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Đề thi";
            this.Load += new System.EventHandler(this.frmHienThiDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drvDeThi)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView drvDeThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuTaoDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhieuTaoDe;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}