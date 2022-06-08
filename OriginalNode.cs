using System.Collections.Generic;

namespace CER.GraphReduction
{
	public class OriginalNode<T> : Node<T>
	{
		public OriginalNode() { }

		public OriginalNode(T data)
		{
			Data = data;
		}

		public T Data
		{
			get;
			set;
		}

		public ReducedNode<T> Reduction
		{
			get;
			internal set;
		}

		public IList<Node<T>> NeighborsList
		{
			get;
		}
	}
}
