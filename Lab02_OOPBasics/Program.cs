using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            // Khởi tạo tài khoản ngân hàng và thử nghiệm nạp/rút tiền
            TaiKhoanNganHang tk = new TaiKhoanNganHang("123456789", "Nguyễn Duy Hưng", 5000000);
            Console.WriteLine("Thông tin tài khoản ban đầu:");
            tk.HienThi();

            Console.WriteLine("\nThực hiện nạp thêm 2,000,000 VNĐ...");
            tk.NapTien(2000000);
            tk.HienThi();

            Console.WriteLine("\nThực hiện rút 1,500,000 VNĐ...");
            tk.RutTien(1500000);
            tk.HienThi();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi giao dịch: " + ex.Message);
        }
    }
}