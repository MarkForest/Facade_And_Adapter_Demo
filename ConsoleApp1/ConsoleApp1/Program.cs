using ConsoleApp1.Adaptee;
using ConsoleApp1.Adapter;
using ConsoleApp1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

          

            List<DuckBase> ducks = new List<DuckBase>();
            DuckBase duck = new MallardDuck();
            Turkey turkey = new WildTurkey();
            DuckBase turkeyAdaptee = new TurkeyAdapter(turkey);
          
            ducks.AddRange(new DuckBase[] {
                new TurkeyAdapter(new WildTurkey()),
                new MallardDuck(),
                duck,
                turkeyAdaptee
            });

            foreach (var item in ducks)
            {
                item.Fly();
                item.Quack();

                Console.WriteLine("================");
            }

    

            Console.ReadKey();

        }
    }
}
