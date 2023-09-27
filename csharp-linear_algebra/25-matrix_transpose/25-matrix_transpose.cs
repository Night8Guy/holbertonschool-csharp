using System;
using System.Collections;

/// <summary>
/// This is a public class called MatrixMath
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// This method transposes a given matrix
    /// This method returns the resulting matrix
    /// </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        if (matrix.Length == 0)
        {
            return new double[,] {};
        }

        double[,] transposeMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                transposeMatrix[column, row] = Math.Round(matrix[row, column], 2);
            }
        }
        return transposeMatrix;
    }
}