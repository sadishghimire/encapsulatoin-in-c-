using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classpractice
{
    internal class Car
    {
        private Radio radio=new Radio();
        public void turnswitch(bool turn)
        {
            radio.Radioonoff(turn);
        }
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.turnswitch(false);
        }
    }
}
