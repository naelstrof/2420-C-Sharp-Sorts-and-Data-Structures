using System;
using System.Diagnostics;

namespace SortsAndDataStructures {
    class MainClass {
		public static void a( string action ) {
			Console.Write ("Testing " + action + "...");
		}
		public static void b() {
			Console.WriteLine ("It works!");
		}
        public static void Main(string[] args) {
			Console.WriteLine (" --------- MyList Assertions ----------");
			TestMyList ();
			Console.WriteLine (" --------- Sorter Assertions ----------");
			TestAllSorts();
			Console.WriteLine (" ----------- Sorter Timings -----------");
			TimeSort ("BubbleSorter", new BubbleSorter ());
			TimeSort ("InsertionSorter", new InsertionSorter());
			TimeSort ("MergeSorter", new MergeSorter());
			TimeSort ("QuickSorter", new QuickSorter());
			TimeSort ("SelectionSorter", new SelectionSorter());
			Console.WriteLine (" ----------- MyList Timings -----------");
			TimeFunction ("TestCount", TestCount );
			TimeFunction ("TestAdd", TestAdd );
			TimeFunction ( "TestClear", TestClear );
			TimeFunction ( "TestContains", TestContains );
			TimeFunction ( "TestCopyTo", TestCopyTo );
			TimeFunction ( "TestIndexOf", TestIndexOf );
			TimeFunction ( "TestInsert", TestInsert );
			TimeFunction ( "TestRemove", TestRemove );
			TimeFunction ("TestRemoveAt", TestRemoveAt);

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
			a ("Mylist.count()");
            TestCount(new MyList<int>());
			b ();
			a ("MyList.add(3)");
            TestAdd(new MyList<int>());
			b ();
			a ("MyList.clear()");
            TestClear(new MyList<int>());
			b ();
			a ("MyList.contains(3)");
            TestContains(new MyList<int>());
			b ();
			a ("MyList.copyTo( list2, 2 )");
            TestCopyTo(new MyList<int>());
			b ();
			a ("MyList.indexOf( 3 )");
            TestIndexOf(new MyList<int>());
			b ();
			a ("MyList.insert(3,5)");
            TestInsert(new MyList<int>());
			b ();
			a ("MyList.remove(3)");
            TestRemove(new MyList<int>());
			b ();
			a ("MyList.removeAt(3)");
            TestRemoveAt(new MyList<int>());
			b ();
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

        public static void TestIndexOf(MyList<int> Inlist) {
            Inlist.Add(3);
            Inlist.Add(4);
            Inlist.Add(5);
            Debug.Assert(Inlist.IndexOf(3) == 0);
            Debug.Assert(Inlist.IndexOf(4) == 1);
            Debug.Assert(Inlist.IndexOf(5) == 2);
        }

        public static void TestInsert(MyList<int> Inlist) {
            Inlist.Add(0);
            Inlist.Add(1);
            Inlist.Add(2);
            Inlist.Add(3);
            Inlist.Add(4);
            Inlist.Insert(3, 5);
            Debug.Assert(Inlist[3] == 5);
        }

        public static void TestRemove(MyList<int> Inlist) {
            Inlist.Add(0);
            Inlist.Add(1);
            Inlist.Add(2);
            Inlist.Add(3);
            Inlist.Add(4);
            Inlist.Remove(2);
            Debug.Assert(Inlist[2] != 2);
        }

        public static void TestRemoveAt(MyList<int> Inlist) {
            Inlist.Add(1);
            Inlist.Add(2);
            Inlist.Add(3);
            Inlist.Add(4);
            Inlist.Add(5);
            Inlist.RemoveAt(3);
            Debug.Assert(Inlist[3] == 5);
        }


        
        //Runs all the different kinds of sorts.
        public static void TestAllSorts() {
            TestSorter(new BubbleSorter(), "BubbleSorter");
            TestSorter(new InsertionSorter(), "InsertionSorter");
            TestSorter(new MergeSorter(), "MergeSorter");
            TestSorter(new QuickSorter(), "QuickSorter");
            TestSorter(new SelectionSorter(), "SelectionSorter");
        }

        static void TestSorter(ISorter sorter, string name) {
			a (name);
            int[] ints = new int[] { 5, 22, 7, 84, -2 };
            RunSorter(ints, sorter, name);
            
        }

        static void RunSorter(int[] ints, ISorter sorter, string name) {
            sorter.sort(ints);
            AssertIfSorted(ints, name);
        }

        public static void AssertIfSorted(int[] ints, string name) {
            for (int i = 0; i < ints.Length - 1; i++) {
                Debug.Assert(ints[i] <= ints[i + 1]);
            }
			b ();
        }
	}
}
