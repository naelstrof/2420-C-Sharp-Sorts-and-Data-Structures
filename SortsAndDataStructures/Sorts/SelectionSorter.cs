static class SelectionSorter{
	static public int[] sort(int[] ints){
		for ( int i=0;i<ints.Length;i++ ) {
			int leastIndex = SelectionSorter.findLowestValueIndex(ints, i);
			SelectionSorter.swap(ints, i, leastIndex);
		}
		return ints;
    }
    static public void swap( int[] ints, int index1, int index2){
		if ( index1 == index2 ) {
			return;
		}
        ints[index1] ^= ints[index2];
        ints[index2] ^= ints[index1];
        ints[index1] ^= ints[index2];
    }
    static public int findLowestValueIndex(int[] ints, int startRange){
        int lowestIndex = startRange;
        for (int i = startRange; i < ints.Length; i++){
            if (ints[i] < ints[lowestIndex]){
                lowestIndex = i;
            }
        }
        return lowestIndex;
    }
}
