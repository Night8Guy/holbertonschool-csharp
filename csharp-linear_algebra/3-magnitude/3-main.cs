public static void Main(string[] args)
{
    double[] testVector2D = { 3, 4 };
    double[] testVector3D = { 1, 2, 2 };

    Console.WriteLine($"Magnitude of 2D vector: {VectorMath.Magnitude(testVector2D)}");  // Should print 5
    Console.WriteLine($"Magnitude of 3D vector: {VectorMath.Magnitude(testVector3D)}");  // Should print 3
}
