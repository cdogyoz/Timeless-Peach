using Microsoft.Xna.Framework;

using SadConsole;
using System;
using Console = SadConsole.Console;

namespace Timeless_Peach.src.consoles {
    class WorldConsole : ScrollingConsole {

        private const int width = 65;
        private const int height = 20;

        public WorldConsole() : base(200, 200, new Rectangle(0, 0, 65, 20)) {

            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    SadConsole.Entities.Entity ground = new SadConsole.Entities.Entity(Color.White, Color.Black, (int)'-');
                    ground.Position = new Point(x, y);
                   // Children.Add(ground);
                }
            }

            Print(0, 0, "World Viewport", Color.White);
        }

    }
}
