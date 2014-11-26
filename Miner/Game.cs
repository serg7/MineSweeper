using System;
using System.Collections.Generic;
using System.Linq;


namespace Miner
{
    public class Game
    {
        private static readonly Game _instance = new Game();
        private Field field; 

        public static Game Instance { get { return _instance; } }

        private Game() {}

        public void CreateGame(int width, int height)
        {
            field = new Field(width,height);
            UI.DisplayMatrix(field.GameField, false);
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
                bool isFatal = false;
                UI.DisplayMatrix(field.GameField, isFatal);
            }
            else if (field[x, y] == CellState.WithMine)
            {
                field[x, y] = CellState.Fatal;
                bool isFatal = true;
                UI.DisplayMatrix(field.GameField, isFatal);
            }

           

            return result;
        }
        


    }
}
