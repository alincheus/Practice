using AnimalLibrary.Animals;

namespace AnimalLibrary.Animals
{
    public class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) {}

        public override string MakeSound() => "Чириканье, пение или карканье!";
    }
}
