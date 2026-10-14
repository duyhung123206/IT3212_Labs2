using System;

public class SinhVien
{
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public double DiemTB { get; set; }

    // 1. Constructor không tham số (mặc định)
    public SinhVien()
    {
        MaSV = "Chưa có";
        HoTen = "Chưa có";
        NgaySinh = DateTime.Today;
        DiemTB = 0;
    }

    // 2. Constructor đầy đủ tham số (nạp chồng constructor)
    public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double diemTB)
    {
        MaSV = maSV;
        HoTen = hoTen;
        NgaySinh = ngaySinh;
        DiemTB = diemTB;
    }

    public void HienThi()
    {
        Console.WriteLine("{0} - {1} - {2:dd/MM/yyyy} - {3:N2}",
            MaSV, HoTen, NgaySinh, DiemTB);
    }
}