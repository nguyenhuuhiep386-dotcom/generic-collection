using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Nguyen Huu Hiep");
        Console.WriteLine("msv: 2415053122218");
        Console.Write("Nhap so luong phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
        }

        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }
        
        Console.WriteLine("Tong = " + sum);
        Console.ReadKey();
    }
}