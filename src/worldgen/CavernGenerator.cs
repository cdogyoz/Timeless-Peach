using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.worldgen {
    class CavernGenerator {

        private int width = 65;
        private int height = 20;

        public CavernGenerator(int width, int height) {
            this.width = width;
            this.height = height;
        }

        public Tile[] CreateLevel() {

            Tile[,] twoLevel = new Tile[width, height];
            Tile[] oneLevel = new Tile[width * height];

            for(int x = 0; x < width; x++) {
                for(int y = 0; y < height; y++) {
                    Random r = new Random(x * y);
                    int randNum = r.Next(0, 100);
                    
                    if(randNum <= 50) {
                        twoLevel[x, y] = new Tile(Color.White, Color.Black, (int)'#');
                    } else {
                        twoLevel[x, y] = new Tile(Color.White, Color.Black, (int)'-');
                    }
                }
            }

            //Convert to 1D array
            int i = 0;
            for(int x = 0; x < width; x++) {
                for(int y = 0; y < height; y++) {
                    oneLevel[i] = twoLevel[x, y];
                    i++;
                }
            }

            return oneLevel;

        }
    }
}
