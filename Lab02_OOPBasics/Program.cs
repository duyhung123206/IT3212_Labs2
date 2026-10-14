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
        ds.Add(new SinhVien("SV01", "Nguyễn An", new DateTime(2005, 5, 12), 8.2)); [cite: 19]
        ds.Add(new SinhVien("SV02", "Trần Bình", new DateTime(2005, 9, 3), 6.8)); [cite: 19]

        // 2. In danh sách sinh viên
        Console.WriteLine("--- DANH SÁCH SINH VIÊN ---");
        foreach (SinhVien sv in ds) [cite: 19]
        {
            sv.HienThi();
        }

        // 3. Tìm kiếm sinh viên theo mã
        Console.Write("\nNhập mã sinh viên cần tìm: "); [cite: 19]
        string ma = Console.ReadLine(); [cite: 19]

        SinhVien ketQua = ds.Find(x => x.MaSV.Equals(ma, StringComparison.OrdinalIgnoreCase)); [cite: 19]

        Console.WriteLine(ketQua == null ? "Không tìm thấy" : $"Đã tìm thấy: {ketQua.HoTen} - Điểm TB: {ketQua.DiemTB}"); [cite: 19]
    }
}