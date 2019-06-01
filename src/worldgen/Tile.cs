using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.worldgen {
    public class Tile : Cell {

        public bool solid;

        public string name;

        public Tile(Color foreground, Color background, int glyph, bool solid = false, string name = "" ) : base(foreground, background, glyph) {
            this.solid = solid;
            this.name = name;
        }

    }
}
