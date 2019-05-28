using System;
using Microsoft.Xna.Framework;
using SadConsole;
using SadConsole.Controls;

//Manages all of the consoles used in the game

namespace Timeless_Peach.src.consoles {
    class ConsoleManager : ContainerConsole {

        public ConsoleManager() {
            IsVisible = true;
            IsFocused = true;

            Parent = SadConsole.Global.CurrentScreen;
        }

    }
}
