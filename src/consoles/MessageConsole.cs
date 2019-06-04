using Microsoft.Xna.Framework;

using SadConsole;
using System;
using Console = SadConsole.Console;
using System.Diagnostics;

namespace Timeless_Peach.src.consoles {
    class MessageConsole : ScrollingConsole {

        public MessageConsole() : base(115, 9){
            Fill(Color.Black, Color.Black, (int)' ', null);
            Print(34, 0, "LOG CONSOLE", Color.White, Color.Black);
            Print(0, 1, "Welcome to Timeless Peach!", Color.Green, Color.Blue);
        }

    }
}
