using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            // Khởi tạo sinh viên và kiểm tra kết quả hiển thị kèm tuổi và xếp loại
            SinhVien sv = new SinhVien("24001296", "Nguyễn Duy Hưng", new DateTime(2006, 1, 1), 8.5);
            Console.WriteLine("Thông tin chi tiết sinh viên:");
            sv.HienThi();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}