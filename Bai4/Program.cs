using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Thông tin sinh viên
        Console.WriteLine("Nguyen Huu Hiep");
        Console.WriteLine("MSSV: 2415053122218");

        List<int> numbers = new List<int>();

        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        int count = 0;

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("So luong so chan la: " + count);
        Console.ReadKey();
    }
}