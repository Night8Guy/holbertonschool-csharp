using System;

/// <summary>
/// This is a public interface called IInteractive
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// This is method interacts with an object
    /// </summary>
    void Interact();

}

/// <summary>
/// This is a public interface called IBreakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// This represents the durability of an object
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// This method breaks an object
    /// </summary>
    void Break();

}

/// <summary>
/// This is a public interface called ICollectable 
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// This tells us if an object has been collected
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// This method collects an object
    /// </summary>
    void Collect();

}