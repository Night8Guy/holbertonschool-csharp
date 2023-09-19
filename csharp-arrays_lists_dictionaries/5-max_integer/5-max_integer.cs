using System;
using System.Collections.Generic;

public class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return (-1);
        }

        int max = myList[0];
        
	foreach (var element in myList)
	{
		if (element > max)
		{
			max = element;
		}
	}
	return (max);
    }
}