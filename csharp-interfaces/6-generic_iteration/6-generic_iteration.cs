using System;
using System.Collections;
using System.Collections.Generic;

/// <summary> 
/// This is a public class called Obj
/// </summary>
public class Objs<T> : IEnumerable<T>
{
    List<T> objectList = new List<T>();

    /// <summary> 
    /// This method adds objects to a list
    /// </summary>
    public void Add(T obj)
    {
        this.objectList.Add(obj);
    }

    /// <summary> 
    /// This method gets an enumerator
    /// </summary>
    public IEnumerator<T> GetEnumerator()
    {
        return this.objectList.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}