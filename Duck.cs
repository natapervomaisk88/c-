using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SPU221_NET
{
  
 
    internal class Duck : IFly
    {
        public void fly()
        {
            Console.WriteLine("I am duck. I am flying...");
        }
    }
}
