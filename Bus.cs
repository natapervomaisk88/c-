using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPU221_NET
{

    class Bus : Transport
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public override void Drive()
        {
            Console.WriteLine("i am moving....Bus");
        }

        public override void Stop()
        {
            Console.WriteLine("Stoped");
        }
    }
}
