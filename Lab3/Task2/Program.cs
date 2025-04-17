using System;

class Persona
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Persona()
    {
        Console.WriteLine("Введите имя:");
        Name = Console.ReadLine();
        Console.WriteLine("Введите возраст:");
        Age = Convert.ToInt32(Console.ReadLine());
    }

    public virtual string GetInfo()
    {
        return $"Имя: {Name}, Возраст: {Age}";
    }
}

class Student : Persona
{
    public string Group { get; private set; }

    public Student()
    {
        Console.WriteLine("Введите учебную группу:");
        Group = Console.ReadLine();
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Учебная группа: {Group}";
    }
}

class Teacher : Persona
{
    public string Subject { get; private set; }

    public Teacher()
    {
        Console.WriteLine("Введите предмет преподавания:");
        Subject = Console.ReadLine();
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Предмет: {Subject}";
    }
}

class HeadOfDepartment : Teacher
{
    public string Department { get; private set; }

    public HeadOfDepartment()
    {
        Console.WriteLine("Введите название кафедры:");
        Department = Console.ReadLine();
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $", Кафедра: {Department}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите категорию:\n1 - Студент\n2 - Преподаватель\n3 - Заведующий кафедрой");
        int choice = Convert.ToInt32(Console.ReadLine());

        Persona person = choice switch
        {
            1 => new Student(),
            2 => new Teacher(),
            3 => new HeadOfDepartment(),
            _ => throw new Exception("Некорректный ввод!")
        };

        Console.WriteLine("\nИнформация:");
        Console.WriteLine(person.GetInfo());
    }
}
