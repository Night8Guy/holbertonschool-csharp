using System;

/// <summary>
/// This is a public class called TestObject
/// This inherits form Base and uses interfaces IInteractive, IBreakable, and ICollectable
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
     /// <summary> 
     /// This represents an objects durability 
     /// </summary>
    public int durability { get; set; }

    /// <summary> 
    /// This tells us if an object has been collected
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary> 
    /// This method interacts with an object
    /// </summary>
    public void Interact()
    {}

    /// <summary> 
    /// This method breaks an object
    /// </summary>
    public void Break()
    {}

    /// <summary> 
    /// This method collects an object
    /// </summary>
    public void Collect()
    {}

}