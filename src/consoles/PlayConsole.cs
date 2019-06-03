using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach.src.consoles;
using Timeless_Peach.src.constructs;
using Timeless_Peach.src.worldgen;

namespace Timeless_Peach.src.consoles {
    class PlayConsole : ContainerConsole {

        private PlayableConstruct player;

        private ConsoleManager conMan;
        public int turn;
        public int lastTurn;
        public int consoleY;
        public ScrollingConsole logConsole;
        private WorldConsole worldConsole;

        private World world;
        private Cell[] level;
        public PlayConsole(ConsoleManager conMan) {

            this.conMan = conMan;
            turn = 1;
            lastTurn = 0;
            logConsole = new MessageConsole();
            consoleY = 2;

            worldConsole = new WorldConsole(new Cell[65 * 20]);

            //Add the consoles found in the play screen
            level = new World(65, 20, worldConsole).tiles;

            worldConsole = new WorldConsole(level);      //World viewport
            var infoConsole = new InfoConsole(this);

            logConsole.Position = new Point(0, 20);
            infoConsole.Position = new Point(65, 0);


            Children.Add(worldConsole);
            Children.Add(logConsole);
            Children.Add(infoConsole);

        }

        public override void Update(TimeSpan timeElapsed) {

            PlayerInput();
                
            
            base.Update(timeElapsed);
        }

        public void AddPlayer(PlayableConstruct player) {
            this.player = player;
            worldConsole.Children.Add(player);
            Global.CurrentScreen = this;

        }

        private void PlayerInput() {

            int xPos = player.Position.X;
            int yPos = player.Position.Y;

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad2))) {

                if(worldConsole.GetGlyph(xPos, yPos +1) != (int)'#'){
                    player.Position += new Point(0, 1);
                    turn++;
                    logConsole.Print(0, consoleY, "You moved down.", Color.Green, Color.Blue);
                    if (consoleY > 4) {
                        logConsole.ShiftUp();
                    }
                    else {
                        consoleY++;
                    }
                }

            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad8))) {

                if (worldConsole.GetGlyph(xPos, yPos - 1) != (int)'#') {
                    player.Position += new Point(0, -1);
                    turn++;
                    logConsole.Print(0, consoleY, "You moved up.", Color.Green, Color.Blue);
                    if (consoleY > 4) {
                        logConsole.ShiftUp();
                    }
                    else {
                        consoleY++;
                    }
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Left)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad4))) {

                if (worldConsole.GetGlyph(xPos - 1, yPos) != (int)'#') {
                    player.Position += new Point(-1, 0);
                    turn++;
                    logConsole.Print(0, consoleY, "You moved left.", Color.Green, Color.Blue);
                    if (consoleY > 4) {
                        logConsole.ShiftUp();
                    }
                    else {
                        consoleY++;
                    }
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Right)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad6))) {

                if (worldConsole.GetGlyph(xPos + 1, yPos) != (int)'#') {
                    player.Position += new Point(1, 0);
                    turn++;
                    logConsole.Print(0, consoleY, "You moved right.", Color.Green, Color.Blue);
                    if (consoleY > 4) {
                        logConsole.ShiftUp();
                    }
                    else {
                        consoleY++;
                    }
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad1)) {
                player.Position += new Point(-1, 1);
                turn++;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad3)) {
                player.Position += new Point(1, 1);
                turn++;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad7)) {
                player.Position += new Point(-1, -1);
                turn++;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad9)) {
                player.Position += new Point(1, -1);
                turn++;
            }

        }

    }
}
