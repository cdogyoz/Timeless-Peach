using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using Timeless_Peach.src.consoles;
using Timeless_Peach.src.constructs;

namespace Timeless_Peach.src.worldgen {
    class Level : CellSurface {

        public GoRogue.MultiSpatialMap<Construct> Entities; //A list that allows multiple entities to be stored at the same position
        public static GoRogue.IDGenerator IDGenerator = new GoRogue.IDGenerator();

        public Level(LevelTypes type, WorldConsole world) : base(100, 100) {

            Entities = new GoRogue.MultiSpatialMap<Construct>();

            if(type == LevelTypes.CAVERNS) {
                Cell[] map = new CavernGenerator(base.Width, base.Height, world).CreateLevel();
                base.SetSurface(map, base.Width, base.Height);
            }
        }

    }
}
