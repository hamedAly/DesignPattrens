using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    public interface ISubject
    {
        void RegisterObsever(IObserver o);
        void RemoveObsever(IObserver o);
        void Notify(string userKeyword);
    }
}
