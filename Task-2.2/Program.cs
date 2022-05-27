using System;

namespace Task_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Matrix mass1 = new Matrix(n,m);
            Matrix mass2 = new Matrix(n, m);
            Matrix mass3 = new Matrix(n,m);
            if (n == m)
            {
                mass1.DioganalSnake();
                Console.WriteLine("Матрица А: ");
                mass1.ShowMatrix();
            }
            else
                Console.WriteLine("Sorry, but DioganalSnake work only for square matrix");
            mass2.VerticalSnake();
            Console.WriteLine();
            Console.WriteLine("Матрица В: ");
            Console.WriteLine();
            mass2.ShowMatrix();
            Console.WriteLine();
            Console.WriteLine("Матрица C: ");
            mass3.SpiralSnake();
            mass3.ShowMatrix();
        }
    }
}
