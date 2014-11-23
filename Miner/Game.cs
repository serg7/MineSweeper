using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner
{
    public class Game
    {
        private static readonly Game _instance = new Game();

        public static Game Instance
        {
            get { return _instance; }
        }

        private Game()
        {
        }

        public void CreateGame(int width, int height)
        {
            var field = new Field(width,height);
            UI.DisplayMatrix(field.GameField);
        }

        


    }
}
