using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            // Thử nhập dữ liệu hợp lệ trước
            SinhVien sv1 = new SinhVien("24001296", "Nguyễn Duy Hưng", new DateTime(2006, 1, 1), 8.5);
            Console.WriteLine("Thông tin sinh viên hợp lệ:");
            sv1.HienThi();

            Console.WriteLine("\n--- Thử nghiệm kiểm tra dữ liệu không hợp lệ ---");

            // Thử gán điểm sai quy định (ví dụ 12 điểm) để kiểm tra ngoại lệ
            SinhVien sv2 = new SinhVien();
            sv2.DiemTB = 12.0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bắt được lỗi dữ liệu: " + ex.Message);
        }
    }
}