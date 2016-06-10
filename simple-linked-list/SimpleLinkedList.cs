using System.Collections.Generic;
using System.Linq;

/*SimpleLinedList creates a dynamics list of values*/
public class SimpleLinkedList<T> : IEnumerable<T>
{
	public SimpleLinkedList<T> Next { get; private set; } = null;
	public T Value { get; private set; }

	/*SimpleLinkedList creates a new one element list*/
	public SimpleLinkedList(T value)
	{
		Value = value;
	}

	/*SimpleLinkedList creates a new list with multiple elements*/
	public SimpleLinkedList(IEnumerable<T> values)
	{
		Value = values.First();
		foreach (var value in values.Skip(1))
		{
			Add(value);
		}
	}

	/*Add appends an element to the list*/
	public SimpleLinkedList<T> Add(T value)
	{
		Next = Next?.Add(value) ?? new SimpleLinkedList<T>(value);
		return this;
	}

	/*Reverse creates a new list with the elements in reverse order*/
	public SimpleLinkedList<T> Reverse()
	{
		SimpleLinkedList<T> root = null;
		foreach (var value in this)
		{
			SimpleLinkedList<T> next = new SimpleLinkedList<T>(value);
			next.Next = root;
			root = next;
		}
		return root;
	}

	/*GetEnumerator makes the list enumerable*/
	public IEnumerator<T> GetEnumerator()
	{
		for (var node = this; node != null; node = node.Next)
		{
			yield return node.Value;
		}
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

}