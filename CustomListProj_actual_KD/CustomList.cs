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
        public readonly int count;
        public int capacity;

        // constructor
        public CustomList()
        {
            count = 0;
            capacity = 4;
        }

        // member methods
        public void Add(T input)
        {
            //if count == capacity
                //create a new array with double the capacity
                //fill the array with old values,
                //fill array w new value
                //increment count
            //else
                //array[count] = input
                //count++
        }

        public void Remove(T input)
        {

        }

        public T Indexer (int index)
        {

        }
    }
}
