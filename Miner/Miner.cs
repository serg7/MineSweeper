using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner
{
    class Miner
    {
        private Field _field;

        public Miner()
        {
            //_field = new Field[,];
        }

        public void CreateGame(int width, int height)
        {
            _field = new Field(width,height);
        }

        


    }
}
