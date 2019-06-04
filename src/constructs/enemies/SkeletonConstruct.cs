using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timeless_Peach.src.consoles;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.constructs {
    class SkeletonConstruct : MonsterConstruct{

        public SkeletonConstruct(Point position, PlayConsole playCon) : base(Color.White, Color.DeepPink, (int)'S', new Point(0, 0), playCon) {
            Position = position;
            base.playCon = playCon;
        } 

    }
}
