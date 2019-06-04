using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.constructs {
    class SkeletonConstruct : MonsterConstruct{

        public SkeletonConstruct(Point position) : base(Color.White, Color.DeepPink, (int)'S', new Point(0, 0)) {
            Position = position;
        } 

    }
}
