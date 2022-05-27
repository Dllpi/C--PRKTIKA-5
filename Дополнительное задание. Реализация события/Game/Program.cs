using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer g1 = new Gamer("Василий");
            g1.Notify += DisplayMessange;

            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"Выпало количество очков {g1.SeansGame()} для игрока по имени {g1} ");
            }    
        }

        private static void DisplayMessange(string message)
        {
            Console.WriteLine(message);
        }   
    }
}
