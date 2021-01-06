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

        public T this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
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
        public void Indexer()
        {

        }

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

        //public void Remove(T input)
        //{
        //    //iterate over the array
        //        //if the current index of the array  matches input
        //            //remove the current index

        //    //figure out a way to fill empty indexes after removal

        //    for (int i = 0; i < count; i++)
        //    {
        //        if (array[i].Equals(input))
        //        {
        //            array[i] = null;
        //        }
        //    }
        //}

        //public T Indexer (int index)
        //{
        //
        //}
    }
}
