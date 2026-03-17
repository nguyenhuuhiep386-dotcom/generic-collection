using System;
using System.Collections.Generic;

// Class Student
class Student
{
    public int Id;
    public string Name;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Nguyen Huu Hiep - MSSV: 2415053122218");
        Console.WriteLine();

        List<Student> list = new List<Student>();

        Console.Write("Nhap so sinh vien: ");
        int n = int.Parse(Console.ReadLine());

    
        for (int i = 0; i < n; i++)
        {
            Student sv = new Student();

            Console.Write("Nhap ID: ");
            sv.Id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten: ");
            sv.Name = Console.ReadLine();

            list.Add(sv);
        }

        int count = list.Count;

        Console.WriteLine("Tong so sinh vien la: " + count);
    }
}