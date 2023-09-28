using System;

/// <summary>
/// This is a public class called Queue
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// This is a public class called Node
    /// </summary>
    public class Node
    {
        /// <summary>
        /// This sets the value of the Node
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// The next Node in the Queue
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// This is a constructor that sets the value of the Node
        /// </summary>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// This is the head Node of the Queue
    /// </summary>
    public Node Head { get; private set; }

    /// <summary>
    /// this is the tail Node of the Queue
    /// </summary>
    public Node Tail { get; private set; }

    private int count;

    /// <summary>
    /// This is a constructor that initializes the Queue
    /// </summary>
    public Queue()
    {
        Head = null;
        Tail = null;
        count = 0;
    }

    /// <summary>
    /// This method adds a new Node to the Queue
    /// </summary>
    public void Enqueue(T value)
    {
        Node node = new Node(value);

        if (Head == null)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            Tail.Next = node;
            Tail = node;
        }

        count++;
    }

    /// <summary>
    /// This method returns the number of nodes queued
    /// </summary>
    public int Count()
    {
        return count;
    }
}