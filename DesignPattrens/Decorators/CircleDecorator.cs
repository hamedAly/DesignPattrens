using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    public  class CircleDecorator : DecoratorShape
    {
        public CircleDecorator(Shape circle) : base(circle)
        {

        }
        public override void Draw()
        {
           this.MyShape.Draw();
           DrawGreenCircle();
        }
        public void DrawGreenCircle()
        {
            Console.WriteLine("and circle color is green");
        }

    }
}
