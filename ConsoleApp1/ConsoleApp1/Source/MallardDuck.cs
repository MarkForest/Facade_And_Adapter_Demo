using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Source
{
    public class MallardDuck : DuckBase
    {
        public void Fly()
        {
            Console.WriteLine("I can Fly");
        }

        public void Quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
