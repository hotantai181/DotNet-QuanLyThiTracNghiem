
namespace GUI
{
    partial class FrmMain
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
            this.mnHome = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnResetMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongTinSv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQlNHCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQLPhucKhao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQLPhieuTaoDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTaoPhieuTaoDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTaoDe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDS = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSaoLuu = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPhucHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKeDiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongKeDiemTheoPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnHome
            // 
            this.mnHome.Name = "mnHome";
            this.mnHome.Size = new System.Drawing.Size(70, 26);
            this.mnHome.Text = "Home";
            this.mnHome.Click += new System.EventHandler(this.mnHome_Click);
            // 
            // quảnLýChungToolStripMenuItem
            // 
            this.quảnLýChungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSinhViênToolStripMenuItem,
            this.mnQlNHCauHoi,
            this.mnQLPhucKhao,
            this.mnQLPhieuTaoDe});
            this.quảnLýChungToolStripMenuItem.Name = "quảnLýChungToolStripMenuItem";
            this.quảnLýChungToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.quảnLýChungToolStripMenuItem.Text = "Quản lý chung";
            this.quảnLýChungToolStripMenuItem.Click += new System.EventHandler(this.quảnLýChungToolStripMenuItem_Click);
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnResetMK,
            this.mnThongTinSv});
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
            // 
            // mnResetMK
            // 
            this.mnResetMK.Name = "mnResetMK";
            this.mnResetMK.Size = new System.Drawing.Size(247, 26);
            this.mnResetMK.Text = "Reset mật khẩu";
            this.mnResetMK.Click += new System.EventHandler(this.mnResetMK_Click);
            // 
            // mnThongTinSv
            // 
            this.mnThongTinSv.Name = "mnThongTinSv";
            this.mnThongTinSv.Size = new System.Drawing.Size(247, 26);
            this.mnThongTinSv.Text = "Thông tin sinh viên";
            this.mnThongTinSv.Click += new System.EventHandler(this.mnThongTinSv_Click);
            // 
            // mnQlNHCauHoi
            // 
            this.mnQlNHCauHoi.Name = "mnQlNHCauHoi";
            this.mnQlNHCauHoi.Size = new System.Drawing.Size(327, 26);
            this.mnQlNHCauHoi.Text = "Quản lý ngân hàng câu hỏi";
            this.mnQlNHCauHoi.Click += new System.EventHandler(this.mnQlNHCauHoi_Click);
            // 
            // mnQLPhucKhao
            // 
            this.mnQLPhucKhao.Name = "mnQLPhucKhao";
            this.mnQLPhucKhao.Size = new System.Drawing.Size(327, 26);
            this.mnQLPhucKhao.Text = "Quản lý phúc khảo";
            this.mnQLPhucKhao.Click += new System.EventHandler(this.mnQLPhucKhao_Click);
            // 
            // mnQLPhieuTaoDe
            // 
            this.mnQLPhieuTaoDe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTaoPhieuTaoDe,
            this.mnTaoDe,
            this.mnDS});
            this.mnQLPhieuTaoDe.Name = "mnQLPhieuTaoDe";
            this.mnQLPhieuTaoDe.Size = new System.Drawing.Size(327, 26);
            this.mnQLPhieuTaoDe.Text = "Quản lý phiếu yêu cầu tạo đề";
            this.mnQLPhieuTaoDe.Click += new System.EventHandler(this.mnQLPhieuTaoDe_Click);
            // 
            // mnTaoPhieuTaoDe
            // 
            this.mnTaoPhieuTaoDe.Name = "mnTaoPhieuTaoDe";
            this.mnTaoPhieuTaoDe.Size = new System.Drawing.Size(229, 26);
            this.mnTaoPhieuTaoDe.Text = "Tạo phiếu tạo đề";
            this.mnTaoPhieuTaoDe.Click += new System.EventHandler(this.mnTaoPhieuTaoDe_Click);
            // 
            // mnTaoDe
            // 
            this.mnTaoDe.Name = "mnTaoDe";
            this.mnTaoDe.Size = new System.Drawing.Size(229, 26);
            this.mnTaoDe.Text = "Tạo đề";
            this.mnTaoDe.Click += new System.EventHandler(this.mnTaoDe_Click);
            // 
            // mnDS
            // 
            this.mnDS.Checked = true;
            this.mnDS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnDS.Name = "mnDS";
            this.mnDS.Size = new System.Drawing.Size(229, 26);
            this.mnDS.Text = "Danh sách đề thi";
            this.mnDS.Visible = false;
            this.mnDS.Click += new System.EventHandler(this.mnDS_Click);
            // 
            // mnSaoLuu
            // 
            this.mnSaoLuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem,
            this.mnPhucHoi,
            this.mnDoiMatKhau});
            this.mnSaoLuu.Name = "mnSaoLuu";
            this.mnSaoLuu.Size = new System.Drawing.Size(97, 26);
            this.mnSaoLuu.Text = "Hệ thống";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.saoLưuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saoLưuToolStripMenuItem.Text = "Sao Lưu";
            this.saoLưuToolStripMenuItem.Click += new System.EventHandler(this.saoLưuToolStripMenuItem_Click);
            // 
            // mnPhucHoi
            // 
            this.mnPhucHoi.Name = "mnPhucHoi";
            this.mnPhucHoi.Size = new System.Drawing.Size(224, 26);
            this.mnPhucHoi.Text = "Phục hồi";
            this.mnPhucHoi.Click += new System.EventHandler(this.mnPhucHoi_Click);
            // 
            // mnDoiMatKhau
            // 
            this.mnDoiMatKhau.Name = "mnDoiMatKhau";
            this.mnDoiMatKhau.Size = new System.Drawing.Size(224, 26);
            this.mnDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHome,
            this.quảnLýChungToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.mnSaoLuu,
            this.dangXuatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1419, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongKeDiem,
            this.mnThongKeDiemTheoPhong});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // mnThongKeDiem
            // 
            this.mnThongKeDiem.Name = "mnThongKeDiem";
            this.mnThongKeDiem.Size = new System.Drawing.Size(336, 26);
            this.mnThongKeDiem.Text = "Thống kê điểm";
            this.mnThongKeDiem.Click += new System.EventHandler(this.mnThongKeDiem_Click);
            // 
            // mnThongKeDiemTheoPhong
            // 
            this.mnThongKeDiemTheoPhong.Name = "mnThongKeDiemTheoPhong";
            this.mnThongKeDiemTheoPhong.Size = new System.Drawing.Size(336, 26);
            this.mnThongKeDiemTheoPhong.Text = "Thống kê điểm theo phòng thi";
            this.mnThongKeDiemTheoPhong.Click += new System.EventHandler(this.mnThongKeDiemTheoPhong_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1419, 740);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnHome;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSaoLuu;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnPhucHoi;
        private System.Windows.Forms.ToolStripMenuItem mnDoiMatKhau;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnQlNHCauHoi;
        private System.Windows.Forms.ToolStripMenuItem mnResetMK;
        private System.Windows.Forms.ToolStripMenuItem mnThongTinSv;
        private System.Windows.Forms.ToolStripMenuItem mnQLPhucKhao;
        private System.Windows.Forms.ToolStripMenuItem mnQLPhieuTaoDe;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnThongKeDiem;
        private System.Windows.Forms.ToolStripMenuItem mnTaoPhieuTaoDe;
        private System.Windows.Forms.ToolStripMenuItem mnThongKeDiemTheoPhong;
        private System.Windows.Forms.ToolStripMenuItem mnTaoDe;
        private System.Windows.Forms.ToolStripMenuItem mnDS;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
    }
}
//            // 
//            // mnPhucHoi
//            // 
//            this.mnPhucHoi.Name = "mnPhucHoi";
//            this.mnPhucHoi.Size = new System.Drawing.Size(224, 26);
//            this.mnPhucHoi.Text = "Phục hồi";
//            // 
//            // mnDoiMatKhau
//            // 
//            this.mnDoiMatKhau.Name = "mnDoiMatKhau";
//            this.mnDoiMatKhau.Size = new System.Drawing.Size(224, 26);
//            this.mnDoiMatKhau.Text = "Đổi mật khẩu";
//            // 
//            // mnDangXuat
//            // 
//            this.mnDangXuat.Name = "mnDangXuat";
//            this.mnDangXuat.Size = new System.Drawing.Size(224, 26);
//            this.mnDangXuat.Text = "Đăng xuất";
//            // 
//            // menuStrip1
//            // 
//            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
//            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.mnHome,
//            this.quảnLýChungToolStripMenuItem,
//            this.thốngKêToolStripMenuItem,
//            this.mnSaoLuu});
//            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
//            this.menuStrip1.Name = "menuStrip1";
//            this.menuStrip1.Size = new System.Drawing.Size(1380, 30);
//            this.menuStrip1.TabIndex = 0;
//            this.menuStrip1.Text = "menuStrip1";
//            // 
//            // thốngKêToolStripMenuItem
//            // 
//            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.mnThongKeDiem});
//            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
//            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
//            this.thốngKêToolStripMenuItem.Text = "Thống kê";
//            // 
//            // mnThongKeDiem
//            // 
//            this.mnThongKeDiem.Name = "mnThongKeDiem";
//            this.mnThongKeDiem.Size = new System.Drawing.Size(224, 26);
//            this.mnThongKeDiem.Text = "Thống kê điểm";
//            // 
//            // FrmMain
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.White;
//            this.ClientSize = new System.Drawing.Size(1380, 740);
//            this.Controls.Add(this.menuStrip1);
//            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.IsMdiContainer = true;
//            this.MainMenuStrip = this.menuStrip1;
//            this.Margin = new System.Windows.Forms.Padding(4);
//            this.Name = "FrmMain";
//            this.Text = "FrmMain";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
//            this.Load += new System.EventHandler(this.FrmMain_Load);
//            this.menuStrip1.ResumeLayout(false);
//            this.menuStrip1.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.ToolStripMenuItem mnHome;
//        private System.Windows.Forms.ToolStripMenuItem quảnLýChungToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem mnSaoLuu;
//        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem mnPhucHoi;
//        private System.Windows.Forms.ToolStripMenuItem mnDoiMatKhau;
//        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
//        private System.Windows.Forms.MenuStrip menuStrip1;
//        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem mnQlNHCauHoi;
//        private System.Windows.Forms.ToolStripMenuItem mnResetMK;
//        private System.Windows.Forms.ToolStripMenuItem mnThongTinSv;
//        private System.Windows.Forms.ToolStripMenuItem mnQuanLyDiem;
//        private System.Windows.Forms.ToolStripMenuItem mnQLPhucKhao;
//        private System.Windows.Forms.ToolStripMenuItem mnQLPhieuTaoDe;
//        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
//        private System.Windows.Forms.ToolStripMenuItem mnThongKeDiem;
//        private System.Windows.Forms.ToolStripMenuItem mnDsPhieuTaoDe;
//        private System.Windows.Forms.ToolStripMenuItem mnTaoPhieuTaoDe;
//    }
//}