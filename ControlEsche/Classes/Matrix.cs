using System.Data;
using System.Numerics;
using System.Xml.XPath;

class Matrix
{
    int rows;
    int columns;
    int[,] matrix;
    Random random = new Random();
    public Matrix(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        matrix = new int[rows,columns];
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i,j] = random.Next(10000);
            }
        }
    }
    public static Matrix operator +(Matrix matrixA, Matrix matrixB)
    {
        if (matrixA.columns == matrixB.columns && matrixA.rows == matrixB.rows)
        {
            Matrix resultMatrix = new Matrix(matrixA.rows, matrixA.columns);
            for (int i = 0; i < matrixA.rows; i++) 
            {
                for (int j = 0; j < matrixA.columns;  j++)
                {
                    resultMatrix.matrix[i,j] = matrixA.matrix[i,j] + matrixB.matrix[i,j];
                }
            }
            return resultMatrix;
        }
        else
        {
            throw new ArgumentException("The value must be identic to each other, no difference.");
        }
    }
    public static Matrix operator *(Matrix matrixA, int numberToMultiply)
    {
        Matrix resultMatrix = new Matrix(matrixA.rows, matrixA.columns);
        for (int i = 0; i < matrixA.rows; i++)
        {
            for (int j = 0; j < matrixA.columns; j++)
            {
                resultMatrix.matrix[i,j] = matrixA.matrix[i,j] * numberToMultiply;
            }
        }
        return resultMatrix;
    }
    public void Print()
    {
        Console.WriteLine();
        for (int i =0; i < rows; i++)
        {
            Console.Write("[");
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i,j]} ");
            }
            Console.WriteLine("]");
        }
        Console.WriteLine();
    }
    public Matrix Transpose()
    {
        Matrix transposed = new Matrix(columns,rows);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transposed.matrix[j,i] = matrix[i,j];
            }
        }
        return transposed;
    }
}