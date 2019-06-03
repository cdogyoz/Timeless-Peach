using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Timeless_Peach.src.constructs {
    class HumanConstruct : PlayableConstruct {


        //Human specific instructions go here

        public HumanConstruct(Point position) : base(Color.White, Color.Black, (int)'@', position) {

        }

    }
}
