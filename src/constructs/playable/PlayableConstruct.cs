using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.constructs {
    class PlayableConstruct : Construct {

        public int maxStamina;

        //Anything that is playable will inherit from this class

        public PlayableConstruct(Color foreground, Color background, int glyph, Point position) : base(foreground, background, glyph, position) {
            IsVisible = true;
        }

    }
}
