using System.Collections.Generic;
using System.Globalization;

namespace CER.GraphReduction
{
	public abstract class Node<T>
	{
		private static readonly object _identifierLock = new object();
		private static ulong _identifier = 0;

		protected Node()
		{
			lock (_identifierLock)
			{
				_identifier += 1;
				Identifier = _identifier.ToString(CultureInfo.InvariantCulture);
			}
			NeighborsInternal = new List<Node<T>>();
		}

		internal IList<Node<T>> NeighborsInternal
		{
			get;
		}

		internal string Identifier
		{
			get;
		}

		public IEnumerable<Node<T>> Neighbors => NeighborsInternal;
	}
}
