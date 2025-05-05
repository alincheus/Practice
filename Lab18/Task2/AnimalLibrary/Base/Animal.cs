namespace AnimalLibrary.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string MakeSound();
    }
}
