using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class ArrayList
    {
        private int[] _array;
        private int _currentLength;
        public ArrayList()
        {
            _array = new int[10];
            _currentLength = 0;
        }

        public ArrayList(int value)
        {
            _array = new int[10];
            _currentLength = 1;
            _array[0] = value;
        }

        public ArrayList(int[] array)
        {
            _array = new int[10];
            _currentLength = 0;
            MakeBiggerMyArray(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
            }
            _currentLength += array.Length;
        }

        private void MakeBiggerMyArray(int needLenght)
        {
            if (needLenght <= _array.Length)
            {
                return;
            }

            int tmp = _array.Length;

            while (tmp < needLenght)
            {
                tmp = 3 * tmp / 2;

            }
            int[] newArray = new int[tmp];
            for (int i = 0; i < _currentLength; i++)
            {
                newArray[i] = _array[i];
            }

            _array = newArray;
        }

        public int GetLength()
        {
            return _currentLength;
        }

        public int[] ToArray()
        {
            int[] newArr = new int[_currentLength];
            for (int i = 0; i < _currentLength; i++)
            {
                newArr[i] = _array[i];
            }
            return newArr;
        }


    }
}
