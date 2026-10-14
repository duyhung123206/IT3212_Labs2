using System;

public class SanPham
{
    private string _tenSP;
    private double _donGia;
    private int _soLuong;

    public string MaSP { get; set; }

    public string TenSP
    {
        get { return _tenSP; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tên sản phẩm không được rỗng.");
            _tenSP = value.Trim();
        }
    }

    public double DonGia
    {
        get { return _donGia; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("DonGia", "Đơn giá không được âm.");
            _donGia = value;
        }
    }

    public int SoLuong
    {
        get { return _soLuong; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("SoLuong", "Số lượng không được âm.");
            _soLuong = value;
        }
    }

    // Constructor không tham số
    public SanPham()
    {
        MaSP = "SP00";
        TenSP = "Chưa có";
        DonGia = 0;
        SoLuong = 0;
    }

    // Constructor có tham số
    public SanPham(string maSP, string tenSP, double donGia, int soLuong)
    {
        MaSP = maSP;
        TenSP = tenSP;
        DonGia = donGia;
        SoLuong = soLuong;
    }

    // Phương thức tính thành tiền
    public double TinhThanhTien()
    {
        return DonGia * SoLuong;
    }

    public void HienThi()
    {
        Console.WriteLine("{0} - {1} - Đơn giá: {2:N0} - SL: {3} - Thành tiền: {4:N0}",
            MaSP, TenSP, DonGia, SoLuong, TinhThanhTien());
    }
}
