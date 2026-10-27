namespace BaiTapWindowsForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        // Click vào nút Xem kết quả
        private void btnXemKq_Click(object sender, EventArgs e)
        {
            int kq = 0;

            if (rdTongAB.Checked)
            {
                if (!int.TryParse(txtSoA.Text, out int a) || !int.TryParse(txtSoB.Text, out int b))
                {
                    MessageBox.Show("Vui lòng nhập số a và số b là số nguyên.", "Thông báo");
                    return;
                }
                // Gọi hàm tĩnh CongHaiSo, kết quả trả về qua tham số kq
                TinhToan.CongHaiSo(a, b, ref kq);
            }
            else
            {
                if (!int.TryParse(txtSoN.Text, out int n) || n < 1)
                {
                    MessageBox.Show("Vui lòng nhập n là số nguyên dương.", "Thông báo");
                    return;
                }
                // Gọi hàm tĩnh TongDaySo
                kq = TinhToan.TongDaySo(n);
            }

            // Hiển thị kết quả
            lblKetQua.Text = "Kết quả là: " + kq.ToString();
        }
    }
}
