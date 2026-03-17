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

        numbers.Sort();

        Console.WriteLine("Danh sach sau khi sap xep:");

        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.ReadKey();
    }
}