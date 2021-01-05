using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj_actual_KD
{
    public class CustomList <T>
    {
        // member variables
        private T[] array;
        private int count;
        private int capacity;

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        // constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            array = new T[capacity];
        }

        // member methods
        public void Add(T input)
        {
            if (count == capacity)
            {
                T[] bucketArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    bucketArray[i] = array[i];
                }

                array = new T[capacity * 2];
                for (int i = 0; i < count; i++)
                {
                    array[i] = bucketArray[i];
                }

                array[count] = input;
                count++;
            }
            else
            {
                array[count] = input;
                count++;
            }
        }

        public void Remove(T input)
        {

        }

        //public T Indexer (int index)
        //{
        //
        //}
    }
}
