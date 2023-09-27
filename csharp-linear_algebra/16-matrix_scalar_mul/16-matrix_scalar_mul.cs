using System;

///<summary>
/// This is a public class clalled MatrixMath
///</summary>
public class MatrixMath
{
    ///<summary>
    /// This method multiplies a given maxtrix and scalar
    ///</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) > 3 || matrix.GetLength(0) < 2)
            return new double[,] { {-1} };
        if (matrix.GetLength(1) > 3 || matrix.GetLength(1) < 2)
            return new double[,] { {-1} };
        
        double[,] sum = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum[i, j] = matrix[i, j] * scalar;
            }
        }
        return sum;
    }
}