namespace Lesson10.Practica
{
    abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Animal(int age, string name)
        {
            Name = name;
            Age = age;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} eating.....");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} sleeping.....");
        }
    }
}
