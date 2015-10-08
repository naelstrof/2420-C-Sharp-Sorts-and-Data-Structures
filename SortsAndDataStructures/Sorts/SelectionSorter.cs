using System;

namespace SortsAndDataStructures {
    //Performs a Selection sort.
	public class SelectionSorter : ISorter {
        public void sort(int[] ints) {
            for (int i = 0; i < ints.Length; i++) {
                int leastIndex = SorterTools.findLowestValueIndex(ints, i);
                SorterTools.swap(ints, i, leastIndex);
            }
        }
	}
} 