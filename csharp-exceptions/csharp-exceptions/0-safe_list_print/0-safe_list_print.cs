using System;
using System.Collections.Generic;

public class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int printedCount = 0;

        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                printedCount++;
            }
        }
        catch (Exception)
        {
            // Do nothing, since we just want to catch the exception and continue.
        }

        return printedCount;
    }
}
