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

        public CharacterCreate(ConsoleManager conMan) : base(80, 25) {
            this.conMan = conMan;
            Print(33, 0, "Character Create", Color.White, Color.Black );
            Print(33, 24, "Press enter to play", Color.Black, Color.PeachPuff);
        }

        public override void Update(TimeSpan timeElapsed) {
            if (SadConsole.Global.KeyboardState.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Enter)) {
                Global.CurrentScreen = conMan.gameScreen;
            }
            base.Update(timeElapsed);
        }
    }
}
