using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adaptee
{
    public class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("I can fly but on short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
    }
}
