using Microsoft.Xna.Framework;

using SadConsole;
using System;
using Console = SadConsole.Console;
using System.Diagnostics;

namespace Timeless_Peach.src.consoles {
    class MainMenuConsole : Console {

        private int inRaceMenu = 0;
        private int selectChoice = 0; //0 -- Play, 1 -- Quit
        private string title;
        private ConsoleManager conMan;
        private String currentRace = "You have not chosen a race yet.";

        public MainMenuConsole(string title, ConsoleManager conMan) : base(80, 25) {
            IsFocused = true;
            IsVisible = true;
            this.title = title;
            this.conMan = conMan;
        }

        public override void Update(TimeSpan timeElapsed) {
            Clear();
            CheckInput();
            DrawMenuOptions();
            base.Update(timeElapsed);
        }

        private void DrawMenuOptions() {

            Print(0, 0, title.Align(HorizontalAlignment.Center, Width), Color.Black, Color.Green);

            if (selectChoice == 0) {
                Print(25, 12, "Play", Color.Red);
                Print(25, 14, "Quit", Color.White);
                Print(45, 10, "Human", Color.White);
                Print(45, 12, "Kimi", Color.White);
                Print(45, 14, "High Uvese", Color.White);
                Print(45, 16, "Bronk", Color.White);
                Print(25, 20, currentRace, Color.White);
            }
            else if (selectChoice == 1) {
                Print(25, 12, "Play", Color.White);
                Print(25, 14, "Quit", Color.Red);
                Print(45, 10, "Human", Color.White);
                Print(45, 12, "Kimi", Color.White);
                Print(45, 14, "High Uvese", Color.White);
                Print(45, 16, "Bronk", Color.White);
                Print(25, 20, currentRace, Color.White);
            }
            else if (selectChoice == 2) {
                Print(25, 12, "Play", Color.White);
                Print(25, 14, "Quit", Color.White);
                Print(45, 10, "Human", Color.Red);
                Print(45, 12, "Kimi", Color.White);
                Print(45, 14, "High Uvese", Color.White);
                Print(45, 16, "Bronk", Color.White);
                Print(25, 20, currentRace, Color.White);
            }
            else if (selectChoice == 3) {
                Print(25, 12, "Play", Color.White);
                Print(25, 14, "Quit", Color.White);
                Print(45, 10, "Human", Color.White);
                Print(45, 12, "Kimi", Color.Red);
                Print(45, 14, "High Uvese", Color.White);
                Print(45, 16, "Bronk", Color.White);
                Print(25, 20, currentRace, Color.White);
            }
            else if (selectChoice == 4) {
                Print(25, 12, "Play", Color.White);
                Print(25, 14, "Quit", Color.White);
                Print(45, 10, "Human", Color.White);
                Print(45, 12, "Kimi", Color.White);
                Print(45, 14, "High Uvese", Color.Red);
                Print(45, 16, "Bronk", Color.White);
                Print(25, 20, currentRace, Color.White);
            }
            else if (selectChoice == 5) {
                Print(25, 12, "Play", Color.White);
                Print(25, 14, "Quit", Color.White);
                Print(45, 10, "Human", Color.White);
                Print(45, 12, "Kimi", Color.White);
                Print(45, 14, "High Uvese", Color.White);
                Print(45, 16, "Bronk", Color.Red);
                Print(25, 20, currentRace, Color.White);
            }
        }

        private void CheckInput() {
            if (inRaceMenu == 1) {
                if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)) {
                    if (selectChoice < 5) {
                        selectChoice++;
                    }
                    else {
                        selectChoice = 2;
                    }
                }
                if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)) {
                    if (selectChoice > 2) {
                        selectChoice--;
                    }
                    else {
                        selectChoice = 5;
                    }
                }
                if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Left)) {
                    inRaceMenu = 0;
                    selectChoice = 0;
                }
                if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                    if (selectChoice == 2) {
                        currentRace = "You chose Human.";
                    }
                    if (selectChoice == 3) {
                        currentRace = "You chose Kimi.";
                    }
                    if (selectChoice == 4) {
                        currentRace = "You chose High Uvese.";
                    }
                    if (selectChoice == 5) {
                        currentRace = "You chose Bronk.";
                    }
                }
            }
        

            else {
                if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)) {
                    if (selectChoice == 0)
                        selectChoice = 1;
                    else if (selectChoice == 1)
                        selectChoice = 0;
                }
                if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Right)) {
                    inRaceMenu = 1;
                    selectChoice = 2;
                }
                if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                    if (selectChoice == 0) {
                        SadConsole.Global.CurrentScreen = conMan.gameScreen;
                    }
                }
                if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                    if (selectChoice == 1) {
                        System.Environment.Exit(1);
                    }
                }
            }
        }
    }
}

