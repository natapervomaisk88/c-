using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPU221_NET
{
    internal class MyArray2D
    {
        private int _rows;
        private int _cols;
        private int[,] _array;

        public int Cols
        {
            get { return _cols; }
            set { if(_cols!=value) _cols = value; }
        }

        public int Rows
        {
            get { return _rows; }
            set { _rows = value; }
        }

        private void CreateArray()
        {
            if(_rows>0 && _cols>0)
            _array = new int[_rows, _cols];
        }
        public MyArray2D()
        {
            _rows = 4;
            _cols = 3;
            CreateArray();
        }
        public MyArray2D(int rows,int cols)
        {
            if(rows>0 && cols>0)
            {
                _rows = rows;
                _cols = cols;
                CreateArray();
            }
        }

        public int this[int row, int col]
        {
            get
            {
                if(row>=0 && col>=0 && row<_rows && col<_cols )
                {
                    return _array[row, col];
                }
                throw new Exception("Некорректный индекс");
            }
            set
            {
                if (row >= 0 && col >= 0 && row < _rows && col < _cols)
                {
                    _array[row, col] = value;
                }               
            }
        }
    }
}
