using System.Collections.Generic;

namespace CER.GraphReduction
{
	public class Graph<T>
	{
		public Graph()
		{
			_nodes = new List<Node<T>>();
		}

		private IList<Node<T>> _nodes;
	}
}
