using Microsoft.Xna.Framework;

using SadConsole;
using System;
using Console = SadConsole.Console;
using System.Diagnostics;

namespace Timeless_Peach.src.consoles {
    class MessageConsole : ScrollingConsole {

        public MessageConsole() : base(80, 5){
            Fill(Color.Blue, Color.Blue, (int)' ', null);
            Print(0, 0, "Log Console", Color.White);
        }

    }
}
