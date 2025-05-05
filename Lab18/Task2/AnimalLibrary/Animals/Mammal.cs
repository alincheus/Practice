using AnimalLibrary.Animals;

namespace AnimalLibrary.Animals
{
    public class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age) {}

        public override string MakeSound() => "Рычание, визг или мурлыканье!";
    }
}
