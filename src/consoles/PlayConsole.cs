using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Timeless_Peach.src.consoles;
using Timeless_Peach.src.constructs;
using Timeless_Peach.src.worldgen;
using SadConsole.Components;

namespace Timeless_Peach.src.consoles {
    class PlayConsole : ContainerConsole {

        public PlayableConstruct player;

        private ConsoleManager conMan;
        private int curLevel = 1;
        public int turn;
        public int lastTurn;
        public int consoleY;
        public ScrollingConsole logConsole;
        private WorldConsole worldConsole;
        private Console escapeOptionsConsole;

        private World world;
        private Cell[] level;
        public PlayConsole(ConsoleManager conMan) {

            this.conMan = conMan;
            turn = 1;
            lastTurn = 0;
            logConsole = new MessageConsole();
            escapeOptionsConsole = new EscapeOptionsConsole(conMan);
            consoleY = 2;

            worldConsole = new WorldConsole(new World());

            //Add the consoles found in the play screen
            world = new World(100, 100, worldConsole);

            worldConsole = new WorldConsole(world);      //World viewport
            worldConsole.MoveLevel(0);

            logConsole.Position = new Point(0, 37);

            Children.Add(worldConsole);
            Children.Add(logConsole);

        }

        public override void Update(TimeSpan timeElapsed) {

            //if player stamina is less than or equal to 0 then end turn
            if(player.getStamina() >= 0) {
                PlayerInput();
            } else {
                //Run enemies()
                player.setStamina(player.maxStamina);
            }
            
            base.Update(timeElapsed);
        }

        public void AddPlayer(PlayableConstruct player) {
            this.player = player;
            player.Components.Add(new EntityViewSyncComponent());
            SkeletonConstruct skel = new SkeletonConstruct(new Point(20, 10), this);
            worldConsole.Children.Add(skel);
            worldConsole.Children.Add(player);
            var infoConsole = new InfoConsole(this);
            infoConsole.Position = new Point(101, 0);
            Children.Add(infoConsole);
            Global.CurrentScreen = this;

        }

        private void PlayerInput() {

            int xPos = player.Position.X;
            int yPos = player.Position.Y;

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Y)) {
                worldConsole.MoveLevel(1);
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)
                || (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad2))) {

                if(worldConsole.GetGlyph(xPos, yPos +1) != (int)'#'){
                    player.MoveBy(new Point(0, 1));
                    worldConsole.CenterOnPlayer(player);
                    turn++;
                    logConsole.Print(0, consoleY, "You moved down.", Color.Green, Color.Blue);
                    if (consoleY > 5) {
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
                    player.MoveBy(new Point(0, -1));
                    worldConsole.CenterOnPlayer(player);
                    turn++;
                    logConsole.Print(0, consoleY, "You moved up.", Color.Green, Color.Blue);
                    if (consoleY > 5) {
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
                    player.MoveBy(new Point(-1, 0));
                    worldConsole.CenterOnPlayer(player);
                    turn++;
                    logConsole.Print(0, consoleY, "You moved left.", Color.Green, Color.Blue);
                    if (consoleY > 5) {
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
                    player.MoveBy(new Point(1, 0));
                    worldConsole.CenterOnPlayer(player);
                    turn++;
                    logConsole.Print(0, consoleY, "You moved right.", Color.Green, Color.Blue);
                    if (consoleY > 5) {
                        logConsole.ShiftUp();
                    }
                    else {
                        consoleY++;
                    }
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Escape)) {
                Children.Add(escapeOptionsConsole);
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad1)) {
                player.Position += new Point(-1, 1);
                worldConsole.CenterOnPlayer(player);
                turn++;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad3)) {
                player.Position += new Point(1, 1);
                worldConsole.CenterOnPlayer(player);
                turn++;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad7)) {
                player.Position += new Point(-1, -1);
                worldConsole.CenterOnPlayer(player);
                turn++;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.NumPad9)) {
                player.Position += new Point(1, -1);
                worldConsole.CenterOnPlayer(player);
                turn++;
            }

        }

    }
}
