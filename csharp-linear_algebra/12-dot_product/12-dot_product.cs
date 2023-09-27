using System;

///<summary>
/// This is a public class called VectorMath
///</summary>
public class VectorMath
{
    ///<summary>
    /// This method calculates the dot product og given vectors
    ///</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length ||
        vector1.Length != 3 && vector1.Length != 2 || 
        vector2.Length != 3 && vector2.Length != 2)
        {
            return (-1);
        }

        double sum = 0;
        for (int i = 0; i < vector1.Length; i++)
        {
           sum += vector1[i] * vector2[i];
        }
        return sum;
    }
}