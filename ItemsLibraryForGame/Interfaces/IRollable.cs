using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsLibraryForGame.Interfaces
{
    internal interface IRollable
    {
        public int diceSize { get; set; }

        public int rollDice();
    }
}
