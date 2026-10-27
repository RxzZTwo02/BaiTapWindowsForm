namespace BaiTapWindowsForm
{
    partial class frmChinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tsMain = new ToolStrip();
            tsbBai1 = new ToolStripButton();
            tsbBai2 = new ToolStripButton();
            tsbBai3 = new ToolStripButton();
            tsMain.SuspendLayout();
            SuspendLayout();
            //
            // tsMain
            //
            tsMain.Items.AddRange(new ToolStripItem[] { tsbBai1, tsbBai2, tsbBai3 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(484, 25);
            tsMain.TabIndex = 0;
            tsMain.Text = "toolStrip1";
            //
            // tsbBai1
            //
            tsbBai1.Image = Properties.Resources.icon_bai;
            tsbBai1.ImageTransparentColor = Color.Magenta;
            tsbBai1.Name = "tsbBai1";
            tsbBai1.Size = new Size(54, 22);
            tsbBai1.Text = "Bài 1";
            tsbBai1.Click += tsbBai1_Click;
            //
            // tsbBai2
            //
            tsbBai2.Image = Properties.Resources.icon_bai;
            tsbBai2.ImageTransparentColor = Color.Magenta;
            tsbBai2.Name = "tsbBai2";
            tsbBai2.Size = new Size(54, 22);
            tsbBai2.Text = "Bài 2";
            tsbBai2.Click += tsbBai2_Click;
            //
            // tsbBai3
            //
            tsbBai3.Image = Properties.Resources.icon_bai;
            tsbBai3.ImageTransparentColor = Color.Magenta;
            tsbBai3.Name = "tsbBai3";
            tsbBai3.Size = new Size(54, 22);
            tsbBai3.Text = "Bài 3";
            tsbBai3.Click += tsbBai3_Click;
            //
            // frmChinh
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 211);
            Controls.Add(tsMain);
            Name = "frmChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chương trình chính";
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsMain;
        private ToolStripButton tsbBai1;
        private ToolStripButton tsbBai2;
        private ToolStripButton tsbBai3;
    }
}
