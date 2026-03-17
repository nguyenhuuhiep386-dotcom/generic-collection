using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Hiep - MSSV: 2415053122218");
        Console.WriteLine();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();

        // Dem ky tu
        foreach (char c in input)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++; 
            }
            else
            {
                dict[c] = 1; 
            }
        }

        // In ket qua
        Console.WriteLine("So lan xuat hien:");

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}