using Microsoft.Xna.Framework;

using SadConsole;
using System;
using SadConsole.Entities;

namespace Timeless_Peach.src.constructs {
    class PlayerConstruct : Entity  {

        public PlayerConstruct() : base(Color.Green, Color.Black, (int)'@') {
            Position = new Point(10, 10);
        }

        
    }
}
