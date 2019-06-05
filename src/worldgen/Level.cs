using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using Timeless_Peach.src.consoles;
using Timeless_Peach.src.constructs;
using SadConsole.Entities;
using Microsoft.Xna.Framework;
using GoRogue;

namespace Timeless_Peach.src.worldgen {
    class Level : CellSurface {

        public GoRogue.MultiSpatialMap<Construct> entities; //A list that allows multiple construct to be stored at the same position
        public static GoRogue.IDGenerator IDGenerator = new GoRogue.IDGenerator();
        private int floor;

        public Level(LevelTypes type, WorldConsole world, int floor) : base(100, 100) {
            this.floor = floor;
            entities = new GoRogue.MultiSpatialMap<Construct>();

            if (type == LevelTypes.CAVERNS) {
                Cell[] map = new CavernGenerator(base.Width, base.Height, world).CreateLevel();
                base.SetSurface(map, base.Width, base.Height);

                //Add skeletons around the level 
                for (int i = 0; i < 15; i++) {
                    Random r = new Random(i);
                    int x = 10 + i;
                    int y = 10 + i;

                    SkeletonConstruct skel = new SkeletonConstruct(new Point(x, y));

                    entities.Add(skel, new Point(10, 10)); 
                }
            }
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
