using System;
using System.Linq;

struct STUDENT
{
    public string Name;     
    public int GroupNumber;   
    public int[] Grades;      

    public double GetAverageGrade()
    {
        return Grades.Average();
    }
}

class Program
{
    static void Main()
    {
        const int studentCount = 10;
        STUDENT[] students = new STUDENT[studentCount];

        Console.WriteLine("Введите данные для 10 студентов:");

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"\nСтудент {i + 1}:");

            Console.Write("Фамилия и инициалы: ");
            students[i].Name = Console.ReadLine();

            Console.Write("Номер группы: ");
            students[i].GroupNumber = int.Parse(Console.ReadLine());

            students[i].Grades = new int[5];
            Console.WriteLine("Введите 5 оценок:");
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Оценка {j + 1}: ");
                students[i].Grades[j] = int.Parse(Console.ReadLine());
            }
        }

        students = students.OrderBy(s => s.GroupNumber).ToArray();

        Console.WriteLine("\nСтуденты с средним баллом больше 4.0:");
        bool found = false;

        foreach (var student in students)
        {
            if (student.GetAverageGrade() > 4.0)
            {
                Console.WriteLine($"Фамилия: {student.Name}, Номер группы: {student.GroupNumber}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Нет студентов со средним баллом выше 4.0.");
        }
    }
}
