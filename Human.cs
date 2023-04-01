using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPU221_NET
{
    class Human
    {
        public void show() { }
    }
    class Student : Human
    {
        public Student() : base() { }

        public void show2()
        {
            base.show();
        }
    }

}
