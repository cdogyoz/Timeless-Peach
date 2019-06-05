using Microsoft.Xna.Framework;

using SadConsole;
using System;
using Console = SadConsole.Console;
using System.Diagnostics;

namespace Timeless_Peach.src.consoles {
    class MainMenuConsole : Console {

        private int selectChoice = 0; //0 -- Play, 1 -- Quit
        private string title;
        private ConsoleManager conMan;
        private CharacterCreate create;

        public MainMenuConsole(string title, ConsoleManager conMan) : base(TimelessPeach.Width, TimelessPeach.Height) {
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
            Print(0, 0, " ".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.Pink);
            Print(0, 2, " ".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.Pink);
            Print(0, 1, title.Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.Pink);
            if (selectChoice == 0) {
                Print(0, 18, "Play".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
                Print(0, 20, "Quit".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
            }
            else if (selectChoice == 1) {
                Print(0, 18, "Play".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 20, "Quit".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
            }
        }

        private void CheckInput() {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)) {
                if (selectChoice == 0)
                    selectChoice = 1;
                else if (selectChoice == 1)
                    selectChoice = 0;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                if (selectChoice == 0) {
                    SadConsole.Global.CurrentScreen = conMan.create;
                }
                else if (selectChoice == 1)
                {
                    System.Environment.Exit(1);
                }
            }
        }
    }
}

