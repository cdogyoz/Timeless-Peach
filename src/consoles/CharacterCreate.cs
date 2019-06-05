using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using SadConsole.Controls;
using Microsoft.Xna.Framework;
using Timeless_Peach.src.constructs;

namespace Timeless_Peach.src.consoles {
    class CharacterCreate : SadConsole.Console {

        private ConsoleManager conMan;
        private int selectChoice = 0;
        static public string currentRace = "You choose Human.";
        private string name = "";

        public CharacterCreate(ConsoleManager conMan) : base(TimelessPeach.Width, TimelessPeach.Height) {
            this.conMan = conMan;
        }

         public override void Update(TimeSpan timeElapsed) {
            Clear();
            DrawMenuOptions();
            CheckInput();
            base.Update(timeElapsed);
        }

        private void DrawMenuOptions() {
            Print(0, 1, "CHARACTER CREATE".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White, Color.Black);
            Print(0, 22, "Press space or enter to play".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.PeachPuff);
            if (selectChoice == 0) {
                Print(0, 8, "Human".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
                Print(0, 10, "Kimi".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 12, "High Uvese".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 14, "Bronk".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 18, currentRace.Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.PeachPuff);
            }
            else if (selectChoice == 1) {
                Print(0, 8, "Human".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 10, "Kimi".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
                Print(0, 12, "High Uvese".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 14, "Bronk".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 18, currentRace.Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.PeachPuff);

            }
            if (selectChoice == 2) {
                Print(0, 8, "Human".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 10, "Kimi".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 12, "High Uvese".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
                Print(0, 14, "Bronk".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 18, currentRace.Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.PeachPuff);

            }
            else if (selectChoice == 3) {
                Print(0, 8, "Human".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 10, "Kimi".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 12, "High Uvese".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 14, "Bronk".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
                Print(0, 18, currentRace.Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.PeachPuff);

            }
        }

        private void CheckInput() {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)) {
                if (selectChoice < 3) {
                    selectChoice++;
                }
                else {
                    selectChoice = 0;
                }

                if (selectChoice == 0)
                {
                    currentRace = "You choose Human.";
                }
                if (selectChoice == 1)
                {
                    currentRace = "You choose Kimi.";
                }
                if (selectChoice == 2)
                {
                    currentRace = "You choose High Uvese.";
                }
                if (selectChoice == 3)
                {
                    currentRace = "You choose Bronk.";
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)) {
                if (selectChoice > 0) {
                    selectChoice--;
                }
                else {
                    selectChoice = 3;
                }

                if (selectChoice == 0)
                {
                    currentRace = "You choose Human.";
                }
                if (selectChoice == 1)
                {
                    currentRace = "You choose Kimi.";
                }
                if (selectChoice == 2)
                {
                    currentRace = "You choose High Uvese.";
                }
                if (selectChoice == 3)
                {
                    currentRace = "You choose Bronk.";
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                if (selectChoice == 0) {
                    //name = EnterName();
                    conMan.CreateGame(new HumanConstruct("Charles",new Point(10, 10)));
                    ConsoleManager.gameScreen = new PlayConsole(conMan);
                }
                if (selectChoice == 1) {
                    //name = EnterName();
                    conMan.CreateGame(new KimiConstruct(new Point(10, 10)));
                    ConsoleManager.gameScreen = new PlayConsole(conMan);
                    selectChoice = 0;
                }
                if (selectChoice == 2) {
                    //name = EnterName();
                    conMan.CreateGame(new HighUveseConstruct(new Point(10, 10)));
                    ConsoleManager.gameScreen = new PlayConsole(conMan);
                    selectChoice = 0;
                }
                if (selectChoice == 3) {
                    //name = EnterName();
                   conMan.CreateGame(new BronkConstruct(new Point(10, 10)));
                    ConsoleManager.gameScreen = new PlayConsole(conMan);
                    selectChoice = 0;
                }
            }
        }

        private string EnterName() {
            ControlsConsole nameConsole = new ControlsConsole(40, 3);
            nameConsole.Position = new Point(15, 18);
            this.Children.Add(nameConsole);
            TextBox nameIn = new TextBox(40);
            nameIn.IsEnabled = true;
            nameIn.IsVisible = true;
            nameConsole.Add(nameIn);
            nameIn.ProcessKeyboard(new SadConsole.Input.Keyboard());
            return "string";
        }
    }
}