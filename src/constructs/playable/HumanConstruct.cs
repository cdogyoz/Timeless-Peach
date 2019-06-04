using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.constructs {
    class HumanConstruct : PlayableConstruct {

        //Human specific instructions go here

        public HumanConstruct(string name, Point position) : base(Color.White, Color.Black, (int)'@', position) {
            base.name = name;
            base.strength = 10;
            base.agility = 10;
            base.intelligence = 10;
            base.divinity = 10;
            base.stamina = 100; //Every action costs stamina
            maxStamina = stamina;
            health = CalculateHealth();
            mana = CalculateMana();
        }

    }
}
