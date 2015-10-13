using System;

// Big O is n^2. As our invariant moves x elements, the worst amount of comparisons needed is n-x. Simlarly
// the amount of swaps needed is inversely proportional to the comparisons, but its worst case is also n-x.
// This is a very similar formula to selection sort, and to calculate the comparisons AND swaps on a reversed list
// would look something like so: (n+1)(n/3) + n-1. The (n+1)(n/3) accounts for the swaps that have to be done. n-1
// is the comparisons. Ultimately this simplifies down to n^2 because of how Big O works.
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