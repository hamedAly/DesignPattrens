using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private ISubject subject;
        public CurrentConditionsDisplay(ISubject weather)
        {
            subject = weather;
            subject.RegisterObsever(this);
        }
        public void update(string userKeyword)
        {
            Console.WriteLine("{0} ,update function in Current Conditions display", userKeyword);
        }
    }
}
