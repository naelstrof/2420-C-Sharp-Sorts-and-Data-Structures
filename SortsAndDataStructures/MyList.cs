using System.Collections.Generic;
using System.Collections;

namespace SortsAndDataStructures {
    //Class to build and manipulate arrays.
    class MyList<T> : IList<T> {
        public T[] items = new T[2];
        public int numItems = 0;

        //Doubles the size of the array if needed.
        public void ResizeIfNecessary() {
            if (numItems == items.Length) {
                T[] temp = new T[items.Length * 2];
                for (int i = 0; i < items.Length; i++) {
                    temp[i] = items[i];
                }
                items = temp;
            }
        }

        //Keeps array maleable.
        public bool IsReadOnly {
            get {
                return false;
            }
        }

        //Counts the amount of indicies with values in them.
        public int Count {
            get {
                return numItems;
            }
        }

        //Adds a value onto the end of an array.
        public void Add(T item) {
            ResizeIfNecessary();
            items[numItems] = item;
            numItems++;
        }

        //Gets rid of all the values in an array.
        public void Clear() {
            numItems = 0;
        }

        //Checks in an array contains a given item.
        public bool Contains(T item) {
            for (int i = 0; i < items.Length; i++) { 
                if(items[i].Equals(item)) {
                    return true;
                }
            }
            return false;
        }

        //Copies base array onto another given array.
        public void CopyTo(T[] array, int arrayIndex) {
            for (int i = 0; i < numItems; i++) {
                array[arrayIndex] = items[i];
                arrayIndex++;
            }
        }

        //Finds the index of an item in the list.
        public int IndexOf(T item) {
            for (int i = 0; i < items.Length; i++) {
                if (items[i].Equals(item)) {
                    return i;
                }
            }
            return -1;
        }

        //Inserts an item into the array at the given index.
        public void Insert(int index, T item) {
            ResizeIfNecessary();
            for (int workIndex = numItems; workIndex > index; workIndex--) {
                items[workIndex] = items[workIndex - 1];
            }
            items[index] = item;
            numItems++;
        }

        public bool Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
