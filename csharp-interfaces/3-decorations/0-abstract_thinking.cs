Using System;

/// <summary>
/// This is an abstract class called Base
/// </summary>
public abstract class Base
{
    /// <summary>
    /// This is a public string 
    /// This also acts as a getter setter for Name
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// This method overrides a string 
    /// </summary>
    public override string ToString()
    {
        return string.Format("{0} is a {1}", name, this.GetType().ToString());
    }

}