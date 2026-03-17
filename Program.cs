using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Hiep - MSSV: 2415053122218");
        Console.WriteLine();

        List<int> numbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("Danh sach vua nhap:");

        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}