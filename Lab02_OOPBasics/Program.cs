using System;
using System.Collections.Generic;
using System;

class Program
{
    static void Main()
    {
        // Hỗ trợ hiển thị tiếng Việt có dấu
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khởi tạo đối tượng SinhVien và gán dữ liệu mẫu
        SinhVien sv = new SinhVien();
        sv.MaSV = "24001296";
        sv.HoTen = "Nguyễn Duy Hưng";
        sv.NgaySinh = new DateTime(2006, 1, 1);
        sv.DiemTB = 8.5;

        Console.WriteLine("Thông tin sinh viên:");
        sv.HienThi();
    }
}