using System;
using System.Diagnostics;

namespace SortsAndDataStructures {
	class MainClass {
		public static void Main (string[] args) {
            Console.WriteLine("Hello World!");
            //TestAllSorts();
            int[] ints = new int[6];
            MyList<int> list = new MyList<int>();
            list.Add(8);
            list.Add(22);
            list.Add(13);
            list.Add(91);
            Console.WriteLine(list.Count);
            //Console.WriteLine(list.Contains(8));
            //list.CopyTo(ints, 0);
            //for(int i = 0; i < ints.Length; i++)
            //    Console.WriteLine(ints[i]);
            //Console.WriteLine(list.IndexOf(22));
            list.Insert(2, 55);
            Console.WriteLine(list.Count);
	    }
        //Runs all the different kinds of sorts.
        public static void TestAllSorts() {
            TestSorter(new BubbleSorter());
            TestSorter(new InsertionSorter());
            TestSorter(new MergeSorter());
            TestSorter(new QuickSorter());
            TestSorter(new SelectionSorter());
        }

        static void TestSorter(ISorter sorter) {
            int[] ints = new int[] { 5, 22, 7, 84, -2 };
            RunSorter(ints, sorter);
            ints = new int[] { 4 };
            RunSorter(ints, sorter);
            ints = new int[] { 1, 6, 4, 3, 4, 6, 2, 2, 3, 4, 6, 2, 5, 5, 23465, 2, 46, 2, 34, 6, 2, 34, 6, 2, 4, 62, 5, 62, 456, 3, 45, 63, 45, 6, 3, 45, 61, 451, 13, 3456, 734, 576, 37, 4576, 345, 621, 243, 6, 245, 63, 345, 6, 4, 3, 56, 3, 345, 673, 3457, 345, 3456, 34, 4356, 34, 56, 38, 658, 67, 5, 562, 1, 1458, 2, 15, 78, 82, 1, 43, 678, 113, 346, 7 };
            RunSorter(ints, sorter);
        }
        static void RunSorter(int[] ints, ISorter sorter) {
            sorter.sort(ints);
            AssertIfSorted(ints);
        }
        public static void AssertIfSorted(int[] ints) {
            for (int i = 0; i < ints.Length - 1; i++) {
                Debug.Assert(ints[i] <= ints[i + 1]);
            }
        }
	}
}
