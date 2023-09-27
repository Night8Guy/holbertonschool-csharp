using System;

///<summary>
/// This is a public class called VectorMath
///</summary>
public class VectorMath
{
    ///<summary>
    /// This method multiplies a given vector and scalar
    ///</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length != 3 && vector.Length != 2)
        {
            return(new Double[1]{-1});
        }

        double[] sum = new double[vector.Length];
        for (int x = 0; x < vector.Length; x++)
        {
            sum[x] = vector[x] * scalar;
        }
        return sum;
    }
}