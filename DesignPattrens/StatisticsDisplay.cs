using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    public class StatisticsDisplay : IObserver , IDisplay
    {
        private ISubject subject;
        public StatisticsDisplay(ISubject weather)
        {
            subject = weather;
            subject.RegisterObsever(this);
        }
        public void update(string userKeyword)
        {
            Console.WriteLine("{0} ,update function in Statistics display" ,userKeyword);
        }
    }
}
