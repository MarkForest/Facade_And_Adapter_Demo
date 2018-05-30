using ConsoleApp1.Adaptee;
using ConsoleApp1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    public class TurkeyAdapter : DuckBase
    {
        Turkey turkey = null;
        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }
        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
