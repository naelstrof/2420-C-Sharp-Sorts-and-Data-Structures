using System.Collections.Generic;
using System.Collections;

namespace SortsAndDataStructures {
	public class MyListEnum<T> : IEnumerator<T> {
		public int current = -1;
		public MyList<T> list;

		public MyListEnum( MyList<T> list ) {
			this.list = list;
		}

		public bool MoveNext () {
			current++;
			return current < list.numItems;
		}

		object IEnumerator.Current {
			get {
				return this.Current;
			}
		}

		public T Current {
			get {
				return list.items[current];
			}
		}

		public void Reset () {
			current =  -1;
		}

		public void Dispose () {
		}
	}
    //Class to build and manipulate arrays.
    public class MyList<T> : IList<T> {
        public T[] items = new T[2];
        public int numItems = 0;

		public IEnumerable<T> All() {
			for (int i=0;i<this.numItems;i++ ) {
				yield return this[i];
			}
		}
        //Doubles the size of the array if needed.
        public void ResizeIfNecessary() {
            while (numItems >= items.Length) {
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
            for (int i = 0; i < numItems; i++) { 
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
            for (int i = 0; i < numItems; i++) {
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

        //Removes the first instance of a value.
        public bool Remove(T item) {
            for (int index = 0; index < numItems; index++) {
                if (items[index].Equals(item)) {
                    for (int workIndex = index; workIndex < numItems - 1; workIndex++) {
                        items[workIndex] = items[workIndex + 1];
                    }
                    numItems--;
                    return true;
                }
            }
            return false;
        }

        //Removes the value at given index.
        public void RemoveAt(int index) {
            if (index < numItems) {
                for (int workingIndex = index; workingIndex < numItems - 1; workingIndex++) {
                    items[workingIndex] = items[workingIndex + 1];
                }
                numItems--;
            }
        }

        public T this[int index] {
            get {
                if (index >= 0 && index < numItems)
                {
                    return items[index];
                }
                else {
                    throw new System.IndexOutOfRangeException();
                }
            }
            set {
                if (index > 0 && index < numItems)
                {
                    items[index] = value;
                }
                else {
                    throw new System.IndexOutOfRangeException();
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
			return this.GetEnumerator ();
        }

        public IEnumerator<T> GetEnumerator()
        {
			// For yield version:
			// return this.All()
			return new MyListEnum<T> (this);
        }
    }
}
