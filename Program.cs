using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Hiep - MSSV: 2415053122218");
        Console.WriteLine();

        List<int> numbers = new List<int>();

        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        int min = numbers[0];

        foreach (int num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine("So nho nhat la: " + min);
        Console.ReadKey(); 
    }
}