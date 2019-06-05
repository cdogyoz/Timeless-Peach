﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Timeless_Peach.src.consoles;
using SadConsole;

namespace Timeless_Peach.src.constructs {
    class MonsterConstruct : Construct{

        protected Point playerPos;

        public MonsterConstruct(Color foreground, Color background, int glyph) : base(foreground, background, glyph, new Point()) {
        }

        protected void FindPlayer() {

        }
    }
}
