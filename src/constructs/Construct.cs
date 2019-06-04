using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using SadConsole;

namespace Timeless_Peach.src.constructs {
    public abstract class Construct : SadConsole.Entities.Entity, GoRogue.IHasID {

        //private string name;
        protected string name;
        protected int strength;
        protected int agility;
        protected int intelligence;
        protected int divinity;
        protected int health;
        protected int stamina;
        protected int mana;

        public uint ID { get; private set; }

        public Construct(Color foreground, Color background, int glyph, Point position) : base(foreground, background, glyph) {
            Position = position;
            //this.name = name;
        }
        public void MoveBy(Point move) {
            Position += move;
        }

        public string GetName() {
            return name;
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

        public int getMana() {
            return mana;
        }

        public int getHealth() {
            return health;
        }

        public int getStamina() {

            return stamina;
        }

        public int getDivinity()
        {
            return divinity;
        }

        public void setStamina(int stamina) {
            this.stamina = stamina;
        }
    }
}
