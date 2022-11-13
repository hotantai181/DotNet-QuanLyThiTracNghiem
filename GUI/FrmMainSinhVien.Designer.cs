namespace GUI
{
    partial class FrmMainSinhVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnXemLichThi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHome,
            this.mnXemLichThi,
            this.mnThi,
            this.mnDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHome
            // 
            this.mnHome.Name = "mnHome";
            this.mnHome.Size = new System.Drawing.Size(70, 26);
            this.mnHome.Text = "Home";
            this.mnHome.Click += new System.EventHandler(this.mnHome_Click);
            // 
            // mnXemLichThi
            // 
            this.mnXemLichThi.Name = "mnXemLichThi";
            this.mnXemLichThi.Size = new System.Drawing.Size(116, 26);
            this.mnXemLichThi.Text = "Xem lịch thi";
            this.mnXemLichThi.Click += new System.EventHandler(this.mnXemLichThi_Click);
            // 
            // mnThi
            // 
            this.mnThi.Name = "mnThi";
            this.mnThi.Size = new System.Drawing.Size(49, 26);
            this.mnThi.Text = "Thi";
            this.mnThi.Click += new System.EventHandler(this.mnThi_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(106, 26);
            this.mnDangXuat.Text = "Đăng xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // FrmMainSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 510);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMainSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainSinhVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainSinhVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHome;
        private System.Windows.Forms.ToolStripMenuItem mnXemLichThi;
        private System.Windows.Forms.ToolStripMenuItem mnThi;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
    }
}