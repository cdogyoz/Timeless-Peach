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
        protected int stamina;
        protected int mana;

        public Construct(Color foreground, Color background, int glyph, Point position) : base(foreground, background, glyph) {
            Position = position;
            //this.name = name;
        }

        public int getStrength() {
            return strength;
        }

        protected int CalculateHealth() {
            return (strength * 4);
        }

        protected int CalculateMana() {
            return (divinity * 4);
        }

        public int GetMana() {
            return mana;
        }

        public int getHealth() {
            return health;
        }

        public int getStamina() {

            return stamina;
        }

        public void setStamina(int stamina) {
            this.stamina = stamina;
        }
    }
}
