using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPU221_NET
{
    abstract class Transport
    {
        //Класс называется абстрактным, если у него есть хотя бы 1 абстрактный метод
        //Абстрактные методы должны быть обязательно реализованы в классах-наследниках
        abstract public void Drive();
        abstract public void Stop();
    }
}
