using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class DynamicArrayExeption : Exception
    {
        public DynamicArrayExeption(string message) : base(message)
        {
        }
    }
    class DynamicArray<T> where T : IComparable<T>, new()
    {

        public T this[int index]
        {
            set
            {
                if (index > array.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    array[index] = value;
                }

            }
            get
            {
                return array[index];
            }
        }

        private T[] array;
        private int length;
        public DynamicArray() : this(8)
        {

        }
        public DynamicArray(int Size)
        {
            this.array = new T[Size];
            length = 0;
        }
        public DynamicArray(T[] array)
        {
            this.array = array;
            length = array.Length;
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public int Capacity //объем массива
        {
            get
            {
                return array.Length;
            }
        }
        public void Add(T item)
        {
            if (length == array.Length)
            {
                ChangeCapacity(array.Length * 2);

            }
            array[length++] = item;
        }
        public T[] AddRange(T[] item)
        {
            if (array.Length < item.Length + array.Length)
            {

                ChangeCapacity(item.Length + Capacity);
                item.CopyTo(array, length);
                length = length + item.Length;
                return array;
            }
            else
            {
                item.CopyTo(array, length);
                return array;
            }
        }

        public void Sort()
        {
            for(var i = 0; i < length; i++)
            {
                for (var j = 0; j < length; j++)
                {
                    if (array[i].CompareTo(array[j])>0)
                    {
                        var tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }

        public void Insert(int index, T element)
        {
            T[] result = new T[array.Length + 1];
            if (index > Length + 1)
            {
                throw new ArgumentOutOfRangeException("index don't must be more long array");
            }
            Array.Copy(array, result, index);
            result[index] = element;
            Array.Copy(array, index, result, index + 1, array.Length - index);

            array = result;
            length ++;
        }
        public bool Remove(int index)
        {
            if (index > array.Length)
            {
                return false;
            }
            else
            {
                for (int i = index+1; i < array.Length; i++)
                {
                    array[i - 1] = array[i];
                    if (i == Length - 1)
                    {
                        array[i] = default(T);
                    }
                }
                length--;
                return true;
            }
        }
        private void ChangeCapacity(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            array.CopyTo(newArray, 0);
            array = newArray;
        }

    }

}
