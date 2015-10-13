using System;
using System.Diagnostics;

namespace SortsAndDataStructures {
    class MainClass {
        public static void Main(string[] args) {
            TestMyList();
			Console.WriteLine (" ---------- Sorter Timings ------------");
			TimeSort ("BubbleSorter", new BubbleSorter ());
			TimeSort ("InsertionSorter", new InsertionSorter());
			TimeSort ("MergeSorter", new MergeSorter());
			TimeSort ("QuickSorter", new QuickSorter());
			TimeSort ("SelectionSorter", new SelectionSorter());
			Console.WriteLine (" ---------- MyList Timings ------------");
			TimeFunction ("TestCount", TestCount );
			TimeFunction ("TestAdd", TestAdd );
			TimeFunction ( "TestClear", TestClear );
			TimeFunction ( "TestContains", TestContains );
			TimeFunction ( "TestCopyTo", TestCopyTo );
			TimeFunction ( "TestIndexOf", TestIndexOf );
			TimeFunction ( "TestInsert", TestInsert );
			TimeFunction ( "TestRemove", TestRemove );
			TimeFunction ( "TestRemoveAt", TestRemoveAt );
        }

		public delegate void timeFunction(MyList<int> IList );

		public static double TimeFunction( string name, timeFunction testFunction, int iterations = 100000 ) {
			Stopwatch watch = new Stopwatch ();
			watch.Start ();
			for ( int i =0;i<iterations;i++ ){
				testFunction (new MyList<int>());
			}
			watch.Stop ();
			double time = ((double)watch.ElapsedMilliseconds)/(iterations);
			Console.WriteLine ( name +"\t took an average of " + time + " miliseconds.");
			return time;
		}

		// Stopwatches the time it takes to do various sorts. Uses iterations to increase accuracy.
		public static double TimeSort( string name, ISorter SortFunction, int iterations = 100000) {
			Stopwatch watch = new Stopwatch ();
			int[] array = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
			watch.Start ();
			for ( int i =0;i<iterations;i++ ){
				SortFunction.sort (array);
				// Reset
			    array = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
			}
			array = new int[]{ 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
			for ( int i =0;i<iterations;i++ ){
				SortFunction.sort (array);
				// Reset
				array = new int[]{ 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
			}
			array = new int[]{ 20, 1, 19, 2, 18, 3, 17, 4, 16, 5, 15, 6, 14, 7, 13, 8, 12, 9, 11, 10 };
			for ( int i =0;i<iterations;i++ ){
				SortFunction.sort (array);
				// Reset
			    array = new int[]{ 20, 1, 19, 2, 18, 3, 17, 4, 16, 5, 15, 6, 14, 7, 13, 8, 12, 9, 11, 10 };
			}
			watch.Stop ();
			double time = ((double)watch.ElapsedMilliseconds)/(iterations);
			Console.WriteLine ( name +"\t took an average of " + time + " miliseconds.");
			return time;
		}

        //Tests the MyList functions.
        public static void TestMyList() {
            TestCount(new MyList<int>());
            TestAdd(new MyList<int>());
            TestClear(new MyList<int>());
            TestContains(new MyList<int>());
            TestCopyTo(new MyList<int>());
            TestIndexOf(new MyList<int>());
            TestInsert(new MyList<int>());
            TestRemove(new MyList<int>());
            TestRemoveAt(new MyList<int>());
        }

        public static void TestCount(MyList<int> inList) {
            int Count = inList.Count;
            Debug.Assert(Count == 0);
            inList.Add(2);
            Count = inList.Count;
            Debug.Assert(Count == 1);
        }

        public static void TestAdd(MyList<int> Inlist) {
            Inlist.Add(3);
            Debug.Assert(Inlist[0] == 3);
            Inlist.Add(4);
            Debug.Assert(Inlist[1] == 4);
            Inlist.Add(-323875);
            Debug.Assert(Inlist[2] == -323875);
        }

        public static void TestClear(MyList<int> Inlist) {
            Inlist.Add(1);
            Inlist.Add(2);
            Inlist.Add(3);
            Inlist.Clear();
            Debug.Assert(Inlist.numItems == 0);
        }

        public static void TestContains(MyList<int> Inlist) {
            Inlist.Add(3);
            Inlist.Add(4);
            Inlist.Add(17);
            Debug.Assert(Inlist.Contains(3));
            Debug.Assert(Inlist.Contains(4));
            Debug.Assert(Inlist.Contains(17));
        }

        public static void TestCopyTo(MyList<int> Inlist) {
            int[] list2 = new int[] { 1, 2, 0, 0, 0 };
            Inlist.Add(3);
            Inlist.Add(4);
            Inlist.Add(5);
            Inlist.CopyTo(list2, 2);
            for (int i = 0; i < Inlist.numItems; i++) {
                Debug.Assert(Inlist[i] == list2[i + 2]);
            }
        }

        public static void TestIndexOf(MyList<int> Inlist) { }

        public static void TestInsert(MyList<int> Inlist) { }

        public static void TestRemove(MyList<int> Inlist) { }

        public static void TestRemoveAt(MyList<int> Inlist) { }


        
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
            //ints = new int[] { 1, 6, 4, 3, 4, 6, 2, 2, 3, 4, 6, 2, 5, 5, 23465, 2, 46, 2, 34, 6, 2, 34, 6, 2, 4, 62, 5, 62, 456, 3, 45, 63, 45, 6, 3, 45, 61, 451, 13, 3456, 734, 576, 37, 4576, 345, 621, 243, 6, 245, 63, 345, 6, 4, 3, 56, 3, 345, 673, 3457, 345, 3456, 34, 4356, 34, 56, 38, 658, 67, 5, 562, 1, 1458, 2, 15, 78, 82, 1, 43, 678, 113, 346, 7 };
            //RunSorter(ints, sorter);
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
