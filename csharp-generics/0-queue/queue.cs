using System;

/// <summary>
/// This is a public class called QueueT 
/// </summary>
public class Queue<T>
{

    /// <summary> 
    /// This method returns a given Queue's type 
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

}