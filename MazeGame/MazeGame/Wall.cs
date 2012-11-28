using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MazeGame
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            // can't walk through walls
        }
    }
}
