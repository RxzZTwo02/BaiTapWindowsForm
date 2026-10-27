namespace BaiTapWindowsForm
{
    partial class frmBai3
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
            txtSoA = new TextBox();
            txtSoB = new TextBox();
            txtSoN = new TextBox();
            grpPhepToan = new GroupBox();
            rdTongN = new RadioButton();
            rdTongAB = new RadioButton();
            btnXemKq = new Button();
            lblKetQua = new Label();
            grpPhepToan.SuspendLayout();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(45, 28);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Số a =";
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(45, 58);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Số b =";
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(45, 88);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Số n =";
            //
            // txtSoA
            //
            txtSoA.Location = new Point(100, 25);
            txtSoA.Name = "txtSoA";
            txtSoA.Size = new Size(120, 23);
            txtSoA.TabIndex = 1;
            txtSoA.Text = "0";
            //
            // txtSoB
            //
            txtSoB.Location = new Point(100, 55);
            txtSoB.Name = "txtSoB";
            txtSoB.Size = new Size(120, 23);
            txtSoB.TabIndex = 3;
            txtSoB.Text = "0";
            //
            // txtSoN
            //
            txtSoN.Location = new Point(100, 85);
            txtSoN.Name = "txtSoN";
            txtSoN.Size = new Size(120, 23);
            txtSoN.TabIndex = 5;
            txtSoN.Text = "0";
            //
            // grpPhepToan
            //
            grpPhepToan.Controls.Add(rdTongN);
            grpPhepToan.Controls.Add(rdTongAB);
            grpPhepToan.Location = new Point(45, 122);
            grpPhepToan.Name = "grpPhepToan";
            grpPhepToan.Size = new Size(200, 80);
            grpPhepToan.TabIndex = 6;
            grpPhepToan.TabStop = false;
            grpPhepToan.Text = "Chọn phép toán";
            //
            // rdTongN
            //
            rdTongN.AutoSize = true;
            rdTongN.Location = new Point(15, 48);
            rdTongN.Name = "rdTongN";
            rdTongN.Size = new Size(127, 19);
            rdTongN.TabIndex = 1;
            rdTongN.Text = "Tính tổng từ 1 đến n";
            rdTongN.UseVisualStyleBackColor = true;
            //
            // rdTongAB
            //
            rdTongAB.AutoSize = true;
            rdTongAB.Checked = true;
            rdTongAB.Location = new Point(15, 23);
            rdTongAB.Name = "rdTongAB";
            rdTongAB.Size = new Size(118, 19);
            rdTongAB.TabIndex = 0;
            rdTongAB.TabStop = true;
            rdTongAB.Text = "Tính tổng của a, b";
            rdTongAB.UseVisualStyleBackColor = true;
            //
            // btnXemKq
            //
            btnXemKq.Location = new Point(85, 218);
            btnXemKq.Name = "btnXemKq";
            btnXemKq.Size = new Size(100, 28);
            btnXemKq.TabIndex = 7;
            btnXemKq.Text = "Xem kết quả";
            btnXemKq.UseVisualStyleBackColor = true;
            btnXemKq.Click += btnXemKq_Click;
            //
            // lblKetQua
            //
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 12F);
            lblKetQua.Location = new Point(45, 262);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(84, 21);
            lblKetQua.TabIndex = 8;
            lblKetQua.Text = "Kết quả là:";
            //
            // frmBai3
            //
            AcceptButton = btnXemKq;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 311);
            Controls.Add(lblKetQua);
            Controls.Add(btnXemKq);
            Controls.Add(grpPhepToan);
            Controls.Add(txtSoN);
            Controls.Add(txtSoB);
            Controls.Add(txtSoA);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBai3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 3";
            grpPhepToan.ResumeLayout(false);
            grpPhepToan.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSoA;
        private TextBox txtSoB;
        private TextBox txtSoN;
        private GroupBox grpPhepToan;
        private RadioButton rdTongN;
        private RadioButton rdTongAB;
        private Button btnXemKq;
        private Label lblKetQua;
    }
}
