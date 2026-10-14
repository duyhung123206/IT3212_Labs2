using System;

class Program
{
    static void Main()
    {
        // Hỗ trợ hiển thị tiếng Việt có dấu trong Console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            // Khởi tạo hình chữ nhật với chiều dài và chiều rộng
            HinhChuNhat hcn = new HinhChuNhat(12.5, 5.0);

            Console.WriteLine("--- KẾT QUẢ HÌNH CHỮ NHẬT ---");
            hcn.HienThi();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}