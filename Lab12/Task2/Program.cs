using System;

abstract class Settlement 
{
    public string Name { get; set; } 

    public Settlement(string name)
    {
        Name = name;
    }

    public abstract double CalculatePopulationDensity();

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Название: {Name}");
    }
}

class Village : Settlement 
{
    public int HouseCount { get; set; } 
    public int ResidentsPerHouse { get; set; } 
    public double Area { get; set; } 

    public Village(string name, int houseCount, int residentsPerHouse, double area)
        : base(name)
    {
        HouseCount = houseCount;
        ResidentsPerHouse = residentsPerHouse;
        Area = area;
    }

    public override double CalculatePopulationDensity()
    {
        int totalResidents = HouseCount * ResidentsPerHouse;
        return totalResidents / Area;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество домов: {HouseCount}");
        Console.WriteLine($"Число жителей в доме: {ResidentsPerHouse}");
        Console.WriteLine($"Площадь села: {Area}");
        Console.WriteLine($"Плотность населения: {CalculatePopulationDensity()}");
    }
}

class City : Settlement 
{
    public int TotalResidents { get; set; } 
    public double Area { get; set; } 

    public City(string name, int totalResidents, double area)
        : base(name)
    {
        TotalResidents = totalResidents;
        Area = area;
    }

    public override double CalculatePopulationDensity()
    {
        return TotalResidents / Area;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Количество жителей: {TotalResidents}");
        Console.WriteLine($"Площадь города: {Area}");
        Console.WriteLine($"Плотность населения: {CalculatePopulationDensity()}");
    }
}

class Program
{
    static void Main()
    {
        Settlement[] settlements = new Settlement[5]; 

        settlements[0] = new Village("Село Зеленое", 50, 4, 2.0);
        settlements[1] = new Village("Село Красное", 70, 3, 1.8);
        settlements[2] = new City("Город Солнечный", 25000, 10.0);
        settlements[3] = new City("Город Лунный", 30000, 15.0);
        settlements[4] = new Village("Село Голубое", 40, 5, 3.5);

        Console.WriteLine("Протокол выдачи информации:\n");
        double minDensity = double.MaxValue;
        Settlement leastDenseSettlement = null;

        foreach (Settlement settlement in settlements)
        {
            settlement.DisplayInfo();
            Console.WriteLine("-----------------------------");

            double density = settlement.CalculatePopulationDensity();
            if (density < minDensity)
            {
                minDensity = density;
                leastDenseSettlement = settlement;
            }
        }

        Console.WriteLine($"\nНаселенный пункт с наименьшей плотностью населения: {leastDenseSettlement.Name}");
        Console.WriteLine($"Плотность населения: {minDensity}");
    }
}
