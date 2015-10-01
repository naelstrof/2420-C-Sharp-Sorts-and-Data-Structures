using System;

namespace SortsAndDataStructures {
	public class SelectionSorter : ISorter {
        public void sort(int[] ints) {
            for (int i = 0; i < ints.Length; i++) {
                int leastIndex = SorterTools.findLowestValueIndex(ints, i);
                SorterTools.swap(ints, i, leastIndex);
            }
        }
	}
} 