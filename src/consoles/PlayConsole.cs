using Microsoft.Xna.Framework;

using SadConsole;
using System;
using Console = SadConsole.Console;
namespace Timeless_Peach.src.consoles {
    class PlayConsole : ContainerConsole {

        public PlayConsole() {

            //Add the consoles found in the play screen:

            var worldConsole = new Console(65, 20);            //World viewport
            var logConsole = new Console(80, 5);              //Message Log console
            var infoConsole = new Console(15, 20);

            logConsole.Position = new Point(0, 20);
            infoConsole.Position = new Point(65, 0);
            infoConsole.FillWithRandomGarbage();
            this.Children.Add(worldConsole);
            this.Children.Add(logConsole);
            this.Children.Add(infoConsole);

        }

    }
}
