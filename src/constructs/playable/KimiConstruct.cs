using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.constructs {
    class KimiConstruct : PlayableConstruct {


        //Kimi specific instructions go here

        public KimiConstruct(Point position) : base(Color.Yellow, Color.Black, (int)'@', position) {
            base.strength = 8;
            base.agility = 13;
            base.intelligence = 12;
            base.divinity = 7;
            base.stamina = 100;
            health = CalculateHealth();
            mana = CalculateMana();
        }

    }
}

