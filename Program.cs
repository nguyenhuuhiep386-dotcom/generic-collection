using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Hiep - MSSV: 2415053122218");
        Console.WriteLine();

        List<int> numbers = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();

        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        foreach (int num in numbers)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }

        int maxCount = 0;
        int result = numbers[0];

        foreach (var item in dict)
        {
            if (item.Value > maxCount)
            {
                maxCount = item.Value;
                result = item.Key;
            }
        }

        Console.WriteLine("So xuat hien nhieu nhat la: " + result);
        Console.WriteLine("So lan xuat hien: " + maxCount);
    }
}