namespace BaiTapWindowsForm
{
    partial class frmBai2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboTenHang = new ComboBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            grpThanhToan = new GroupBox();
            rdTienMat = new RadioButton();
            rdChuyenKhoan = new RadioButton();
            btnTinhTien = new Button();
            lblSoTien = new Label();
            grpThanhToan.SuspendLayout();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(40, 28);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên hàng:";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(48, 60);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Đơn giá:";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(40, 92);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Số lượng:";
            //
            // cboTenHang
            //
            cboTenHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTenHang.FormattingEnabled = true;
            cboTenHang.Items.AddRange(new object[] { "Chuột", "Máy in", "Bàn phím" });
            cboTenHang.Location = new Point(110, 25);
            cboTenHang.Name = "cboTenHang";
            cboTenHang.Size = new Size(160, 23);
            cboTenHang.TabIndex = 1;
            cboTenHang.SelectedIndexChanged += cboTenHang_SelectedIndexChanged;
            //
            // txtDonGia
            //
            txtDonGia.Location = new Point(110, 57);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(120, 23);
            txtDonGia.TabIndex = 3;
            //
            // txtSoLuong
            //
            txtSoLuong.Location = new Point(110, 89);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(70, 23);
            txtSoLuong.TabIndex = 5;
            txtSoLuong.Text = "1";
            //
            // grpThanhToan
            //
            grpThanhToan.Controls.Add(rdTienMat);
            grpThanhToan.Controls.Add(rdChuyenKhoan);
            grpThanhToan.Location = new Point(110, 122);
            grpThanhToan.Name = "grpThanhToan";
            grpThanhToan.Size = new Size(170, 80);
            grpThanhToan.TabIndex = 6;
            grpThanhToan.TabStop = false;
            grpThanhToan.Text = "Hình thức thanh toán:";
            //
            // rdTienMat
            //
            rdTienMat.AutoSize = true;
            rdTienMat.Checked = true;
            rdTienMat.Location = new Point(12, 48);
            rdTienMat.Name = "rdTienMat";
            rdTienMat.Size = new Size(70, 19);
            rdTienMat.TabIndex = 1;
            rdTienMat.TabStop = true;
            rdTienMat.Text = "Tiền mặt";
            rdTienMat.UseVisualStyleBackColor = true;
            //
            // rdChuyenKhoan
            //
            rdChuyenKhoan.AutoSize = true;
            rdChuyenKhoan.Location = new Point(12, 23);
            rdChuyenKhoan.Name = "rdChuyenKhoan";
            rdChuyenKhoan.Size = new Size(97, 19);
            rdChuyenKhoan.TabIndex = 0;
            rdChuyenKhoan.Text = "Chuyển khoản";
            rdChuyenKhoan.UseVisualStyleBackColor = true;
            //
            // btnTinhTien
            //
            btnTinhTien.Location = new Point(122, 218);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(100, 28);
            btnTinhTien.TabIndex = 7;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            //
            // lblSoTien
            //
            lblSoTien.AutoSize = true;
            lblSoTien.Font = new Font("Segoe UI", 12F);
            lblSoTien.Location = new Point(25, 265);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(147, 21);
            lblSoTien.TabIndex = 8;
            lblSoTien.Text = "Số tiền thanh toán:";
            //
            // frmBai2
            //
            AcceptButton = btnTinhTien;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 311);
            Controls.Add(lblSoTien);
            Controls.Add(btnTinhTien);
            Controls.Add(grpThanhToan);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(cboTenHang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBai2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 2";
            Load += frmBai2_Load;
            grpThanhToan.ResumeLayout(false);
            grpThanhToan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboTenHang;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private GroupBox grpThanhToan;
        private RadioButton rdTienMat;
        private RadioButton rdChuyenKhoan;
        private Button btnTinhTien;
        private Label lblSoTien;
    }
}
