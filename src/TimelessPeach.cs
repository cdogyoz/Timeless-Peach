﻿using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach.src.consoles;

namespace Timeless_Peach {
    class TimelessPeach{

        public const int Width = 80;
        public const int Height = 25;

        static void Main(string[] args) {
            // Setup the engine and create the main window.
            SadConsole.Game.Create(Width, Height);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;
            SadConsole.Game.OnUpdate = Tick;

            // Start the game.
            SadConsole.Game.Instance.Run();
            SadConsole.Game.Instance.Dispose();
        }

        //update function
        private static void Tick(GameTime t) {

        }

        private static void Init() {
            // Startup code
            var rootConsole = new ContainerConsole();
            SadConsole.Global.CurrentScreen = rootConsole;

            rootConsole.Children.Add(new MainMenuConsole("Timeless Peach"));

        }
    }
}