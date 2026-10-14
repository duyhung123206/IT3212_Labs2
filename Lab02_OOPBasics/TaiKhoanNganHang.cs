using System;

public class TaiKhoanNganHang
{
    private double _soDu;

    public string SoTaiKhoan { get; set; }
    public string TenChuTaiKhoan { get; set; }

    public double SoDu
    {
        get { return _soDu; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Số dư tài khoản không được âm.");
            _soDu = value;
        }
    }

    public TaiKhoanNganHang(string soTaiKhoan, string tenChuTaiKhoan, double soDuBanDau)
    {
        SoTaiKhoan = soTaiKhoan;
        TenChuTaiKhoan = tenChuTaiKhoan;
        SoDu = soDuBanDau;
    }

    // Nạp tiền
    public void NapTien(double soTien)
    {
        if (soTien <= 0) throw new ArgumentException("Số tiền nạp phải lớn hơn 0.");
        SoDu += soTien;
    }

    // Rút tiền
    public void RutTien(double soTien)
    {
        if (soTien <= 0) throw new ArgumentException("Số tiền rút phải lớn hơn 0.");
        if (soTien > SoDu) throw new InvalidOperationException("Số dư không đủ để rút.");
        SoDu -= soTien;
    }

    // Chuyển tiền
    public void ChuyenTien(TaiKhoanNganHang taiKhoanNhan, double soTien)
    {
        RutTien(soTien);
        taiKhoanNhan.NapTien(soTien);
    }

    public void HienThi()
    {
        Console.WriteLine($"TK: {SoTaiKhoan} - Chủ TK: {TenChuTaiKhoan} - Số dư: {SoDu:N0} VNĐ");
    }
}