namespace GUI.UControl
{
    partial class UC_LichThi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.lbPhong = new System.Windows.Forms.Label();
            this.lbMonHoc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbThoiGian);
            this.panel1.Controls.Add(this.lbPhong);
            this.panel1.Controls.Add(this.lbMonHoc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7);
            this.panel1.Size = new System.Drawing.Size(238, 107);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbThoiGian.Location = new System.Drawing.Point(7, 61);
            this.lbThoiGian.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbThoiGian.Size = new System.Drawing.Size(51, 32);
            this.lbThoiGian.TabIndex = 2;
            this.lbThoiGian.Text = "dưqd";
            // 
            // lbPhong
            // 
            this.lbPhong.AutoSize = true;
            this.lbPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPhong.Location = new System.Drawing.Point(7, 29);
            this.lbPhong.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lbPhong.Name = "lbPhong";
            this.lbPhong.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbPhong.Size = new System.Drawing.Size(51, 32);
            this.lbPhong.TabIndex = 1;
            this.lbPhong.Text = "dưqd";
            // 
            // lbMonHoc
            // 
            this.lbMonHoc.AutoSize = true;
            this.lbMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMonHoc.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonHoc.Location = new System.Drawing.Point(7, 7);
            this.lbMonHoc.Name = "lbMonHoc";
            this.lbMonHoc.Size = new System.Drawing.Size(267, 22);
            this.lbMonHoc.TabIndex = 0;
            this.lbMonHoc.Text = "Phân tích thiết kế hệ thôngd";
            this.lbMonHoc.Click += new System.EventHandler(this.lbMonHoc_Click);
            // 
            // UC_LichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_LichThi";
            this.Size = new System.Drawing.Size(238, 107);
            this.SizeChanged += new System.EventHandler(this.UC_LichThi_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMonHoc;
        private System.Windows.Forms.Label lbPhong;
        private System.Windows.Forms.Label lbThoiGian;
    }
}
