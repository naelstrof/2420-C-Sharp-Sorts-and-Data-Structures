using System;

namespace SortsAndDataStructures {
	static public class SelectionSorter {
        static public int[] sort(int[] ints) {
            for (int i = 0; i < ints.Length; i++) {
                int leastIndex = SorterTools.findLowestValueIndex(ints, i);
                SorterTools.swap(ints, i, leastIndex);
            }
            return ints;
        }
	}
} 