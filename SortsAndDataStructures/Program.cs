using System;
using System.Diagnostics;

namespace SortsAndDataStructures {
	class MainClass {
		public static void Main (string[] args) {
            Console.WriteLine("Hello World!");
            RunMySorts();

	    }
        public static void RunMySorts() {
            int[] ints = new int[] { 5, 22, 7, 84, -2 };
            ISorter sorter = new QuickSorter();
            sorter.sort(ints);
            //SelectionSorter.sort(ints);
            //ints = new int[] { 5, 22, 7, 84, -2 };
            //BubbleSorter.sort(ints);
            //ints = new int[] { 5, 22, 7, 84, -2 };
            //MergeSorter.sort(ints, 0, ints.Length - 1);
            for (int i = 0; i < ints.Length; i++) {
                Console.WriteLine(ints[i]);
            }
        }
        public static void AssertIfSorted(int[] ints) {
            for (int i = 0; i < ints.Length - 1; i++) {
                Debug.Assert(ints[i] <= ints[i + 1]);
            }
        }
	}
}
