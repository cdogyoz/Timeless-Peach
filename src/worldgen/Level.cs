using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using Timeless_Peach.src.consoles;

namespace Timeless_Peach.src.worldgen {
    class Level : CellSurface {

        public Level(LevelTypes type, WorldConsole world) : base(100, 100) {
            if(type == LevelTypes.CAVERNS) {
                Cell[] map = new CavernGenerator(base.Width, base.Height, world).CreateLevel();
                base.SetSurface(map, base.Width, base.Height);
            }
        }

    }
}
