using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPU221_NET
{
    public class MyArray
    {
        private int[] _array;
        private int _size;

        private void CreateArray()
        {
            _array = new int[_size];
        }
        public int Size
        {
            get { return _size; }
            set { 
                if(_size>0 && value!=_size)
                {
                    _size = value;
                    CreateArray();
                }
            }
        }

        public MyArray(int size)
        {
            if(size>0)
            {
                _size = size;
                CreateArray();
            }
               
        }
        public MyArray()
        {
            _size = 10;
            CreateArray();
        }

        public int this[int index] //индексатор - отдельная конструкция языка
        {
            get { 
                if(index>=0 && index<_size)
                {
                    return _array[index];
                }
                throw new Exception("Некорректный индекс");
            }
            set
            {
                if (index >= 0 && index < _size)
                {
                    _array[index] = value;
                }
            }
        }

    }
}
