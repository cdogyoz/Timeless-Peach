using System;
using Microsoft.Xna.Framework;
using SadConsole;
using SadConsole.Controls;


namespace Timeless_Peach.src.consoles {
    class InfoConsole : SadConsole.Console {

        private PlayConsole playCon;

        public InfoConsole(PlayConsole playCon) : base(15, 20) {
            this.playCon = playCon;

            Fill(Color.Orange, Color.Orange, ' ', null);
            Print(1, 0, "INFO CONSOLE", Color.White);
            Print(0, 5, "Health: " + playCon.player.getHealth(), Color.White);
            
        }

        public override void Update(TimeSpan timeElapsed) {
            
            if(playCon.lastTurn < playCon.turn)
                Print(0, 4, "Turn: " + playCon.turn, Color.White);

            base.Update(timeElapsed);
        }

    }
}
