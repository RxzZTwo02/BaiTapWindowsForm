namespace BaiTapWindowsForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        // Câu 1b: Khai báo và sử dụng biến đối tượng HangHoa khi form được mở
        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHang = "HH01";
            hh.TenHang = "Chuột";
            hh.DVT = "Cái";
            hh.SoLuong = 4;
            hh.DonGia = 200000;

            // Hiển thị kết quả sử dụng lblThongBao
            lblThongBao.Text = hh.HienThi();
        }
    }
}
