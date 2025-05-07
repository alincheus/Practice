using System;
using System.Collections.Generic;

class Plant : ICloneable
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int? Lifespan { get; set; } 

    public Plant(string name, string type, int? lifespan)
    {
        Name = name;
        Type = type;
        Lifespan = lifespan;
    }

    public object Clone()
    {
        return new Plant(Name, Type, Lifespan);
    }

    public override string ToString()
    {
        return $"Растение: {Name}, Тип: {Type}, Продолжительность жизни: {Lifespan ?? 0} лет";
    }
}

class PlantCollection<T> where T : Plant
{
    private List<T> plants = new List<T>();
    private Dictionary<string, T> plantDictionary = new Dictionary<string, T>();

    public void AddPlant(T plant)
    {
        plants.Add(plant);
        plantDictionary[plant.Name] = plant;
    }

    public bool RemovePlant(string name)
    {
        if (plantDictionary.ContainsKey(name))
        {
            T plantToRemove = plantDictionary[name];
            plants.Remove(plantToRemove);
            plantDictionary.Remove(name);
            return true;
        }
        return false;
    }

    public T? FindPlant(string name)
    {
        return plantDictionary.TryGetValue(name, out T plant) ? plant : null;
    }

    public T ClonePlant(string name)
    {
        return plantDictionary.ContainsKey(name) ? (T)plantDictionary[name].Clone() : null!;
    }

    public void DisplayPlants()
    {
        Console.WriteLine("\nСписок растений:");
        foreach (var plant in plants)
        {
            Console.WriteLine(plant);
        }
    }
}

class Program
{
    static void Main()
    {
        PlantCollection<Plant> garden = new PlantCollection<Plant>();

        garden.AddPlant(new Plant("Роза", "Цветущее", 5));
        garden.AddPlant(new Plant("Дуб", "Дерево", null)); 
        garden.AddPlant(new Plant("Кактус", "Суккулент", 30));

        garden.DisplayPlants();

        Plant clonedPlant = garden.ClonePlant("Роза");
        Console.WriteLine($"\nКлонированное растение: {clonedPlant}");

        bool removed = garden.RemovePlant("Дуб");
        Console.WriteLine($"\nРастение 'Дуб' удалено: {removed}");

        Plant? foundPlant = garden.FindPlant("Кактус");
        Console.WriteLine($"\nНайденное растение: {foundPlant}");

        garden.DisplayPlants();
    }
}
