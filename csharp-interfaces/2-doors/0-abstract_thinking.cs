using System;

/// <summary>
/// This is an abstract class called Base
/// </summary>
public abstract class Base
{
    /// <summary>
    /// This is a public string 
    /// </summary>
    public string name;

    /// <summary>
    /// This method converts the value of this instance to a string
    /// </summary>
    public override string ToString()
    {
        return string.Format("{0} is a {1}", name, this.GetType().ToString());
    }
}