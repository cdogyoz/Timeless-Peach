using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach.src.consoles;

namespace Timeless_Peach {
    class TimelessPeach{

        public const int Width = 80;
        public const int Height = 25;
        public static SadConsole.Entities.Entity player;

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
            
            //North movement
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad8)
                || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up))
                currentConsole.player.Position += new Point(0, -1);

            //South movement
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad2)
                || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down))
                

            //West movement
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad4)
                || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Left))
                player.Position += new Point(-1, 0);

            //East movement
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad6)
                || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Right))
                player.Position += new Point(1, 0);

            //North-west movement
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad7))
                player.Position += new Point(-1, -1);

            //North-east movement
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad9))
                player.Position += new Point(1, -1);

            //South-west movement
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad1))
                player.Position += new Point(-1, 1);

            //South-east movement
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad3))
                player.Position += new Point(1, 1);

        }

        private static void Init() {
            // Startup code
            var rootConsole = new ContainerConsole();
            SadConsole.Global.CurrentScreen = rootConsole;

            rootConsole.Children.Add(new PlayConsole());
            
        }

    }
}
