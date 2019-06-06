using Microsoft.Xna.Framework;

using SadConsole;
using SadConsole.Entities;
using System;
using Console = SadConsole.Console;
using Timeless_Peach.src.worldgen;
using Timeless_Peach.src.constructs;
using GoRogue;
using GoRogue.MapGeneration;
using GoRogue.MapViews;
using Troschuetz.Random;
using Troschuetz.Random.Generators;

namespace Timeless_Peach.src.consoles {
    class WorldConsole : ScrollingConsole{

        private const int width = 100   ;
        private const int height = 100;
        private int curLevel = 0;
        private int levelChange = 0;
        private FOV curFOV;

        private bool virgin = true;

        private World dungeon;

        public WorldConsole(World world) : base(100, 100, new Microsoft.Xna.Framework.Rectangle(0, 0, 100, 37)) {
            dungeon = world;
            Print(5, 5, "Hello World", Color.White);
        }

        public void MoveLevel(int amount) {
            SetSurface(dungeon.dungeon[curLevel].Cells, width, height);
            curLevel += amount;
            // levelChange += amount;
            // this.SetRenderCells();65

        }

        public void CenterOnPlayer(PlayableConstruct player) {
            this.CenterViewPortOnPoint(player.Position);
        }

        private void SyncMapEntities(World world) {

            //remove all entities from console
            Children.Clear();

            foreach(Construct construct in world.dungeon[curLevel].entities.Items) {
                this.Children.Add(construct);
            }
        }

        public override void Update(TimeSpan timeElapsed) {
            SyncMapEntities(dungeon);
            curFOV = dungeon.dungeon[curLevel].GetFOV(new Point(10, 10));
            if(virgin == true) {
                System.Console.Write(curFOV.ToString());
                virgin = false;
            }
            base.Update(timeElapsed);
        }
    }
}
