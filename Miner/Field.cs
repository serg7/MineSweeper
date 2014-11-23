using System;
using System.Collections.Generic;
using System.Linq;


namespace Miner
{
    enum CellState
    {
        Empty,
        WithMine,
        Fatal,
        Selected
    }

    class Field
    {
        public CellState[,] GameField { get; private set; }

        public CellState this[int width, int height]
        {
            get { return GameField[width, height];  }
            set { GameField[width, height] = value; }
        }

        public Field(int width, int height)
        {         
            GameField = new CellState[width,height];
            FillCellsWithRandomValues();
        }

        private void FillCellsWithRandomValues()
        {
            var values = new CellState[] {CellState.Empty, CellState.WithMine};
            var random = new Random();

            int bound0 = GameField.GetUpperBound(0);
            int bount1 = GameField.GetUpperBound(1);

            for (int i = 1; i <= bound0; i++)
            {
                for (int j = 1; j <= bount1; j++)
                {
                    GameField[i, j] = values[random.Next(values.Length)];
                    //GameField[i, j] = CellState.Empty;
                    //var value = GameField[i, j];
                    //Console.WriteLine(value);
                }
            }
        }



    }
}
