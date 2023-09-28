using System;

/// <summary>
/// This is a public class called Door
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// This is the name of the door
    /// </summary>
    /// <param name="name"> Door </param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// this Method interacts with a Door
    /// </summary>
    public void Interact()
    {
        Console.WriteLine( $"You try to open the {this.name}. It's locked." );
    }
}