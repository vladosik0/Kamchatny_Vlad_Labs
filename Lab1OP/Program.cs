using System;
using System.IO;
using Newtonsoft.Json;
namespace Lab1_2__OP
{
    class Program
    {
        public static int [,] Hand_2d_Array()
        {
            Console.WriteLine("Creating matrix");
            int rows, cols;
            Console.Write("Write number of rows: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Write number of cols: ");
            cols = int.Parse(Console.ReadLine());
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Write the {i + 1} row: ");
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return result;
        }
        public class Matrix
        {
          
            public int Rows { get; set; }
            public int Cols { get; set; }
            public int[,] Twod_array;
            public int this[int i, int j]
            {
                get => Twod_array[i, j];
                set => Twod_array[i, j] = value;
            }

            public Matrix(int [,] twod_array)
            {
                Rows=twod_array.GetLength(0);
                Cols = twod_array.GetLength(1);
                Twod_array = twod_array;
            }
            public void SumOfMatrixes(Matrix matrix)
            {
                Console.WriteLine("Sum of matrixes");
                if(this.Rows!=matrix.Rows||this.Cols!=matrix.Cols)
                {
                    Console.WriteLine("Rows or cols of two matrixes are not equal!!!");
                    return;
                }
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        this.Twod_array[i, j] += matrix.Twod_array[i,j];
                    }
                }
            }
            public void DifferenceOfMatrixes(Matrix matrix)
            {
                Console.WriteLine("Difference of matrixes");

                if (this.Rows != matrix.Rows || this.Cols != matrix.Cols)
                {
                    Console.WriteLine("Rows or cols of two matrixes are not equal!!!");
                    return;
                }
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        this.Twod_array[i, j] -= matrix.Twod_array[i, j];
                    }
                }
            }
            public void ScalarMultiplication(int scalar)
            {
                Console.WriteLine("Scalar multiplication");
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        this.Twod_array[i, j] *= scalar;
                    }
                }
            }
            public Matrix MultiplicationOfMatrixes(Matrix matrix)
            {
                Console.WriteLine("Multiplication of matrixes");
                if (this.Cols != matrix.Rows)
                {
                    Console.WriteLine("Rows/cols of two matrixes are not equal!!!");
                    return this;
                }
                int[,] result = new int[this.Rows,matrix.Cols];
                int sum;
                for (int i = 0; i < this.Rows; i++)
                {
                    for (int j = 0; j < matrix.Cols; j++)
                    {
                        sum = 0;
                        for(int k=0;k<this.Rows;k++)
                        {
                            sum += this.Twod_array[i, k] * matrix.Twod_array[k,j];
                        }
                        result[i,j]=sum;
                    }
                }

                return new Matrix(result);
            }
            public void TransponateMatrix()
            {
                Console.WriteLine("Transponation of matrix");
                int temp=Rows;
                Rows = Cols;
                Cols = temp;
                int[,] new_2D_array = new int[Rows, Cols];
                for(int i=0;i<Rows;i++)
                {
                    for (int j=0;j<Cols;j++)
                    {
                        new_2D_array[i,j]= this.Twod_array[j, i];
                    }
                }
                Twod_array = new_2D_array;
            }
            public bool IsSquared()
            {
                if(Rows==Cols)
                {
                    return true;
                }
                return false;
            }
            public bool IsSymmetricByMainDiagonal(bool isSquared)
            {
                if(!isSquared)
                {
                    Console.WriteLine("Matrix is not symmetric because it's not squared");
                    return false;
                }
                for(int i=0;i<Rows;i++)
                {
                    for(int j=0;j<Cols;j++)
                    {
                        if((Twod_array[i,j]!=Twod_array[j,i])&&i!=j)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            public bool IsSymmetricBySecondaryDiagonal(bool isSquared)
            {
                if (!isSquared)
                {
                    Console.WriteLine("Matrix is not symmetric because it's not squared");
                    return false;
                }
                for(int i=0;i<Rows;i++)
                {   
                    for(int j=0;j<Cols;j++)
                    {
                        if(Twod_array[i,j]!=Twod_array[(Rows-1)-j,(Cols-1)-i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            public void PrintMatrix()
            {
                Console.WriteLine("Matrix:");
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        Console.Write(Twod_array[i,j]+"\t");
                    }
                    Console.WriteLine();
                }
            }

        }
        public static void SaveMatrixInFile(Matrix matrix,string fileName)
        {
            Console.WriteLine("Writing object in JSON...");
            Console.WriteLine("Succeed");
            string jsonString = JsonConvert.SerializeObject(matrix);
            File.WriteAllText(fileName, jsonString);
        }
        public static Matrix ReadMatrixFromFile(string fileName)
           {
               Console.WriteLine("Reading matrix from JSON...");
               Console.WriteLine("Succeed");
               string jsonString = File.ReadAllText(fileName);
               return JsonConvert.DeserializeObject<Matrix>(jsonString);
           }
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(Hand_2d_Array());
            matrix.PrintMatrix();
            /* Matrix matrix1 = new Matrix(Hand_2d_Array());
             matrix1.PrintMatrix();
             Matrix multi_matrix = matrix.MultiplicationOfMatrixes(matrix1);
             multi_matrix.PrintMatrix();*/
            /* matrix.SumOfMatrixes(matrix1);
             matrix.PrintMatrix();
             matrix.DifferenceOfMatrixes(matrix1);
             matrix.PrintMatrix();
             matrix.ScalarMultiplication(2);
             matrix.PrintMatrix();*/
            /*  matrix.TransponateMatrix();
              matrix.PrintMatrix();*/
           /* Console.WriteLine("Matrix is squared: " + matrix.IsSquared());
            Console.WriteLine("Matrix is symmetric by seccondary diagonal: " + matrix.IsSymmetricBySecondaryDiagonal(matrix.IsSquared()));
            Console.WriteLine("Matrix is symmetric by main diagonal: " + matrix.IsSymmetricByMainDiagonal(matrix.IsSquared()));*/
            SaveMatrixInFile(matrix, "file.json");
            Matrix newMatrix = ReadMatrixFromFile("file.json");
            newMatrix.PrintMatrix();





        }
    }
}
