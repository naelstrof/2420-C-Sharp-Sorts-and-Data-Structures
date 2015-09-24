class SelectionSorter{
    public void Sort(int[] ints){
        
    }
    public void Swap(int index1, int index2, int[] ints){
        ints[index1] ^= ints[index2];
        ints[index2] ^= ints[index1];
        ints[index1] ^= ints[index2];
    }
    public int findLowestValueIndex(int[] ints, int startRange){
        int lowestIndex = 0;
        for (int i = startRange; i < ints.Length; i++){
            if (ints[i] < ints[lowestIndex]){
                lowestIndex = i;
            }
        }
        return lowestIndex;
    }
}
