using System;

namespace cources_second_task
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Let's play a game.\nPlease choose a door from 1 to 5");
                string ChooseDoorString = Console.ReadLine();

                if (ChooseDoorString == "exit")
                {
                    break;
                }

                string cutDigit = "";
                foreach (char character in ChooseDoorString)
                {
                    if (Char.IsDigit(character))
                    {
                        cutDigit += character;
                    }
                }

                int ChooseDoor = int.Parse(cutDigit);

                int rnd = new Random().Next(0, 5);

                switch (ChooseDoor = rnd)
                {
                    case 1:
                        Console.WriteLine("There is an enemy. You loose!");
                        break;
                    case 2:
                        Console.WriteLine("There is a treasure. You win!");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("This door is empty:(");
                        break;
                    default:
                        Console.WriteLine("You have entered an unknown command");
                        break;
                }



            }
        }
    }
}
