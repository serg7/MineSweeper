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

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    if (field[i, j] == CellState.Fatal)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" {0} ", 'X');    
                    }
                    else if (field[i, j] == CellState.Selected)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" {0} ", 'X');
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" {0} ", 0);
                    }

                    count++;
                }
                Console.WriteLine("\n");
            }


        }
    }
}
