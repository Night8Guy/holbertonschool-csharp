using System;

/// <summary>
/// This is a class called VectorMath
/// </summary>
public class VectorMath
{
    /// <summary>
    /// This method calculates the Magnitude of a given vector
    /// This method returns Magnitude
    /// </summary>
    public static double Magnitude(double[] vector)
    {
        if ( vector.Length > 3 || vector.Length < 2)
            return -1;

        double sum = 0;
        foreach (double i in vector)
            sum += i * i;
        return Math.Round(Math.Sqrt(sum), 2);
    }
}