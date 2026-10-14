using System;

public class SinhVien
{
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public double DiemTB { get; set; }

    public void HienThi()
    {
        Console.WriteLine("{0} - {1} - {2:dd/MM/yyyy} - {3:N2}",
            MaSV, HoTen, NgaySinh, DiemTB);
    }
}