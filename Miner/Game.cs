using System;
using System.Collections.Generic;
using System.Linq;


namespace MineSweeper
{
    public class Game
    {
        private static readonly Game _instance = new Game();
        private Field field; 

        public static Game Instance { get { return _instance; } }

        private Game(){}

        public void CreateGame(int width, int height)
        {
            field = new Field(width,height);
            UI.DisplayMatrix(field.GameField);
        }

        public bool Turn(int i, int j)
        {
            bool result = false;
            int x = i - 1;
            int y = j - 1;

            if (field[x, y] == CellState.Empty)
            {
                result = true;
                field[x, y] = CellState.Selected;
            }
            else if (field[x, y] == CellState.WithMine)
            {
                field[x, y] = CellState.Fatal;
            }

            UI.DisplayMatrix(field.GameField);

            return result;
        }
        


    }
}
