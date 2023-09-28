using System;
using System.Collections.Generic;

/// <summary>
/// This is a class called RoomObjects
/// </summary>
public class RoomObjects
{
    enum myType
    {
        Interactive,
        Breakable,
        Collectable
    }

    /// <summary>
    /// This method iterates through all objects and executes methods
    /// </summary>
    /// <param name="roomObjects"> roomObjects </param>
    /// <param name="type"> type </param>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach(Base obj in roomObjects)
        {
            if (type.IsInstanceOfType(obj))
                if (type == typeof(IInteractive))
                    ((IInteractive)obj).Interact();
                else if (type == typeof(IBreakable))
                    ((IBreakable)obj).Break();
                else if (type == typeof(ICollectable))
                    ((ICollectable)obj).Collect();
        }

    }

}