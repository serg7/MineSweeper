using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class UI
    {
        public static void DisplayMatrix(CellState[,] field)
        {
            int rowLength = field.GetLength(0);
            int colLength = field.GetLength(1);
            int count = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (count.ToString().Length == 1)
                    {
                        Console.Write(" {0}  ", count);
                    }
                    else if (count.ToString().Length == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" {0} ", count);
                    }

                    count++;
                }
                Console.WriteLine("\n");
            }


        }
    }
}
