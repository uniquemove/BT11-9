using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("Chon bai tap:");
            Console.WriteLine("1. Tao mang so nguyen va tinh tong");
            Console.WriteLine("2. Dem so luong ky tu trong chuoi");
            Console.WriteLine("3. Tim phan tu lon nhat trong mang");
            Console.WriteLine("4. Dao nguoc chuoi");
            Console.WriteLine("5. Kiem tra mang doi xung");
            Console.WriteLine("6. Dem so lan xuat hien cua mot ky tu trong chuoi");
            Console.WriteLine("7. Thoat");
            Console.Write("Lua chon cua ban: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Bai1_TaoMangVaTinhTong();
                    break;
                case 2:
                    Bai2_DemSoLuongKyTu();
                    break;
                case 3:
                    Bai3_TimPhanTuLonNhat();
                    break;
                case 4:
                    Bai4_DaoNguocChuoi();
                    break;
                case 5:
                    Bai5_KiemTraMangDoiXung();
                    break;
                case 6:
                    Bai6_DemSoLanXuatHienKyTu();
                    break;
                case 7:
                    Console.WriteLine("Thoat chuong trinh.");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
            Console.WriteLine();

        } while (choice != 7);
    }

    // Bai 1: Tao mang so nguyen va tinh tong
    static void Bai1_TaoMangVaTinhTong()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = array.Sum();
        Console.WriteLine($"Tong cac phan tu trong mang la: {sum}");
    }

    // Bai 2: Dem so luong ky tu trong chuoi (khong tinh khoang trang va dau cau)
    static void Bai2_DemSoLuongKyTu()
    {
        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        int charCount = input.Count(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c));

        Console.WriteLine($"So luong ky tu trong chuoi (khong tinh khoang trang va dau cau) la: {charCount}");
    }

    // Bai 3: Tim phan tu lon nhat trong mang
    static void Bai3_TimPhanTuLonNhat()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int max = array.Max();
        Console.WriteLine($"Phan tu lon nhat trong mang la: {max}");
    }

    // Bai 4: Dao nguoc chuoi
    static void Bai4_DaoNguocChuoi()
    {
        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        Console.WriteLine($"Chuoi dao nguoc la: {reversedString}");
    }

    // Bai 5: Kiem tra mang doi xung (Palindrome)
    static void Bai5_KiemTraMangDoiXung()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        bool isPalindrome = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (array[i] != array[n - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
            Console.WriteLine("Mang la mang doi xung.");
        else
            Console.WriteLine("Mang khong phai la mang doi xung.");
    }

    // Bai 6: Dem so lan xuat hien cua mot ky tu trong chuoi
    static void Bai6_DemSoLanXuatHienKyTu()
    {
        Console.Write("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        Console.Write("Nhap ky tu can dem: ");
        char character = char.Parse(Console.ReadLine());

        int count = input.Count(c => c == character);

        Console.WriteLine($"So lan xuat hien cua ky tu '{character}' trong chuoi la: {count}");
    }
}
