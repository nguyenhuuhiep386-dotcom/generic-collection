using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Hiep - MSSV: 2415053122218");
        Console.WriteLine();

        List<string> students = new List<string>();

        Console.Write("Nhap so sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap ten: ");
            students.Add(Console.ReadLine());
        }

        string name;
        while (true)
        {
            Console.Write("Nhap ten can xoa: ");
            name = Console.ReadLine();

            if (students.Contains(name))
            {
                students.Remove(name);
                Console.WriteLine("Da xoa thanh cong!");
                break;
            }
            else
            {
                Console.WriteLine("Khong tim thay, nhap lai!");
            }
        }

        Console.WriteLine("Danh sach con lai:");
        foreach (string s in students)
        {
            Console.Write(s + " ");
        }
    }
}