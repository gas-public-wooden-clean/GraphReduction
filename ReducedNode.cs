using System;
using System.Collections.Generic;
using System.IO;

namespace CER.GraphReduction
{
	public class ReducedNode<T> : Node<T>
	{
		internal ReducedNode()
		{
			_contents = new List<Node<T>>();
		}

		private IList<Node<T>> _contents;

		public IEnumerable<Node<T>> Contents => _contents;

		public void ToGraphViz(TextWriter stream)
		{
			if (stream is null)
			{
				throw new ArgumentNullException(nameof(stream));
			}

			stream.WriteLine("graph {0}", Identifier);
			stream.WriteLine("{");
			stream.WriteLine("\toverlap=false;");

			stream.WriteLine();

			foreach (Node<T> node in _contents)
			{
				stream.WriteLine("\t{0};", node.Identifier);
			}

			stream.WriteLine("}");
		}
	}
}
