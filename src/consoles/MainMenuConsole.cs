using Microsoft.Xna.Framework;

using SadConsole;
using System;
using Console = SadConsole.Console;

namespace Timeless_Peach.src.consoles {
    class MainMenuConsole : Console {

        public MainMenuConsole(string title) : base(80, 25) {
            Fill(Color.White, Color.Black, 176);
            Print(0, 0, title.Align(HorizontalAlignment.Center, Width), Color.Black, Color.Green);
        }
    }
}
