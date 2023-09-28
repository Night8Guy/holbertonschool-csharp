using System;

/// <summary>
/// This is a class called Decoration
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// This tells us if an object is a quest item
    /// </summary>
    public bool isQuestItem = false;
    /// <summary>
    /// This tells us the durability of an object
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// This is an instance of a Decoration
    /// </summary>
    /// <param name="name"> name </param>
    /// <param name="durability"> durability </param>
    /// <param name="isQuestItem"> isQuestItem </param>
    /// <exception cref="Exception"> Exception </exception>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// This method interacts with an object
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken.");
        }
        else if (isQuestItem)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

/// <summary>
/// This method breaks an object
/// </summary>
    public void Break()
    {
        durability--;
        if (durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
        else if (durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }

    }

}