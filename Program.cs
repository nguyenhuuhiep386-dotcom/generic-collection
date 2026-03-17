using System;
using System.Collections.Generic;

// Class Student
class Student
{
    public string Name;
    public double Score;
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

            Console.Write("Nhap ten: ");
            sv.Name = Console.ReadLine();

            Console.Write("Nhap diem: ");
            sv.Score = double.Parse(Console.ReadLine());

            list.Add(sv);
        }

        Student maxSV = list[0];

        foreach (Student sv in list)
        {
            if (sv.Score > maxSV.Score)
            {
                maxSV = sv;
            }
        }

        Console.WriteLine("Sinh vien diem cao nhat:");
        Console.WriteLine("Ten: " + maxSV.Name + " - Diem: " + maxSV.Score);
    }
}