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
    class EscapeOptionsConsole : SadConsole.Console {

        private ConsoleManager conMan;
        private int selectChoice = 0;

        public EscapeOptionsConsole(ConsoleManager conMan) : base(80, 25){
            this.conMan = conMan;
        }

        public override void Update(TimeSpan timeElapsed){
            Clear();
            DrawMenuOptions();
            CheckInput();
            base.Update(timeElapsed);
        }

        private void DrawMenuOptions()
        {
            Print(28, 1, "MENU", Color.White, Color.Black);

            if (selectChoice == 0){
                Print(34, 8, "Continue", Color.Red);
                Print(34, 10, "Return to main menu", Color.White);
            }
            else if (selectChoice == 1){
                Print(34, 8, "Continue", Color.White);
                Print(34, 10, "Return to main menu", Color.Red);
            }
        }

        private void CheckInput()
        {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down) || SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)){
                if (selectChoice == 0)
                    selectChoice = 1;
                else if (selectChoice == 1)
                    selectChoice = 0;
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)){
                if (selectChoice == 0){
                    SadConsole.Global.CurrentScreen = conMan.gameScreen;
                }
                else{
                    SadConsole.Global.CurrentScreen = conMan.create;
                }
            }
        }
    }
}
