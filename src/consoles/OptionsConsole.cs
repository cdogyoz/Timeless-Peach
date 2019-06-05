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
	class OptionsConsole : SadConsole.Console {
        private ConsoleManager conMan;
        private int selectChoice = 0;

        public OptionsConsole(ConsoleManager conMan) : base(TimelessPeach.Width, TimelessPeach.Height)
        {
            this.conMan = conMan;
        }

        public override void Update(TimeSpan timeElapsed)
        {
            Clear();
            DrawMenuOptions();
            CheckInput();
            base.Update(timeElapsed);
        }
        private void DrawMenuOptions()
        {
            Print(0, 0, " ".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.Purple);
            Print(0, 2, " ".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.Purple);
            Print(0, 1, "OPTIONS".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Black, Color.Purple);

            if (selectChoice == 0){
                Print(0, 18, "Fullscreen?".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
                Print(0, 20, "Back".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
            }
            else if (selectChoice == 1)
            {
                Print(0, 18, "Fullscreen?".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.White);
                Print(0, 20, "Back".Align(HorizontalAlignment.Center, TimelessPeach.Width), Color.Red);
            }
        }

        private void CheckInput()
        {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Down)){
                if (selectChoice < 1){
                    selectChoice++;
                }
                else{
                    selectChoice = 0;
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Up))
            {
                if (selectChoice > 0)
                {
                    selectChoice--;
                }
                else
                {
                    selectChoice = 1;
                }
            }

            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)){
                if (selectChoice == 0){
                    
                }
                else if (selectChoice == 1){
                    SadConsole.Global.CurrentScreen = conMan.escape;
                    selectChoice = 0;
                }
            }
        }
    }
}
