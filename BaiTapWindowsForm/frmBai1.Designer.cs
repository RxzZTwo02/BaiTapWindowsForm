namespace BaiTapWindowsForm
{
    partial class frmBai1
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
            lblTieuDe = new Label();
            lblThongBao = new Label();
            SuspendLayout();
            //
            // lblTieuDe
            //
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDe.Location = new Point(40, 25);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(181, 21);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Thông tin hàng hóa:";
            //
            // lblThongBao
            //
            lblThongBao.AutoSize = true;
            lblThongBao.Font = new Font("Segoe UI", 11F);
            lblThongBao.Location = new Point(40, 65);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(80, 20);
            lblThongBao.TabIndex = 1;
            lblThongBao.Text = "lblThongBao";
            //
            // frmBai1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 241);
            Controls.Add(lblThongBao);
            Controls.Add(lblTieuDe);
            Name = "frmBai1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 1";
            Load += frmBai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDe;
        private Label lblThongBao;
    }
}
