using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classpractice.Polymorphism
{
    //We will use method overloading in this scene
    internal class Polymorphismexample
    {
        public void MessageReceive() {
            Console.WriteLine("No message received");
        }
        public void MessageReceive(string msg)
        {
            Console.WriteLine("Text message received:{0}",msg);
        }
        public void MessageReceive(int  msg)
        {
            Console.WriteLine("Number message received:{0}", msg);
        }

        public static void Main(string[] args) { 
        Polymorphismexample poly = new Polymorphismexample();
            poly.MessageReceive();
            poly.MessageReceive("Hello");
            poly.MessageReceive(5);
        }
    }
}
