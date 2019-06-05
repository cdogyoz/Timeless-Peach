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

        public EscapeOptionsConsole(ConsoleManager conMan) : base(TimelessPeach.Width, TimelessPeach.Height){
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
            SadConsole.Global.CurrentScreen = conMan.escape;
            Print(0, 0, " ".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.Purple);
            Print(0, 2, " ".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.Purple);
            Print(0, 1, "MENU".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.Purple);

            if (selectChoice == 0){
                Print(0, 18, "Continue".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red) ;
                Print(0, 20, "Options".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 22, "Return to main menu".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
            }
            else if (selectChoice == 1){
                Print(0, 18, "Continue".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 20, "Options".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
                Print(0, 22, "Return to main menu".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
            }
            else if (selectChoice == 2)
            {
                Print(0, 18, "Continue".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 20, "Options".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 22, "Return to main menu".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
            }
        }

        private void CheckInput()
        {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)){
                if (selectChoice < 2){
                    selectChoice++;
                }
                else{
                    selectChoice = 0;
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up)){
                if (selectChoice > 0){
                    selectChoice--;
                }
                else{
                    selectChoice = 2;
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)){
                if (selectChoice == 0) {
                    SadConsole.Global.CurrentScreen = conMan.getGameScreen();
                }
                else if (selectChoice == 1) {
                    SadConsole.Global.CurrentScreen = conMan.options;
                }
                else if (selectChoice == 2) {
                    SadConsole.Global.CurrentScreen = conMan.mainMenu;
                }
            }
        }
    }
}
