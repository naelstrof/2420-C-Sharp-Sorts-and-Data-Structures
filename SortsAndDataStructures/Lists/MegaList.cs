using System;

namespace SortsAndDataStructures {
	public class MegaList<Type> : IList<Type> {

		public void Clear ()
		{
			throw new NotImplementedException ();
		}

		public bool Contains (Type item)
		{
			throw new NotImplementedException ();
		}

		public void CopyTo (Type[] array, int arrayIndex)
		{
			throw new NotImplementedException ();
		}

		public bool Remove (Type item)
		{
			throw new NotImplementedException ();
		}

		public System.Collections.Generic.IEnumerator<Type> GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
		{
			throw new NotImplementedException ();
		}

		public int Count {
			get {
				throw new NotImplementedException ();
			}
		}

		public bool IsReadOnly {
			get {
				throw new NotImplementedException ();
			}
		}
		Type[] array = new Type[32];
		int length = 0;
		public Type this [int index] {
			get {
				if (index >= length || index < 0) {
					throw new ArgumentException();
				}
				return array [index];
			}
			set {
				if (index >= length || index < 0) {
					throw new ArgumentException();
				}
				array [index] = value;
			}
		}
		public void Add (Type value) {
			length++;
			ResizeIfNecessary ();
			array [length] = value;
		}
		private void ResizeIfNecessary () {
			if (length <= array.Length) {
				return;
			}
			Type[] newArray;
			// Create new array.
			newArray = new Type[this.length * 2];
			// Copy contents over.
			for (int i = 0; i < length; i++) {
				newArray [i] = array [i];
			}
			// Replace old array
			array = newArray;
			// GC will get old array for us.
		}
		public int IndexOf (Type value) {
			for (int i=0;i<length;i++) {
				if ( array[i] == value ) {
					return i;
				}
			}
			return -1;
		}
		public void RemoveAt( int index ) {
			if (index >= length || index < 0) {
				throw ArgumentException;
			}
			// Shift left
			for (int i = index + 1; i < length; i++) {
				array [i - 1] = array [i];
			}
			// Reduce length
			length--;
		}
		public void Insert( int index, Type value ) {
			this.length = Math.Max (index+1, this.length+1);
			ResizeIfNecessary ();
			// Shift right
			for (int i = index; i < length; i++) {
				array [i+1] = array [i];
			}
			array [index] = value;
		}
	}
}

