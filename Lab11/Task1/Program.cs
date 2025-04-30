using System;

class Apartment 
{
    private string name;          
    private double pricePerSquareMeter; 
    private double area;          

    public Apartment(string name, double pricePerSquareMeter, double area)
    {
        this.name = name;
        this.pricePerSquareMeter = pricePerSquareMeter;
        this.area = area;
    }

    public string GetName() => name;
    public double GetPricePerSquareMeter() => pricePerSquareMeter;
    public double GetArea() => area;

    public virtual double CalculateCost()
    {
        return pricePerSquareMeter * area;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Стоимость 1 м²: {pricePerSquareMeter}");
        Console.WriteLine($"Площадь: {area}");
        Console.WriteLine($"Стоимость квартиры: {CalculateCost()}");
    }
}

class CentralApartment : Apartment 
{
    private string districtName; 

    public CentralApartment(string name, double pricePerSquareMeter, double area, string districtName)
        : base(name, pricePerSquareMeter, area)
    {
        this.districtName = districtName;
    }

    public override double CalculateCost()
    {
        double baseCost = base.CalculateCost();
        return baseCost + (baseCost * 0.01); 
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Название района: {districtName}");
        Console.WriteLine($"Стоимость с учетом надбавки: {CalculateCost()}");
    }
}

class Program
{
    static void Main()
    {
        Apartment basicApartment = new Apartment("Квартира у парка", 1200, 55);
        CentralApartment centralApartment = new CentralApartment("Квартира в центре", 2000, 70, "Центральный район");

        Console.WriteLine("Базовый класс:");
        basicApartment.DisplayInfo();

        Console.WriteLine("\nПроизводный класс:");
        centralApartment.DisplayInfo();

        Apartment[] apartments = new Apartment[3];
        apartments[0] = basicApartment;
        apartments[1] = centralApartment;
        apartments[2] = new CentralApartment("Квартира у площади", 2500, 80, "Площадь Победы");

        Console.WriteLine("\nПолиморфный вывод всех объектов:");
        foreach (var apartment in apartments)
        {
            apartment.DisplayInfo();
            Console.WriteLine("--------------------------");
        }
    }
}
