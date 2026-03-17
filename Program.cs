using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Hiep - MSSV: 2415053122218");
        Console.WriteLine();

        List<string> names = new List<string>();

        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ten: ");
            names.Add(Console.ReadLine());
        }

        string name;

        while (true)
        {
            Console.Write("Nhap ten can tim: ");
            name = Console.ReadLine();

            if (names.Contains(name))
            {
                Console.WriteLine("Ton tai trong danh sach!");
                break;
            }
            else
            {
                Console.WriteLine("Khong tim thay, nhap lai!");
            }
        }
        Console.ReadKey();
    }
}