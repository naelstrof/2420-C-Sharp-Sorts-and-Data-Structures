using System;
namespace SortsAndDataStructures {
	class MainClass {
		public static void Main (string[] args) {
			int[] ints = new int[]{ 5, 22, 7, 84, -2 };
			SelectionSorter.sort( ints );
			ints = new int[]{ 5, 22, 7, 84, -2 };
			BubbleSorter.sort (ints);
			Console.WriteLine( ints );
		}
	}
}
