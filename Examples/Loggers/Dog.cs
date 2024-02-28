namespace Loggers
{
    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }

        public Dog(string name, string color, string breed)
        {
            Name = name;
            Color = color;
            Breed = breed;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }
}