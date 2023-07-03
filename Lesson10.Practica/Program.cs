namespace Lesson10.Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            SelectAnimal();
        }

        public static void SelectAnimal()
        {
            Console.Clear();

            Console.WriteLine("1->Bird      2->Fish");
            Console.WriteLine("3->Duck \n");

            Console.Write("Enter the number : ");
            bool isnumber = int.TryParse(Console.ReadLine(), out int number);

            while (!isnumber)
            {
                Console.Clear();
                Console.WriteLine("You have entered the wrong action !! \n");

                Console.ReadKey();
                SelectAnimal();
            }

            Console.Clear();

            switch (number)
            {
                case 1: new Bird().DisplayActions(); break;
                case 2: new Fish().DisplayActions(); break;
                case 3: new Duck().DisplayActions(); break;
                default:
                    Console.Clear();
                    Console.WriteLine("You have entered the wrong action !!");
                    Console.ReadKey();
                    SelectAnimal(); break;

            }
        }
    }
}