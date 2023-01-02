using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsLibraryForGame.Interfaces
{
    enum Direction
    {
        north,
        south,
        east,
        west,
        north_east = 10,
        north_west = 11,
        south_east = 12,
        south_west = 13
    }

    internal interface IMovable
    {
        public void move(Direction direction);
    }
}
