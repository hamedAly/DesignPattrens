using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens.Decorators
{
    public class DecoratorCircleWithRedLine 
    {
        private DecoratorShape DecoratorCircle { get; set; }
        public DecoratorCircleWithRedLine(DecoratorShape DecoratorCircle) 
        {
        }
        
    }
}
