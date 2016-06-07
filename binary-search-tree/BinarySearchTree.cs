using System;
using System.Collections.Generic;

public class BinarySearchTree {
	public int Value;
	public BinarySearchTree Left;
	public BinarySearchTree Right;

	/*BinarySearchTree creates a node in a binary search tree*/
	public BinarySearchTree(int value) {
		this.Value = value;
	}

	/*BinarySearchTree creats a binary search tree from a number of values*/
	public BinarySearchTree(int[] values) {
		Value = values [0];
		for (int i = 1; i < values.Length; i++)
			this.Add (values [i]);
	}

	/*Add inserts a node into a binary search tree*/
	public BinarySearchTree Add(int value) {
		if (value <= Value) {
			if (Left != null)
				Left.Add (value);
			else
				Left = new BinarySearchTree (value);
		} else {
			if (Right != null)
				Right.Add (value);
			else
				Right = new BinarySearchTree (value);
		}
		return this;
	}

	/*AsEnumerable gets the values in the binary search tree*/
	public IEnumerable<int> AsEnumerable() {
		if(Left != null) {
			foreach(var value in Left.AsEnumerable())
				yield return value;
		}
		yield return Value;
		if (Right != null) {
			foreach (var value in Right.AsEnumerable())
				yield return value;
		}
	}
}