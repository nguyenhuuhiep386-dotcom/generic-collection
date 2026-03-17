using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Nguyen Huu Hiep");
        Console.WriteLine("msv: 2415053122218");
        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine("So lon nhat la: " + max);
        Console.ReadKey();
    }
}