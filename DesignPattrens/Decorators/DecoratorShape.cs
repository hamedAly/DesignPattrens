using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    public abstract class DecoratorShape: Shape
    {
        public Shape MyShape { get; set; }
        public DecoratorShape(Shape MyShape)
        {
            this.MyShape = MyShape;
        }
    }
}
