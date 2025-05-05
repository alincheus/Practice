using AnimalLibrary.Animals;

namespace AnimalLibrary.Animals
{
    public class Fish : Animal
    {
        public Fish(string name, int age) : base(name, age) {}

        public override string MakeSound() => "Рыбы не издают звуков, но могут общаться вибрациями!";
    }
}
