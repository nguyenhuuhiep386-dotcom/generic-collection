using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Hiep - MSSV: 2415053122218");
        Console.WriteLine();

        Dictionary<string, string> dict = new Dictionary<string, string>();

        Console.Write("Nhap so tu: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap tu tieng Anh: ");
            string eng = Console.ReadLine();

            Console.Write("Nhap nghia tieng Viet: ");
            string viet = Console.ReadLine();

            dict[eng] = viet; 
        }

        string word;

        while (true)
        {
            Console.Write("Nhap tu can tra: ");
            word = Console.ReadLine();

            if (dict.ContainsKey(word))
            {
                Console.WriteLine("Nghia: " + dict[word]);
                break;
            }
            else
            {
                Console.WriteLine("Khong co trong tu dien, nhap lai!");
            }
        }
    }
}