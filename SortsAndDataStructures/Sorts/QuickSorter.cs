using System;

namespace SortsAndDataStructures {
	 public class QuickSorter : ISorter {
		public void sort( int[] ints ) {
			quicksort (ints);
		}
		private int[] quicksort( int[] array, int start = 0, int end = -1 ) {
			if (end == -1) {
				end = array.Length - 1;
			}
			if ( SorterTools.sorted( array, start, end ) ) {
				return array;
			}
			if (end-start == 1) {
				SorterTools.swap(array, start, end);
				return array;
			}
			if (end-start <= 0) {
				return array;
			}
			int pivot = start;
			int left = start+1;
			int right = end;
			while (left <= right) {
				while ( left < array.Length && array[left] < array[pivot] && left <= right) {
					left += 1;
				}
				while ( right >= 0 && array[right] > array[pivot] && left <= right) {
					right -= 1;
				}
				if (left <= right) {
					SorterTools.swap (array, left, right);
				}
			}
			int middle = right;
			SorterTools.swap( array, pivot, middle );
			quicksort( array, start, middle );
			quicksort( array, middle+1, end );
			return array;
		}
	}
}

