using System.Globalization;

namespace BaiTapWindowsForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void frmBai2_Load(object sender, EventArgs e)
        {
            // Mặc định chọn mặt hàng đầu tiên (Chuột)
            cboTenHang.SelectedIndex = 0;
        }

        // Khi chọn tên hàng thì hiện đơn giá tương ứng
        private void cboTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTenHang.SelectedIndex)
            {
                case 0: // Chuột
                    txtDonGia.Text = "100000";
                    break;
                case 1: // Máy in
                    txtDonGia.Text = "2000000";
                    break;
                case 2: // Bàn phím
                    txtDonGia.Text = "150000";
                    break;
            }
        }

        // Click vào nút Tính tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDonGia.Text, out int donGia) ||
                !int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá và số lượng là số nguyên hợp lệ.", "Thông báo");
                return;
            }

            double thanhTien = donGia * soLuong;

            // Chuyển khoản được giảm 5%, tiền mặt không giảm
            if (rdChuyenKhoan.Checked)
                thanhTien = thanhTien * 0.95;

            // Hiển thị kết quả, định dạng kiểu Việt Nam (vd: 200.000)
            lblSoTien.Text = "Số tiền thanh toán: " + thanhTien.ToString("N0", new CultureInfo("vi-VN"));
        }
    }
}
