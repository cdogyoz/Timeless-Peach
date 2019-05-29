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
            var logConsole = new MessageConsole();              //Message Log console
            var infoConsole = new InfoConsole();

            player = new PlayerConstruct();
            logConsole.Position = new Point(0, 20);
            infoConsole.Position = new Point(65, 0);


            Children.Add(worldConsole);
            Children.Add(logConsole);
            Children.Add(infoConsole);
            worldConsole.Children.Add(player);

        }

        public override void Update(TimeSpan timeElapsed) {
            PlayerInput();
            base.Update(timeElapsed);
        }

        private void PlayerInput() {

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad2)))
                player.Position += new Point(0, 1);

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad8)))
                player.Position += new Point(0, -1);

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Left)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad4)))
                player.Position += new Point(-1, 0);

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Right)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad6)))
                player.Position += new Point(1, 0);

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad1))
                player.Position += new Point(-1, 1);

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad3))
                player.Position += new Point(1, 1);

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad7))
                player.Position += new Point(-1, -1);

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad9))
                player.Position += new Point(1, -1);
        }

    }
}
