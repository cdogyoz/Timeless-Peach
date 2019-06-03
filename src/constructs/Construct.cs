using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Timeless_Peach.src.components;
using SadConsole;

namespace Timeless_Peach.src.constructs {
    class Construct : SadConsole.Entities.Entity {

        //private string name;
        protected int strength;
        protected int agility;
        protected int intelligence;
        protected int divinity;
        protected int health;

        public Construct(Color foreground, Color background, int glyph, Point position) : base(foreground, background, glyph) {
            Position = position;
            //this.name = name;
        }

        public int getStrength() {
            return strength;
        }

        protected int CalculateHealth() {
            return (strength * 5);
        }

        public int getHealth() {
            return health;
        }
    }
}
