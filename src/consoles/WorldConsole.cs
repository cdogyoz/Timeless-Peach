using Microsoft.Xna.Framework;

using SadConsole;
using System;
using Console = SadConsole.Console;
using Timeless_Peach.src.worldgen;

namespace Timeless_Peach.src.consoles {
    class WorldConsole : Console{

        private const int width = 65;
        private const int height = 20;

        public WorldConsole(Cell[] level) : base(width, height, level) {

        }


        public override void Update(TimeSpan timeElapsed) {
            base.Update(timeElapsed);
        }
    }
}
