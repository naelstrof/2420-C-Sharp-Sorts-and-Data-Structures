using System;
using System.Collections.Generic;

namespace SortsAndDataStructures {
	public interface IList<Type> : ICollection<Type>, IEnumerable<Type> {
		Type this[int index] { get; set; }
		void ResizeIfNecessary ();
		int IndexOf (Type value);
		void RemoveAt( int index );
		void Insert( int index, Type value );
    }
}


