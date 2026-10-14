using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Hỗ trợ hiển thị tiếng Việt có dấu trong Console
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            List<SanPham> dsSanPham = new List<SanPham>();
            dsSanPham.Add(new SanPham("SP01", "Bàn phím cơ MelGeek", 2500000, 2));
            dsSanPham.Add(new SanPham("SP02", "Tai nghe Razer", 1800000, 1));

            Console.WriteLine("--- DANH SÁCH SẢN PHẨM ---");
            foreach (SanPham sp in dsSanPham)
            {
                sp.HienThi();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Lỗi: " + ex.Message);
        }
    }
}