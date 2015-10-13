using System;

// Big O for MergeSorter is O(n^2*lg(n)). This merge sort is recursive, thus, giving lg(n) steps to the problem, for
// each step of the problem it copies the entire array (n), then sorts them (n). Giving us the final equation
// n^2*lg(n), in reality though it shouldn't be copying the entire array. Which would give a normal merge sort
// a growth rate of O(n*lg(n)).
namespace SortsAndDataStructures {
    //Performs a Merge sort.
    public class MergeSorter : ISorter {
        public void sort(int[] ints) {
            merge(ints, 0, ints.Length - 1);
        }
        public void merge(int[] ints, int left, int right) {
            if (left < right) {
                int middle = (left + right) / 2;

                merge(ints, left, middle);
                merge(ints, middle + 1, right);

                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(ints, left, leftArray, 0, middle - left + 1);
                Array.Copy(ints, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++) {
                    if (i == leftArray.Length) {
                        ints[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length) {
                        ints[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] < rightArray[j]) {
                        ints[k] = leftArray[i];
                        i++;
                    }
                    else if (rightArray[j] <= leftArray[i]) {
                        ints[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }
    }
}
