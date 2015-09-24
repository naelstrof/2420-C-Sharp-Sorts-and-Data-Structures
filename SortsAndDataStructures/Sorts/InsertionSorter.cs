using System;

namespace SortsAndDataStructures {
    static public class InsertionSorter {
        static public int[] sort(int[] ints) {
            for (int i = 1; i < ints.Length; i++) {
                int positionIndex = i;
                while (positionIndex > 0 && (ints[positionIndex] < ints[positionIndex - 1])) {
                    SorterTools.swap(ints, positionIndex - 1, positionIndex);
                    positionIndex--;
                }
            }
            return ints;
        }
    }
}