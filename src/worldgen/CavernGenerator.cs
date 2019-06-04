using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using SadConsole;
using Timeless_Peach.src.consoles;

namespace Timeless_Peach.src.worldgen {
    class CavernGenerator {

        private int width = 100;
        private int height = 100;
        private int seed;
        private WorldConsole world;

        public CavernGenerator(int width, int height, WorldConsole world) {
            
            this.world = world;
            seed = DateTime.Now.Millisecond;
        }

        public Tile[] CreateLevel() {

            Tile[,] twoLevel = new Tile[width, height];
            Tile[] oneLevel = new Tile[width * height];
            Random r = new Random(seed);

            for (int x = 0; x < width; x++) {
                for(int y = 0; y < height; y++) {
                    int randNum = r.Next(0, 100);
                    
                    if(randNum <= 30) {
                        twoLevel[x, y] = new Tile(Color.White, Color.Black, (int)'#', true, "wall");
                    } else {
                        twoLevel[x, y] = new Tile(Color.White, Color.Black, (int)'-', false, "ground");
                    }
                }
            }

            int smooths = 3;

            for(int s = 0; s < smooths; s++) {
                Tile[,] smoothedLevel = new Tile[width, height];
                for(int x = 0; x < width ; x++) {

                    for(int y = 0; y < height; y++) {
                        //Count amount of walls in 3x3 area
                        //The tile becomes a wall if 5 or more neighbor tiles are walls
                        int walls = 0;

                        if (world.IsValidCell(x, y) && twoLevel[x, y].name == "wall") {
                            walls++;
                        }
                        if (world.IsValidCell(x-1, y-1) && twoLevel[x-1, y-1].name == "wall") {
                            walls++;
                        }
                        if (world.IsValidCell(x, y-1) && twoLevel[x, y-1].name == "wall") {
                            walls++;
                        }
                        if (world.IsValidCell(x + 1, y - 1) && twoLevel[x + 1, y - 1].name == "wall") {
                            walls++;
                        }
                        if (world.IsValidCell(x - 1, y ) && twoLevel[x - 1, y].name == "wall") {
                            walls++;
                        }
                        if (world.IsValidCell(x + 1, y) && twoLevel[x + 1, y].name == "wall") {
                            walls++;
                        }
                        if (world.IsValidCell(x - 1, y + 1) && twoLevel[x - 1, y + 1].name == "wall") {
                            walls++;
                        }
                        if (world.IsValidCell(x, y + 1)) {
                            if(twoLevel[x, y + 1].name == "wall") {
                                walls++;
                            }

                        }
                        if (world.IsValidCell(x + 1, y + 1) && twoLevel[x + 1, y + 1].name == "wall") {
                            walls++;
                        }

                        //Check if walls are greater than or equal to 5
                        if(walls >= 4) {
                            smoothedLevel[x, y] = new Tile(Color.SaddleBrown, Color.Black, (int)'#', true, "wall");

                        } else {
                            smoothedLevel[x, y] = new Tile(Color.Gray, Color.Black, (int)'-', false, "ground");
                          
                        }
                    }
                }
               
                for(int x = 0; x < width; x++) {
                    for(int y = 0; y < height; y++) {
                        twoLevel[x, y] = smoothedLevel[x, y];
                    }
                }
            }

            twoLevel[25, 10] = new Tile(Color.White, Color.Red, (int)'<', false, "downstair");

            //twoLevel = Decorate(twoLevel);

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

        public Cell[] Decorate(Cell[,] level) {

            return new Cell[64];
        }

    }
}
