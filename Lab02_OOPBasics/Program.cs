using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Hỗ trợ hiển thị tiếng Việt có dấu trong Console
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<SinhVien> ds = new List<SinhVien>();
        int chon;

        do
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("       QUẢN LÝ SINH VIÊN - LAB 2       ");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Thêm sinh viên vào danh sách");
            Console.WriteLine("2. Hiển thị danh sách sinh viên");
            Console.WriteLine("3. Tìm kiếm sinh viên theo mã");
            Console.WriteLine("4. Sắp xếp danh sách theo điểm TB giảm dần");
            Console.WriteLine("0. Thoát chương trình");
            Console.WriteLine("========================================");
            Console.Write("Nhập lựa chọn của bạn (0-4): ");

            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                chon = -1;
            }

            switch (chon)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("--- THÊM SINH VIÊN MỚI ---");
                    Console.Write("Nhập mã sinh viên: ");
                    string ma = Console.ReadLine();
                    Console.Write("Nhập họ tên: ");
                    string ten = Console.ReadLine();
                    Console.Write("Nhập điểm trung bình (0-10): ");
                    if (double.TryParse(Console.ReadLine(), out double dtb))
                    {
                        try
                        {
                            ds.Add(new SinhVien(ma, ten, DateTime.Today, dtb));
                            Console.WriteLine("\nThêm sinh viên thành công!");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"\nLỗi dữ liệu: {ex.Message}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nĐiểm số không hợp lệ!");
                    }
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("--- DANH SÁCH HỆ THỐNG ---");
                    if (ds.Count == 0)
                    {
                        Console.WriteLine("Danh sách hiện đang trống!");
                    }
                    else
                    {
                        foreach (var sv in ds)
                        {
                            sv.HienThi();
                        }
                    }
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("--- TÌM KIẾM SINH VIÊN ---");
                    Console.Write("Nhập mã sinh viên cần tìm: ");
                    string maTim = Console.ReadLine();
                    var kq = ds.FirstOrDefault(x => x.MaSV.Equals(maTim, StringComparison.OrdinalIgnoreCase));
                    if (kq != null)
                    {
                        Console.WriteLine("\nKết quả tìm thấy:");
                        kq.HienThi();
                    }
                    else
                    {
                        Console.WriteLine("\nKhông tìm thấy sinh viên có mã này!");
                    }
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    ds = ds.OrderByDescending(x => x.DiemTB).ToList();
                    Console.WriteLine("Đã sắp xếp danh sách sinh viên theo điểm trung bình giảm dần thành công!");
                    Console.WriteLine("\n--- DANH SÁCH SAU KHI SẮP XẾP ---");
                    foreach (var sv in ds)
                    {
                        sv.HienThi();
                    }
                    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
                    Console.ReadKey();
                    break;

                case 0:
                    Console.WriteLine("\nCảm ơn bạn đã sử dụng chương trình!");
                    break;

                default:
                    Console.WriteLine("\nLựa chọn không hợp lệ! Nhấn phím bất kỳ để chọn lại...");
                    Console.ReadKey();
                    break;
            }
        } while (chon != 0);
    }
}