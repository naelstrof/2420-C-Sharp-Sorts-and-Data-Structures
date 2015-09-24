using System;

namespace SortsAndDataStructures {
	static public class SorterTools {
		static public void swap( int[] ints, int index1, int index2){
			if ( index1 == index2 ) {
				return;
			}
	        ints[index1] ^= ints[index2];
	        ints[index2] ^= ints[index1];
	        ints[index1] ^= ints[index2];
	    }
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