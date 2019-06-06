using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using Timeless_Peach.src.consoles;
using Timeless_Peach.src.constructs;
using SadConsole.Entities;
using SadConsole.Components;
using Microsoft.Xna.Framework;
using GoRogue;
using GoRogue.MapGeneration;
using GoRogue.MapViews;
using Troschuetz.Random;
using Troschuetz.Random.Generators;

namespace Timeless_Peach.src.worldgen {
    class Level : CellSurface {

        public GoRogue.MultiSpatialMap<Construct> entities; //A list that allows multiple construct to be stored at the same position
        public ArrayMap<bool> fovMap;
        public static GoRogue.IDGenerator IDGenerator = new GoRogue.IDGenerator();
        public FOV fov;
        private int floor;

        public Level(LevelTypes type, WorldConsole world, int floor) : base(100, 100) {
            this.floor = floor;
            fovMap = new ArrayMap<bool>(Width, Height);
            fov = new FOV(fovMap);
            entities = new GoRogue.MultiSpatialMap<Construct>();

            if (type == LevelTypes.CAVERNS) {
                Cell[] map = new CavernGenerator(base.Width, base.Height, world, this).CreateLevel();
                base.SetSurface(map, base.Width, base.Height);

                Point monsterPosition;
                //Add skeletons around the level 
                for (int i = 0; i < 15; i++) {
                    Random r = new Random(i);
                    monsterPosition = new Point(r.Next(0, 100), r.Next(0, 100));

                    SkeletonConstruct skel = new SkeletonConstruct();
                    skel.Position = monsterPosition;
                    skel.Components.Add(new EntityViewSyncComponent());
                    entities.Add(skel, monsterPosition); 
                }
            }
        }

        //Returns FOV object from the players current postion
        public FOV GetFOV(Point playerPos) {
            fov.Calculate(playerPos, 3);
            return fov;
        }

        //If a certain type of object exists at a position in the Multi spatial map, get that object
        public T GetEntityAt<T>(Point position) where T : Construct {
            return entities.GetItems(position).OfType<T>().FirstOrDefault();
        }

        //Adds a construct to the multi-spatial map
        public void Add(Construct construct) {
            entities.Add(construct, construct.Position);
            construct.Moved += OnEntityMoved;
        }

        //Removes a construct from the multi-spatial map
        public void Remove(Construct construct) {
            entities.Remove(construct);
            construct.Moved -= OnEntityMoved;
        }

        private void OnEntityMoved(object sender, Entity.EntityMovedEventArgs args) {
            entities.Move(args.Entity as Construct, args.Entity.Position);
        }

    }
}
