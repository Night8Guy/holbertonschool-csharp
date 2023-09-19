using System;
using System.Collections.Generic;

public class MyStack
{
    //is it comments thats making this thing angy??
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        //print count
        Console.WriteLine("Number of items: " + aStack.Count);

    
        //prints whether or not the stack is empy
        if (aStack.Count > 0)
            Console.WriteLine("Top item: " + aStack.Peek());
        else
            Console.WriteLine("Stack is empty");
    

        //print if exsist
        bool containsSearch = aStack.Contains(search);
            Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);

        //pop, lock, and drop it
        if (containsSearch)
        {
            while (aStack.Pop() != search)
                continue;
        }
        //ah ssss push it
        aStack.Push(newItem);
        return aStack;
    }
}using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        Stack<string> aStack = new Stack<string>();

        aStack.Push("C");
        aStack.Push("HTML");
        aStack.Push("Javascript");
        aStack.Push("Python");
        aStack.Push("React");
        aStack.Push("Ruby");

        foreach (string item in aStack)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyStack.Info(aStack, "C#", "Javascript");

        Console.WriteLine("------");

        foreach (string item in aStack)
            Console.WriteLine(item);
    }
}