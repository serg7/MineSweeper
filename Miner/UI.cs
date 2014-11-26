using System;
using System.Collections.Generic;
using System.Linq;

namespace Miner
{
    class UI
    {
        public static void DisplayMatrix(CellState[,] field, bool isFatal)
        {
            int rowLength = field.GetLength(0);
            int colLength = field.GetLength(1);
            int count = 1;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n ");

            for (int n = 1; n <= colLength; n++)
            {
                if (n == 1)
                {
                    Console.Write(" ");
                }

                Console.Write("  " + n);
            }

            Console.WriteLine("\n");

            for (int i = 0; i < rowLength; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(i + 1 + " ");

                for (int j = 0; j < colLength; j++)
                {
                    if (isFatal)
                    {
                        if (field[i, j] == CellState.WithMine || field[i, j] == CellState.WithMine)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" {0} ", 'X');
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" {0} ", 'X'); 
                        }
                    }
                    else
                    {
                       if (field[i, j] == CellState.Selected)
                       {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" {0} ", 'X');
                       }
                       else
                       {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" {0} ", 0);
                       }
                    }
                    
                    count++;
                }
                Console.WriteLine("\n");
            }
        }




    }
}
