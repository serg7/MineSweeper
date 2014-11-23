using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = Game.Instance;
            game.CreateGame(5,5);

            Console.WriteLine("Your turn:");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            var turn = game.Turn(i, j);

            while (turn)
            {
                Console.WriteLine("Your turn:");
                i = int.Parse(Console.ReadLine());
                j = int.Parse(Console.ReadLine());
                turn = game.Turn(i, j);

                if (!turn)
                {
                    Console.WriteLine("Game over!");
                }
            }


            Console.Read();
        }
    }
}
