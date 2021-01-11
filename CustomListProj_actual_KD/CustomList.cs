using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CustomListProj_actual_KD
{
    public class CustomList<T> : IEnumerable
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
                if (i > count - 1 || i < 0)
                {
                    throw new IndexOutOfRangeException("The collection only contains " + (count - 1) + " indexes");
                }
                return array[i];
            }
            set
            {
                if (i > count - 1 || i < 0)
                {
                    throw new IndexOutOfRangeException("The collection only contains " + (count - 1) + " indexes");
                }
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

                capacity *= 2;
                array[count] = input;
                count++;
            }
            else
            {
                array[count] = input;
                count++;
            }
        }

        public bool Remove(T input)
        {
            int position = ContainsAt(input);
            if (position >= 0)
            {
                RemoveAt(position);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < count; i++)
            {
                if (i < capacity)
                {
                    array[i] = array[i + 1];
                }
            }
            count--;
        }

        public int ContainsAt(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < count; i++)
            {
                result += array[i].ToString();
            }

            return result;
        }

        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            //try using existing Add method
            for (int i = 0; i < list2.count; i++)
            {
                list1.Add(list2[i]);
            }

            return list1;
        }

        public static CustomList<T> operator -(CustomList<T> list1, CustomList<T> list2)
        {
            for (int i = 0; i < list2.Count; i++)
            {
                for (int j = 0; j < list1.Count; j++)
                {
                    if (list2[i].Equals(list1[j]))
                    {
                        list1.Remove(list1[j]);
                    }
                }
            }
            return list1;
        }

        public CustomList<T> Zip(CustomList<T> list)
        {
            CustomList<T> resultList = new CustomList<T>();

            int longestCount;
            if (Count > list.Count)
            {
                longestCount = Count;
            }
            else
            {
                longestCount = list.Count;
            }

            for (int i = 0; i < longestCount; i++)
            {
                if (i > (count - 1))
                {
                    resultList.Add(list[i]);
                }
                else if (i > (list.count - 1))
                {
                    resultList.Add(array[i]);
                }
                else
                {
                    resultList.Add(array[i]);
                    resultList.Add(list[i]);
                }
            }
            return resultList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return array[i];
            }
        }
    }
}
