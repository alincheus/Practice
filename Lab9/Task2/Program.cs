using System;

enum Post
{
    Manager = 160,   
    Engineer = 150,  
    Clerk = 140,     
    Intern = 120    
}

class Accauntant
{
    public bool AskForBonus(Post worker, int hours)
    {
        int requiredHours = (int)worker; 
        return hours > requiredHours;   
    }
}

class Program
{
    static void Main()
    {
        Accauntant accauntant = new Accauntant();

        Console.WriteLine("Введите должность (Manager, Engineer, Clerk, Intern):");
        string postInput = Console.ReadLine();

        Console.WriteLine("Введите количество отработанных часов:");
        int workedHours = int.Parse(Console.ReadLine());

        if (Enum.TryParse(postInput, true, out Post worker))
        {
            bool isBonusGiven = accauntant.AskForBonus(worker, workedHours);
            Console.WriteLine(isBonusGiven
                ? "Сотруднику положена премия."
                : "Сотруднику не положена премия.");
        }
        else
        {
            Console.WriteLine("Ошибка: некорректная должность.");
        }
    }
}
