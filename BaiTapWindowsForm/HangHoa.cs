namespace BaiTapWindowsForm
{
    // Câu 1a: Lớp đối tượng HangHoa
    public class HangHoa
    {
        // Các thuộc tính
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string DVT { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }

        // Hàm khởi tạo không có tham số
        public HangHoa()
        {
            MaHang = "";
            TenHang = "";
            DVT = "";
            SoLuong = 0;
            DonGia = 0;
        }

        // Phương thức HienThi: hiển thị tất cả thông tin của hàng hóa
        public string HienThi()
        {
            return string.Format(
                "Mã hàng: {0}\nTên hàng: {1}\nĐơn vị tính: {2}\nSố lượng: {3}\nĐơn giá: {4:N0}",
                MaHang, TenHang, DVT, SoLuong, DonGia);
        }
    }
}
