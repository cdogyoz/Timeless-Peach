using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.worldgen {
    class World {
        public Tile[] tiles;
        private int width;
        private int height;

        public World(int width, int height) {
            tiles = new Tile[width * height];
            this.width = width;
            this.height = height;

            tiles = new CavernGenerator(width, height).CreateLevel();
        }
    }
}
