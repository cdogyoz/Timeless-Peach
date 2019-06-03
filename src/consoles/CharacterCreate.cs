using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.consoles {
    class CharacterCreate : SadConsole.Console {

        private ConsoleManager conMan;
        private int selectChoice = 0;
        private string currentRace = "You have not selected a race yet.";

        public CharacterCreate(ConsoleManager conMan) : base(80, 25) {
            this.conMan = conMan;
            Print(33, 0, "Character Create", Color.White, Color.Black);
            Print(33, 24, "Press space to play", Color.Black, Color.PeachPuff);
        }

        public override void Update(TimeSpan timeElapsed) {
            DrawMenuOptions();
            CheckInput();
            base.Update(timeElapsed);
        }

        private void DrawMenuOptions() {
            if (selectChoice == 0) {
                Print(38, 10, "Human", Color.Red);
                Print(38, 12, "Kimi", Color.White);
                Print(38, 14, "High Uvese", Color.White);
                Print(38, 16, "Bronk", Color.White);
                Print(38, 18, currentRace, Color.PeachPuff);
            }
            else if (selectChoice == 1) {
                Print(38, 10, "Human", Color.White);
                Print(38, 12, "Kimi", Color.Red);
                Print(38, 14, "High Uvese", Color.White);
                Print(38, 16, "Bronk", Color.White);
                Print(38, 18, currentRace, Color.PeachPuff);

            }
            if (selectChoice == 2) {
                Print(38, 10, "Human", Color.White);
                Print(38, 12, "Kimi", Color.White);
                Print(38, 14, "High Uvese", Color.Red);
                Print(38, 16, "Bronk", Color.White);
                Print(38, 18, currentRace, Color.PeachPuff);

            }
            else if (selectChoice == 3) {
                Print(38, 10, "Human", Color.White);
                Print(38, 12, "Kimi", Color.White);
                Print(38, 14, "High Uvese", Color.White);
                Print(38, 16, "Bronk", Color.Red);
                Print(38, 18, currentRace, Color.PeachPuff);

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
                SadConsole.Global.CurrentScreen = conMan.gameScreen;
            }
        }
    }
}