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

        int id;
        bool found;

        while (true)
        {
            found = false;

            Console.Write("Nhap ID can xoa: ");
            id = int.Parse(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    list.RemoveAt(i);
                    Console.WriteLine("Da xoa thanh cong!");
                    found = true;
                    break;
                }
            }

            if (found)
                break;
            else
                Console.WriteLine("Khong tim thay, nhap lai!");
        }

        Console.WriteLine("Danh sach con lai:");

        foreach (Student sv in list)
        {
            Console.WriteLine("ID: " + sv.Id + " - Ten: " + sv.Name);
        }
        Console.ReadKey();
    }
}