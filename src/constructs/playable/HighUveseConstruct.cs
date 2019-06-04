using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.constructs {
    class HighUveseConstruct : PlayableConstruct {


        //High uvese specific instructions go here

        public HighUveseConstruct(Point position) : base(Color.Blue, Color.Black, (int)'@', position) {
            base.strength = 7;
            base.agility = 7;
            base.intelligence = 12;
            base.divinity = 15;
            base.stamina = 100;
            health = CalculateHealth();
            mana = CalculateMana();
        }

    }
}

