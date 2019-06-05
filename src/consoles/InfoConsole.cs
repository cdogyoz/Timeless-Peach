using System;
using Microsoft.Xna.Framework;
using SadConsole;
using SadConsole.Controls;


namespace Timeless_Peach.src.consoles {
    class InfoConsole : SadConsole.Console {

        private PlayConsole playCon;

        public InfoConsole(PlayConsole playCon) : base(35, 50) {
            this.playCon = playCon;
            Fill(Color.DarkGray, Color.DarkGray, ' ', null);
            Print(1, 0, "INFO CONSOLE", Color.White);
        }

        public override void Update(TimeSpan timeElapsed) {
            
            if(playCon.lastTurn < playCon.turn)
                Print(0, 4, "Turn: " + playCon.turn, Color.White);

            //Print(0, 1, "Level: " + playCon.curLevel
            Print(0, 2, playCon.player.GetName(), Color.White, Color.Blue);
            Print(0, 5, "Health: " + playCon.player.getHealth(), Color.Pink);
            Print(0, 6, "Mana: " + playCon.player.getMana(), Color.Blue);
            Print(0, 7, "Strength: " + playCon.player.getStrength(), Color.Red);
            Print(0, 8, "Divinity: " + playCon.player.getDivinity(), Color.Aqua);
            Print(0, 9, "Stamina: " + playCon.player.getStamina(), Color.Green);

            base.Update(timeElapsed);
        }

    }
}
