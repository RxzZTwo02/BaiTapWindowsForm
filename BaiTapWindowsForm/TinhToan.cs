namespace BaiTapWindowsForm
{
    // Câu 3a: Lớp chứa các phương thức tĩnh
    public class TinhToan
    {
        // Cộng hai số a và b, kết quả trả về cho tham số s
        public static void CongHaiSo(int a, int b, ref int s)
        {
            s = a + b;
        }

        // Tính tổng các số nguyên liên tục từ 1 đến n
        public static int TongDaySo(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }
            return tong;
        }
    }
}
