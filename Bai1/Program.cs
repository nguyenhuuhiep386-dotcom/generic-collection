using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine("Nguyen Huu Hiep");
        Console.WriteLine("msv: 2415053122218");
        Console.WriteLine("Danh sach so:");

        foreach (int num in numbers)
        {
            Console.Write(num+" ");
        }
        Console.ReadKey();
    }
}