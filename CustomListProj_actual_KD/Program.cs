using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj_actual_KD
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> test1 = new CustomList<int>();
            test1.Add(3);
            test1.Add(3);
            test1.Add(3);
            test1.Add(3);
            test1.Add(3);
            Console.ReadLine();
        }
    }
}
