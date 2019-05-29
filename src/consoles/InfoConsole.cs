using System;
using Microsoft.Xna.Framework;
using SadConsole;
using SadConsole.Controls;


namespace Timeless_Peach.src.consoles {
    class InfoConsole : SadConsole.Console {

        public InfoConsole() : base(15, 20) {
            Fill(Color.Orange, Color.Orange, ' ', null);
            Print(0, 0, "Info Console", Color.White);
        }
    }
}
