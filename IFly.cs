using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Ссылка базового класса может хранить объекты наследника
* 
* Ссылка интерфейса может хранить в себе объект любого класса, который реализует этот интерфейс
*/
namespace SPU221_NET
{
    internal interface IFly
    {
        void fly();
    }
}
