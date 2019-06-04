using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.constructs {
    class BronkConstruct : PlayableConstruct {

        //Bronk specific instructions go here

        public BronkConstruct(Point position) : base(Color.Red, Color.Black, (int)'@', position) {
            base.strength = 15;
            base.agility = 5;
            base.intelligence = 10;
            base.divinity = 7;
            base.stamina = 100;
            health = CalculateHealth();
            mana = CalculateMana();
        }

    }
}

