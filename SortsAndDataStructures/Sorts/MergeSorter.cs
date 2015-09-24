using System;
namespace SortsAndDataStructures {
    static public class MergeSorter {
        static public int[] sort(int[] ints, int left, int right) {
            if (left < right) {
                int middle = (left + right) / 2;

                MergeSorter.sort(ints, left, middle);
                MergeSorter.sort(ints, middle + 1, right);

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
            return ints;
        }
    }
}
