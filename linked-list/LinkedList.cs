using System;

/*Deque implements a linked list*/
class Deque<T> where T: System.IComparable {
	Node root;

	/*Deque creats a new empty linked list*/
	public Deque() {
		root = null;
	}

	/*Push adds an items to the front of the list*/
	public void Push(T item) {
		Node node = new Node (item);
		if (root != null) {
			node.next = root;
			node.prev = root.prev;
			root.prev.next = node;
			root.prev = node;
		}
		root = node;
	}

	/*Pop removes an item from the front of the list*/
	public T Pop() {
		Node node = root;
		root.prev.next = root.next;
		root.next.prev = root.prev;
		root = root.next;
		node.next = null;
		node.prev = null;
		return node.value;
	}

	/*Shift removes an item an item to the end of the list*/
	public T Shift() {
		root = root.prev;
		return Pop ();
	}

	/*Unshift adds an item to the end of the list*/
	public void Unshift(T item) {
		Push (item);
		root = root.next;
	}

	/*Node is a container in the linked list*/
	private class Node {
		public T value;
		public Node next;
		public Node prev;

		public Node(T value) {
			this.value = value;
			next = this;
			prev = this;
		}
	}
}