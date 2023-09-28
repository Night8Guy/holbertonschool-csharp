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
        /// This is the value of the Node
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// This is the next Node in the Queue
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// This ia constructor that sets the value of the Node
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
    /// This is the tail Node of the Queue
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
    /// This method queues a new Node
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
    /// This method dequeues the first queued Node
    /// This method returns the value of the dequeued Node
    /// </summary>
    public T Dequeue()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty.");
            return default(T);
        }

        T value = Head.Value;
        Head = Head.Next;

        if (Head == null)
        {
            Tail = null;
        }

        count--;

        return value;
    }

    /// <summary>
    /// This method returns the value of the head Node without dequeueing it
    /// </summary>
    public T Peek()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return Head.Value;
    }

    /// <summary>
    /// This method prints the Queue, head to tail
    /// </summary>
    public void Print()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }

    /// <summary>
    /// This method returns the count of Nodes queued
    /// </summary>
    public int Count()
    {
        return count;
    }
}