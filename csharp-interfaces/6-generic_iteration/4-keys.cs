using System;

/// <summary>
/// This is a public class called Key
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// This tells us if an item has been collected
    /// </summary>
    public bool isCollected { get; set; }

    /// <summary>
    /// This is an instance of a key
    /// </summary>
    /// <param name="name"> name </param>
    /// <param name="isCollected"> isCollected </param>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// This method collects an item
    /// </summary>
    public void Collect()
    {
        if (this.isCollected == false)
        {
            this.isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }

    }

}