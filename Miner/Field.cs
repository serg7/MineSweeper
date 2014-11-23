using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


namespace Miner
{
    enum CellState
    {
        Empty = 1,
        WithMine,
        UnSelected
    }


    class Field
    {
        private CellState[,] _field;

        public CellState[,] GameField
        {
            get { return _field; }
        }

        public CellState this[int width, int height]
        {
            get { return _field[width, height];  }
            set { _field[width, height] = value; }
        }

        public Field(int width, int height)
        {         
            _field = new CellState[width,height];
            FillCellsWithRandomValues();
        }

        private void FillCellsWithRandomValues()
        {
            var values = new CellState[] {CellState.Empty, CellState.WithMine};
            var random = new Random();

            int bound0 = _field.GetUpperBound(0);
            int bount1 = _field.GetUpperBound(1);

            for (int i = 0; i <= bound0; i++)
            {
                for (int j = 0; j <= bount1; j++)
                {
                    _field[i, j] = values[random.Next(values.Length)];
                    var value = _field[i, j];
                    //Console.WriteLine(value);
                }
            }
        }



    }
}
