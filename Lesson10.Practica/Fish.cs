﻿namespace Lesson10.Practica
{
    class Fish : Animal
    {
        public Fish() : base(3, "Dolphin") { }

        public void Swim()
        {
            Console.WriteLine($"{Name} is swimming.....");
        }

        public void DisplayActions()
        {
            Console.Clear();

            Console.WriteLine("-------------Characteristics of Fish----------- \n");

            Console.WriteLine("1-> Eat");
            Console.WriteLine("2-> Sleep");
            Console.WriteLine("3-> Swim");
            Console.WriteLine("4-> Back \n");

            Console.Write("Enter the number : ");
            bool isnumber = int.TryParse(Console.ReadLine(), out int number);

            while (!isnumber)
            {
                Console.Clear();
                Console.WriteLine("You have entered the wrong action !! \n");

                Console.ReadKey();
                DisplayActions();
            }

            Console.Clear();

            switch (number)
            {
                case 1:
                    Eat();
                    Console.ReadKey();
                    Console.Clear();
                    DisplayActions();
                    break;

                case 2:
                    Sleep();
                    Console.ReadKey();
                    Console.Clear();
                    DisplayActions();
                    break;

                case 3:
                    Swim();
                    Console.ReadKey();
                    Console.Clear();
                    DisplayActions();
                    break;

                case 0: Program.SelectAnimal(); break;

                default:
                    Console.Clear();
                    Console.WriteLine("You have entered the wrong action !!");
                    Console.ReadKey();
                    DisplayActions(); break;
            }
        }
    }
}
