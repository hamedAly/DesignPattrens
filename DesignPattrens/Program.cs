 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherdata = new WeatherData(); 
            var thirdPart =new ThirdPartyDisplay(weatherdata);
            var currentCondition = new CurrentConditionsDisplay(weatherdata);
            string keyword = Console.ReadLine();
            thirdPart.removeObsever();
            weatherdata.GetDataFromUI(keyword);
            Console.ReadKey();
        }
    }
}
