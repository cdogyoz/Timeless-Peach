﻿using System;
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
            var logConsole = new MessageConsole();              //Message Log console
            var infoConsole = new InfoConsole();

            player = new PlayerConstruct();
            logConsole.Position = new Point(0, 20);
            infoConsole.Position = new Point(65, 0);


            Children.Add(worldConsole);
            Children.Add(logConsole);
            Children.Add(infoConsole);
            Children.Add(player);

        }

    }
}
