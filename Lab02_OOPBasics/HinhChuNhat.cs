using System;

public class HinhChuNhat
{
    private double _chieuDai;
    private double _chieuRong;

    public double ChieuDai
    {
        get { return _chieuDai; }
        set
        {
            if (value <= 0) throw new ArgumentException("Chiều dài phải lớn hơn 0.");
            _chieuDai = value;
        }
    }

    public double ChieuRong
    {
        get { return _chieuRong; }
        set
        {
            if (value <= 0) throw new ArgumentException("Chiều rộng phải lớn hơn 0.");
            _chieuRong = value;
        }
    }

    public HinhChuNhat(double chieuDai, double chieuRong)
    {
        ChieuDai = chieuDai;
        ChieuRong = chieuRong;
    }

    public double TinhChuVi() => (ChieuDai + ChieuRong) * 2;
    public double TinhDienTich() => ChieuDai * ChieuRong;

    public void HienThi()
    {
        Console.WriteLine($"Hình chữ nhật [Dài: {ChieuDai}, Rộng: {ChieuRong}] - Chu vi: {TinhChuVi()} - Diện tích: {TinhDienTich()}");
    }
}
