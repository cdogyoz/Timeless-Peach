using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Timeless_Peach.src.consoles;
using Timeless_Peach.src.constructs;
using SadConsole.Entities;

namespace Timeless_Peach.src.worldgen {
    class World {
        public List<Level> dungeon;
        public GoRogue.MultiSpatialMap<Construct> Entities; //Basically a more efficient List for storing things
        private int width;
        private int height;

        public World() {

        }

        public World(int width, int height, WorldConsole world) {
            dungeon = new List<Level>(); //Create a new dungeon with 5 total levels
            this.width = width;
            this.height = height;

            //Generate all floors of the dungeons
            for(int i = 0; i < 5; i++) {

                //Generate the first 5 floors as caverns
                if(i <= 6) {
                    dungeon.Add(new Level(LevelTypes.CAVERNS, world));
                }

            }

        }
    }
}
