using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentSample
{
    class Program
    {
        static void Main(string[] args)
        {            
            PlayerImplementation p = new PlayerImplementation();
            var mj = p.Create("michael", "jordan", 99)
                .Run()
                .MakeAssist()
                .Run()
                .Run()
                .MakeAssist()
                .GetPlayer();
            Console.WriteLine("{0} - {1} - {2}", mj.FirstName, mj.LastName, mj.Power);
            Console.ReadLine();            
        }
    }
    

}
