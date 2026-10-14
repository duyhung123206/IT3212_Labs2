using System;

public class SinhVien
{
    // Các trường private làm backing field
    private string _hoTen;
    private double _diemTB;

    public string MaSV { get; set; }

    public string HoTen
    {
        get { return _hoTen; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Họ tên không được rỗng.");
            _hoTen = value.Trim();
        }
    }

    public DateTime NgaySinh { get; set; }

    public double DiemTB
    {
        get { return _diemTB; }
        set
        {
            if (value < 0 || value > 10)
                throw new ArgumentOutOfRangeException("DiemTB", "Điểm trung bình phải từ 0 đến 10.");
            _diemTB = value;
        }
    }

    // Constructor không tham số
    public SinhVien()
    {
        MaSV = "Chưa có";
        HoTen = "Chưa có";
        NgaySinh = DateTime.Today;
        DiemTB = 0;
    }

    // Constructor đầy đủ tham số
    public SinhVien(string maSV, string hoTen, DateTime ngaySinh, double diemTB)
    {
        MaSV = maSV;
        HoTen = hoTen; // Sẽ tự động gọi qua bộ kiểm tra (setter) của HoTen
        NgaySinh = ngaySinh;
        DiemTB = diemTB; // Sẽ tự động gọi qua bộ kiểm tra (setter) của DiemTB
    }

    public void HienThi()
    {
        Console.WriteLine("{0} - {1} - {2:dd/MM/yyyy} - {3:N2}",
            MaSV, HoTen, NgaySinh, DiemTB);
    }
}