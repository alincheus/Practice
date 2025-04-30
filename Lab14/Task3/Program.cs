using System;

class MyInfo
{
    private string name;

    public event Action<string> NameChanged;

    public string Name
    {
        get { return name; }
        set
        {
            if (name != value)
            {
                name = value;
                OnNameChanged(name);
            }
        }
    }

    protected virtual void OnNameChanged(string newName)
    {
        NameChanged?.Invoke(newName); 
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyInfo info = new MyInfo();

        info.NameChanged += (newName) =>
        {
            Console.WriteLine($"Имя изменено на: {newName}");
        };

        Console.WriteLine("Введите имя:");
        info.Name = Console.ReadLine();

        Console.WriteLine("Введите новое имя:");
        info.Name = Console.ReadLine();
    }
}
