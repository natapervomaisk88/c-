using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPU221_NET
{
    struct Car
    {
        public string Name; //referance type (null)
        public int Year; //value type 0
        public bool isMove; // value type false

        public string getName()
        {
            return Name;
        }

        public int getYear()
        {
            return Year;
        }

        public bool getIsMove()
        {
            return isMove;
        }

        public Car(string name)
        {
            Console.WriteLine(name);
            Year = 2000;
            Name = name;
            isMove = false;
        }
        public Car(string name, int year)
        {
            Console.WriteLine(name);
            Name = name;
            Year = year;
            isMove = true;
        }

    }
}
