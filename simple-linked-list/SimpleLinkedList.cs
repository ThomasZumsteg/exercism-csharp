using System.Collections.Generic;
using System.Linq;

public class SimpleLinkedList<T> : IEnumerable<T>
{
	public SimpleLinkedList<T> Next { get; private set; } = null;
	public T Value { get; private set; }

	public SimpleLinkedList(T value)
	{
		Value = value;
	}

	public SimpleLinkedList(IEnumerable<T> values)
	{
		Value = values.First();
		foreach (var value in values.Skip(1))
		{
			Add(value);
		}
	}

	public SimpleLinkedList<T> Add(T value)
	{
		Next = Next?.Add(value) ?? new SimpleLinkedList<T>(value);
		return this;
	}

	public SimpleLinkedList<T> Reverse()
	{
		SimpleLinkedList<T> prev = null;
		SimpleLinkedList<T> curr = this;
		for (SimpleLinkedList<T> next = curr.Next; next != null; next = next.Next)
		{
			curr.Next = prev;
			curr = next;
		}
		return curr;
	}

	public IEnumerable<T> GetEnumerator()
	{
		List<T> items = new List<T>();
		for (SimpleLinkedList<T> node = this; node.Next != null; node = node.Next)
		{
			items.Add(node.Value);
		}
		return items.GetEnumerator();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}