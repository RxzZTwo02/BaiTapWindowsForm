namespace BaiTapWindowsForm
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        // Click vào nút Bài 1 trên toolbar
        private void tsbBai1_Click(object sender, EventArgs e)
        {
            // Mở form Bài 1
            var form = new frmBai1();
            form.ShowDialog();
        }

        // Click vào nút Bài 2 trên toolbar
        private void tsbBai2_Click(object sender, EventArgs e)
        {
            // Mở form Bài 2
            var form = new frmBai2();
            form.ShowDialog();
        }

        // Click vào nút Bài 3 trên toolbar
        private void tsbBai3_Click(object sender, EventArgs e)
        {
            // Mở form Bài 3
            var form = new frmBai3();
            form.ShowDialog();
        }
    }
}
