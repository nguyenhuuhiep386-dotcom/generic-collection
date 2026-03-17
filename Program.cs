using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Hiep - MSSV: 2415053122218");
        Console.WriteLine();

        List<int> numbers = new List<int>();
        List<int> newList = new List<int>();

        Console.Write("Nhap so phan tu: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap so: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        foreach (int num in numbers)
        {
            if (!newList.Contains(num))
            {
                newList.Add(num);
            }
        }

        Console.WriteLine("Danh sach sau khi bo trung:");

        foreach (int num in newList)
        {
            Console.Write(num + " ");
        }
        Console.ReadKey();
    }
}