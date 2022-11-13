namespace GUI.UControl
{
    partial class UCCauHoiThi
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
            this.pnWrap = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoBtnA = new System.Windows.Forms.RadioButton();
            this.rdoBtnB = new System.Windows.Forms.RadioButton();
            this.rdoBtnC = new System.Windows.Forms.RadioButton();
            this.rdoBtnD = new System.Windows.Forms.RadioButton();
            this.pnCauHoi = new System.Windows.Forms.Panel();
            this.lbCau = new System.Windows.Forms.Label();
            this.pnWrap.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnCauHoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnWrap
            // 
            this.pnWrap.Controls.Add(this.flowLayoutPanel1);
            this.pnWrap.Controls.Add(this.pnCauHoi);
            this.pnWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnWrap.Location = new System.Drawing.Point(0, 0);
            this.pnWrap.Name = "pnWrap";
            this.pnWrap.Size = new System.Drawing.Size(279, 50);
            this.pnWrap.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rdoBtnA);
            this.flowLayoutPanel1.Controls.Add(this.rdoBtnB);
            this.flowLayoutPanel1.Controls.Add(this.rdoBtnC);
            this.flowLayoutPanel1.Controls.Add(this.rdoBtnD);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(66, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(213, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // rdoBtnA
            // 
            this.rdoBtnA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoBtnA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnA.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnA.Location = new System.Drawing.Point(3, 10);
            this.rdoBtnA.Name = "rdoBtnA";
            this.rdoBtnA.Size = new System.Drawing.Size(42, 26);
            this.rdoBtnA.TabIndex = 7;
            this.rdoBtnA.TabStop = true;
            this.rdoBtnA.Tag = "A";
            this.rdoBtnA.Text = "A";
            this.rdoBtnA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnA.UseVisualStyleBackColor = true;
            this.rdoBtnA.CheckedChanged += new System.EventHandler(this.rdoBtnA_CheckedChanged);
            // 
            // rdoBtnB
            // 
            this.rdoBtnB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoBtnB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnB.Location = new System.Drawing.Point(51, 10);
            this.rdoBtnB.Name = "rdoBtnB";
            this.rdoBtnB.Size = new System.Drawing.Size(42, 26);
            this.rdoBtnB.TabIndex = 8;
            this.rdoBtnB.TabStop = true;
            this.rdoBtnB.Tag = "B";
            this.rdoBtnB.Text = "B";
            this.rdoBtnB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnB.UseVisualStyleBackColor = true;
            this.rdoBtnB.CheckedChanged += new System.EventHandler(this.rdoBtnA_CheckedChanged);
            // 
            // rdoBtnC
            // 
            this.rdoBtnC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoBtnC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnC.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnC.Location = new System.Drawing.Point(99, 10);
            this.rdoBtnC.Name = "rdoBtnC";
            this.rdoBtnC.Size = new System.Drawing.Size(42, 26);
            this.rdoBtnC.TabIndex = 9;
            this.rdoBtnC.TabStop = true;
            this.rdoBtnC.Tag = "C";
            this.rdoBtnC.Text = "C";
            this.rdoBtnC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnC.UseVisualStyleBackColor = true;
            this.rdoBtnC.CheckedChanged += new System.EventHandler(this.rdoBtnA_CheckedChanged);
            // 
            // rdoBtnD
            // 
            this.rdoBtnD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoBtnD.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdoBtnD.Location = new System.Drawing.Point(147, 10);
            this.rdoBtnD.Name = "rdoBtnD";
            this.rdoBtnD.Size = new System.Drawing.Size(42, 26);
            this.rdoBtnD.TabIndex = 10;
            this.rdoBtnD.TabStop = true;
            this.rdoBtnD.Tag = "D";
            this.rdoBtnD.Text = "D";
            this.rdoBtnD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoBtnD.UseVisualStyleBackColor = true;
            this.rdoBtnD.CheckedChanged += new System.EventHandler(this.rdoBtnA_CheckedChanged);
            // 
            // pnCauHoi
            // 
            this.pnCauHoi.AutoSize = true;
            this.pnCauHoi.Controls.Add(this.lbCau);
            this.pnCauHoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnCauHoi.Location = new System.Drawing.Point(0, 0);
            this.pnCauHoi.Name = "pnCauHoi";
            this.pnCauHoi.Size = new System.Drawing.Size(66, 50);
            this.pnCauHoi.TabIndex = 0;
            // 
            // lbCau
            // 
            this.lbCau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCau.AutoSize = true;
            this.lbCau.Location = new System.Drawing.Point(1, 14);
            this.lbCau.Name = "lbCau";
            this.lbCau.Size = new System.Drawing.Size(62, 22);
            this.lbCau.TabIndex = 6;
            this.lbCau.Text = "Câu 1:";
            this.lbCau.Click += new System.EventHandler(this.lbCau_Click);
            // 
            // UCCauHoiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnWrap);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCCauHoiThi";
            this.Size = new System.Drawing.Size(279, 50);
            this.Load += new System.EventHandler(this.UCCauHoiThi_Load);
            this.pnWrap.ResumeLayout(false);
            this.pnWrap.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnCauHoi.ResumeLayout(false);
            this.pnCauHoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.RadioButton rdoBtnD;
        public System.Windows.Forms.RadioButton rdoBtnC;
        public System.Windows.Forms.RadioButton rdoBtnB;
        public System.Windows.Forms.RadioButton rdoBtnA;
        public System.Windows.Forms.Label lbCau;
        public System.Windows.Forms.Panel pnCauHoi;
        private System.Windows.Forms.Panel pnWrap;
    }
}
