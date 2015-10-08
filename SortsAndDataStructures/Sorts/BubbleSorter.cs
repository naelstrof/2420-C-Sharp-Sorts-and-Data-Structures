using System;

namespace SortsAndDataStructures {
    //Performs a Bubble sort.
	public class BubbleSorter : ISorter {
		public void sort( int[] ints ) {
			bool unsorted = true;
			while (unsorted) {
				unsorted = false;
				for (int i = 0; i < ints.Length - 1; i++) {
					if (ints [i] > ints [i + 1]) {
						SorterTools.swap(ints, i, i + 1);
						unsorted = true;
					}
				}
			}
		}
	}
}

