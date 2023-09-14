using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            int result = 0;

            try
            {
                result = list1[i] / list2[i];
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            finally
            {
                resultList.Add(result);
            }
        }

        return resultList;
    }
}
