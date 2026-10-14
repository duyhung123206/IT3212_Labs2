using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Hỗ trợ hiển thị tiếng Việt có dấu trong Console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // 1. Tạo danh sách SinhVien và thêm dữ liệu mẫu
        List<SinhVien> ds = new List<SinhVien>();
        ds.Add(new SinhVien("24001296", "Nguyễn Duy Hưng", new DateTime(2006, 1, 1), 8.5));
        ds.Add(new SinhVien("SV01", "Nguyễn An", new DateTime(2005, 5, 12), 8.2));
        ds.Add(new SinhVien("SV02", "Trần Bình", new DateTime(2005, 9, 3), 6.8));

        // 2. In danh sách sinh viên
        Console.WriteLine("--- DANH SÁCH SINH VIÊN ---");
        foreach (SinhVien sv in ds)
        {
            sv.HienThi();
        }

        // 3. Tìm kiếm sinh viên theo mã
        Console.Write("\nNhập mã sinh viên cần tìm: ");
        string ma = Console.ReadLine();

        SinhVien ketQua = ds.Find(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine(ketQua == null ? "Không tìm thấy" : $"Đã tìm thấy: {ketQua.HoTen} - Điểm TB: {ketQua.DiemTB}");
    }
}