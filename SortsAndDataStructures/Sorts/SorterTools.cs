using System;

namespace SortsAndDataStructures {
    //Various tools that are used across multiple sorts.
	static public class SorterTools {
        //Swaps two values in an array.
		static public void swap( int[] ints, int index1, int index2){
			if ( index1 == index2 ) {
				return;
			}
	        ints[index1] ^= ints[index2];
	        ints[index2] ^= ints[index1];
	        ints[index1] ^= ints[index2];
	    }
        //Checks if a given array is already sorted. (Used in Quicksort)
		static public bool sorted( int[] ints, int start = 0, int end = -1 ) {
			if ( end == -1 ) {
				end = ints.Length - 1;
			}
			if ( end - start <= 0 ) {
				return true;
			}
			for ( int i = start; i < end; i++ ) {
				if ( ints[i] >= ints[i+1] ) {
					return false;
				}
			}
			return true;
		}
        //CHecks through a given array to find the smallest integer.
		static public int findLowestValueIndex(int[] ints, int startRange, int endRange = -1){
			if (endRange == -1) {
				endRange = ints.Length;
			}
	        int lowestIndex = startRange;
	        for (int i = startRange; i < endRange; i++){
	            if (ints[i] < ints[lowestIndex]){
	                lowestIndex = i;
	            }
	        }
	        return lowestIndex;
		}
	}
} 