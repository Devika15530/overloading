using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle v = new Vehicle();

            Bus b = new Bus();
            Car c = new Car("blue",150,"kkkk");
           
            //v.Start();
            //v.Stop();
            b.Start();
            b.Stop();
            b.Fuel();
            b.Run();
            c.Start();
            c.Stop();
            c.Fuel();
            c.Drive();
            Console.ReadKey();
            
        }
    }
}
