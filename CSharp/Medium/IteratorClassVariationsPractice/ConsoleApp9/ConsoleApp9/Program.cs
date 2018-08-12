using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IList<int>> vector = new List<IList<int>>();
            //innerList 1
            IList<int> innerList1 = new List<int>();
            innerList1.Add(1);
            innerList1.Add(2);
            innerList1.Add(3);
            innerList1.Add(4);
            vector.Add(innerList1);
            //innerList 1
            IList<int> innerList2 = new List<int>();
            innerList2.Add(5);
            vector.Add(innerList2);
            //innerList 1
            IList<int> innerList3 = new List<int>();
            innerList3.Add(6);
            innerList3.Add(7);
            innerList3.Add(8);
            vector.Add(innerList3);
            //innerList 1
            IList<int> innerList4 = new List<int>();
            innerList4.Add(9);
            innerList4.Add(10);
            innerList4.Add(11);
            innerList4.Add(12);
            innerList4.Add(13);
            vector.Add(innerList4);
            /*
             1 2  3  4
             5
             6 7  8
             9 10 11 12 13
             */
            IteratorC itr = new IteratorC(vector);
            while (itr.hasNext())
            {
                System.Console.Write(itr.next()+",");
            }
            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    }
}
