using System.Collections.Generic;
using System.Collections;

namespace SortsAndDataStructures {
    class MyList<T> : IList<T> {
        public T[] items = new T[2];
        public int numItems = 0;

        public void ResizeIfNecessary() {
            if (numItems == items.Length) {
                T[] temp = new T[items.Length * 2];
                for (int i = 0; i < items.Length; i++) {
                    temp[i] = items[i];
                }
                items = temp;
            }
        }

        public bool IsReadOnly {
            get {
                return false;
            }
        }

        public int Count {
            get {
                return numItems;
            }
        }

        public void Add(T item) {
            ResizeIfNecessary();
            items[numItems] = item;
            numItems++;
        }

        public void Clear() {
            numItems = 0;
        }

        public bool Contains(T item) {
            for (int i = 0; i < items.Length; i++) { 
                if(items[i].Equals(item)) {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex) {
            for (int i = 0; i < numItems; i++) {
                array[arrayIndex] = items[i];
                arrayIndex++;
            }
        }

        public int IndexOf(T item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new System.NotImplementedException();
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
