using System;
using Microsoft.Xna.Framework;
using SadConsole;

namespace Timeless_Peach.src.constructs {
    class Construct : SadConsole.Entities.Entity {
        
        public Construct(Color foreground, Color background, int glyph, Point position) : base(foreground, background, glyph) {
            Position = position;
        }

    }
}
