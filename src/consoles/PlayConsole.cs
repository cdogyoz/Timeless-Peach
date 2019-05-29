using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach.src.consoles;
using Timeless_Peach.src.constructs;

namespace Timeless_Peach.src.consoles {
    class PlayConsole : ContainerConsole {

        public SadConsole.Entities.Entity player;

        private ConsoleManager conMan;
        public PlayConsole(ConsoleManager conMan) {

            this.conMan = conMan;

            //Add the consoles found in the play screen:

            var worldConsole = new WorldConsole();            //World viewport
            var logConsole = new Console(80, 5);              //Message Log console
            var infoConsole = new Console(15, 20);

            player = new PlayerConstruct();
            logConsole.Position = new Point(0, 20);
            infoConsole.Position = new Point(65, 0);
            infoConsole.FillWithRandomGarbage();
            logConsole.Fill(Color.Blue, Color.White, (int) ' ', null);


            Children.Add(worldConsole);
            Children.Add(logConsole);
            Children.Add(infoConsole);
            Children.Add(player);

        }

    }
}
