using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Sử dụng constructor không tham số
        SinhVien sv1 = new SinhVien();
        Console.WriteLine("Thông tin sinh viên 1 (Dùng constructor mặc định):");
        sv1.HienThi();

        Console.WriteLine();

        // Sử dụng constructor đầy đủ tham số
        SinhVien sv2 = new SinhVien("24001296", "Nguyễn Duy Hưng", new DateTime(2006, 1, 1), 8.5);
        Console.WriteLine("Thông tin sinh viên 2 (Dùng constructor có tham số):");
        sv2.HienThi();
    }
}