using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Car
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public virtual void Draw()
        {

        }
    }

    class Circle : Car
    {
        public override void Draw()
        {
            base.Draw();
        }
    }
}
