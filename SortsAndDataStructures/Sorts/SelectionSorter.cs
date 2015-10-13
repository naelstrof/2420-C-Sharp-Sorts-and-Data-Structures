using System;

// Big O is On^2, reason being is that for the worst case we'll have to traverse the entire
// array (n+1)(n/2) times. Each iteration of the function has to do n-x comparisons. Where x
// is the currently sorted section of the array. X increases by one every iteration until
// it is 0. (n-1) + (n-2) + (n-3)... is the amount of comparisons we have to do.
// That formula is equal to (n+1)(n/2). Which can be written as n^2/2 + n/2, which simplifies
// into n^2 for Big O's sake.
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