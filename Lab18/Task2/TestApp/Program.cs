using AnimalLibrary.Animals;
using System;

namespace TestApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Тестируем библиотеку AnimalLibrary!");

            Animal lion = new Mammal("Лев", 5);
            Console.WriteLine($"{lion.Name}: {lion.MakeSound()}");

            Animal eagle = new Bird("Орел", 3);
            Console.WriteLine($"{eagle.Name}: {eagle.MakeSound()}");

            Animal shark = new Fish("Акула", 7);
            Console.WriteLine($"{shark.Name}: {shark.MakeSound()}");
        }
    }
}
