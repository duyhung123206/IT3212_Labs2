using System;

class Program
{
    static void Main()
    {
        // Hỗ trợ hiển thị tiếng Việt có dấu trong Console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            // Khởi tạo đối tượng Nhân viên (Mã NV, Họ tên, Lương cơ bản, Hệ số lương, Phụ cấp)
            NhanVien nv = new NhanVien("NV01", "Nguyễn Duy Hưng", 3000000, 2.34, 500000);

            Console.WriteLine("--- BẢNG LƯƠNG NHÂN VIÊN ---");
            nv.HienThi();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}