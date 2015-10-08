using System;

namespace SortsAndDataStructures {
    //Performs an Insertion sort.
    public class InsertionSorter : ISorter {
        public void sort(int[] ints) {
            for (int i = 1; i < ints.Length; i++) {
                int positionIndex = i;
                while (positionIndex > 0 && (ints[positionIndex] < ints[positionIndex - 1])) {
                    SorterTools.swap(ints, positionIndex - 1, positionIndex);
                    positionIndex--;
                }
            }
        }
    }
}