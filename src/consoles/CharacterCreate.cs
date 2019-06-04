using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using Microsoft.Xna.Framework;
using Timeless_Peach.src.components;
using Timeless_Peach.src.constructs;

namespace Timeless_Peach.src.consoles {
    class CharacterCreate : SadConsole.Console {

        private ConsoleManager conMan;
        private int selectChoice = 0;
        static public string currentRace = "You have not selected a race yet.";

        public CharacterCreate(ConsoleManager conMan) : base(80, 25) {
            this.conMan = conMan;
        }

         public override void Update(TimeSpan timeElapsed) {
            Clear();
            DrawMenuOptions();
            CheckInput();
            base.Update(timeElapsed);
        }

        private void DrawMenuOptions() {
            Print(28, 1, "CHARACTER CREATE", Color.White, Color.Black);
            Print(28, 22, "Press enter to select, space to play", Color.Black, Color.PeachPuff);
            if (selectChoice == 0) {
                Print(34, 8, "Human", Color.Red);
                Print(34, 10, "Kimi", Color.White);
                Print(34, 12, "High Uvese", Color.White);
                Print(34, 14, "Bronk", Color.White);
                Print(28, 18, currentRace, Color.PeachPuff);
            }
            else if (selectChoice == 1) {
                Print(34, 8, "Human", Color.White);
                Print(34, 10, "Kimi", Color.Red);
                Print(34, 12, "High Uvese", Color.White);
                Print(34, 14, "Bronk", Color.White);
                Print(28, 18, currentRace, Color.PeachPuff);

            }
            if (selectChoice == 2) {
                Print(34, 8, "Human", Color.White);
                Print(34, 10, "Kimi", Color.White);
                Print(34, 12, "High Uvese", Color.Red);
                Print(34, 14, "Bronk", Color.White);
                Print(28, 18, currentRace, Color.PeachPuff);

            }
            else if (selectChoice == 3) {
                Print(34, 8, "Human", Color.White);
                Print(34, 10, "Kimi", Color.White);
                Print(34, 12, "High Uvese", Color.White);
                Print(34, 14, "Bronk", Color.Red);
                Print(28, 18, currentRace, Color.PeachPuff);

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
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)) {
                if (selectChoice > 0) {
                    selectChoice--;
                }
                else {
                    selectChoice = 3;
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                if (selectChoice == 0) {
                    currentRace = "You chose Human.";
                }
                if (selectChoice == 1) {
                    currentRace = "You chose Kimi.";
                }
                if (selectChoice == 2) {
                    currentRace = "You chose High Uvese.";
                }
                if (selectChoice == 3) {
                    currentRace = "You chose Bronk.";
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space)) {
                if (selectChoice == 0) {
                    conMan.CreateGame(new HumanConstruct(new Point(10, 10)));
                }
                if (selectChoice == 1) {
                    conMan.CreateGame(new KimiConstruct(new Point(10, 10)));
                }
                if (selectChoice == 2) {
                    conMan.CreateGame(new HighUveseConstruct(new Point(10, 10)));
                }
                if (selectChoice == 3) {
                    conMan.CreateGame(new BronkConstruct(new Point(10, 10)));
                }
            }
        }
    }
}