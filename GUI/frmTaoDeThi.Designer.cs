namespace GUI
{
    partial class frmTaoDeThi
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
            this.drvDSPhieu = new System.Windows.Forms.DataGridView();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaoDe = new System.Windows.Forms.Button();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yêuCầuChỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.drvDSPhieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.drvDSPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drvDSPhieu.Location = new System.Drawing.Point(10, 89);
            this.drvDSPhieu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.drvDSPhieu.Name = "drvDSPhieu";
            this.drvDSPhieu.ReadOnly = true;
            this.drvDSPhieu.RowHeadersWidth = 51;
            this.drvDSPhieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.drvDSPhieu.Size = new System.Drawing.Size(631, 354);
            this.drvDSPhieu.TabIndex = 7;
            this.drvDSPhieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvDSPhieu_CellClick);
            this.drvDSPhieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvDSPhieu_CellContentClick);
            this.drvDSPhieu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drvDSPhieu_CellDoubleClick);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimePicker);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 79);
            this.panel1.TabIndex = 6;
            // 
            // txtTimePicker
            // 
            this.txtTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTimePicker.CalendarFont = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimePicker.CustomFormat = "dd/MM/yyyy";
            this.txtTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtTimePicker.Location = new System.Drawing.Point(298, 22);
            this.txtTimePicker.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTimePicker.Name = "txtTimePicker";
            this.txtTimePicker.Size = new System.Drawing.Size(249, 34);
            this.txtTimePicker.TabIndex = 0;
            this.txtTimePicker.ValueChanged += new System.EventHandler(this.txtTimePicker_ValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::GUI.Properties.Resources.Refresh_icon;
            this.btnRefresh.Location = new System.Drawing.Point(570, 13);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(51, 52);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.refresh);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 443);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 14, 0, 0);
            this.panel2.Size = new System.Drawing.Size(631, 83);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnTaoDe);
            this.flowLayoutPanel1.Controls.Add(this.btnThoat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 14);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(631, 69);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSize = true;
            this.btnThoat.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::GUI.Properties.Resources.back;
            this.btnThoat.Location = new System.Drawing.Point(298, 5);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(159, 50);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTaoDe
            // 
            this.btnTaoDe.AutoSize = true;
            this.btnTaoDe.BackColor = System.Drawing.Color.Teal;
            this.btnTaoDe.Enabled = false;
            this.btnTaoDe.FlatAppearance.BorderSize = 0;
            this.btnTaoDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTaoDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDe.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoDe.ForeColor = System.Drawing.Color.White;
            this.btnTaoDe.Image = global::GUI.Properties.Resources.add;
            this.btnTaoDe.Location = new System.Drawing.Point(467, 5);
            this.btnTaoDe.Margin = new System.Windows.Forms.Padding(5, 5, 5, 6);
            this.btnTaoDe.Name = "btnTaoDe";
            this.btnTaoDe.Size = new System.Drawing.Size(159, 50);
            this.btnTaoDe.TabIndex = 0;
            this.btnTaoDe.Text = "Tạo đề";
            this.btnTaoDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaoDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaoDe.UseVisualStyleBackColor = false;
            this.btnTaoDe.Click += new System.EventHandler(this.btnTaoDe_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yêuCầuChỉnhSửaToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(221, 32);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening_1);
            // 
            // yêuCầuChỉnhSửaToolStripMenuItem
            // 
            this.yêuCầuChỉnhSửaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yêuCầuChỉnhSửaToolStripMenuItem.Image = global::GUI.Properties.Resources.warning_icon;
            this.yêuCầuChỉnhSửaToolStripMenuItem.Name = "yêuCầuChỉnhSửaToolStripMenuItem";
            this.yêuCầuChỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(220, 28);
            this.yêuCầuChỉnhSửaToolStripMenuItem.Text = "Yêu cầu chỉnh sửa";
            this.yêuCầuChỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.yêuCầuChỉnhSửaToolStripMenuItem_Click);
            // 
            // frmTaoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 536);
            this.Controls.Add(this.drvDSPhieu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaoDeThi";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Tạo đề thi";
            this.Load += new System.EventHandler(this.frmTaoDeThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drvDSPhieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drvDSPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txtTimePicker;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaoDe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem yêuCầuChỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}