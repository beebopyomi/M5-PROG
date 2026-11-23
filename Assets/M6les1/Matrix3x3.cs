public class Matrix3x3
{
    private float[,] matrix {get; set; }

    public Matrix3x3(float a, float b, float c, float d, float e, float f, float g, float h, float i)
    {
        matrix = new float[3, 3];
        matrix[0, 0] = a;
        matrix[0, 1] = b;
        matrix[0, 2] = c;

        matrix[1, 0] = d;
        matrix[1, 1] = e;
        matrix[1, 2] = f;

        matrix[2, 0] = g;
        matrix[2, 1] = h;
        matrix[2, 2] = i;
    }

    // Determinant berekenen
    public float Determinant()
    {
        float a = matrix[0, 0];
        float b = matrix[0, 1];
        float c = matrix[0, 2];

        float d = matrix[1, 0];
        float e = matrix[1, 1];
        float f = matrix[1, 2];

        float g = matrix[2, 0];
        float h = matrix[2, 1];
        float i = matrix[2, 2];

        return a * (e * i - f * h)
             - b * (d * i - f * g)
             + c * (d * h - e * g);
    }
}
