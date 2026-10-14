using System;

public class NhanVien
{
    public string MaNV { get; set; }
    public string HoTen { get; set; }
    public double LuongCoBan { get; set; }
    public double HeSoLuong { get; set; }
    public double PhuCap { get; set; }

    public NhanVien(string maNV, string hoTen, double luongCoBan, double heSoLuong, double phuCap)
    {
        MaNV = maNV;
        HoTen = hoTen;
        LuongCoBan = luongCoBan;
        HeSoLuong = heSoLuong;
        PhuCap = phuCap;
    }

    public double TinhThucLinh()
    {
        return LuongCoBan * HeSoLuong + PhuCap;
    }

    public void HienThi()
    {
        Console.WriteLine($"Mã NV: {MaNV} - Họ tên: {HoTen} - Lương thực lĩnh: {TinhThucLinh():N0} VNĐ");
    }
}
