using Microsoft.Xna.Framework;

using SadConsole;
using System;
using Console = SadConsole.Console;
using Timeless_Peach.src.worldgen;

namespace Timeless_Peach.src.consoles {
    class WorldConsole : ScrollingConsole{

        private const int width = 100   ;
        private const int height = 100;
        private int curLevel = 0;
        private int levelChange = 0;

        private bool virgin = true;

        private World dungeon;

        public WorldConsole(World world) : base(width, height, new Rectangle(0, 0, 65, 20)) {
            dungeon = world;
            Print(5, 5, "Hello World", Color.White);
        }

        public void MoveLevel(int amount) {
            SetSurface(dungeon.dungeon[curLevel].Cells, width, height);
            curLevel += amount;
            // levelChange += amount;
            // this.SetRenderCells();

        }

        public override void Update(TimeSpan timeElapsed) {
            //this.Clear();
            //D//raw(timeElapsed);

            base.Update(timeElapsed);
        }
    }
}
