using System;
using static Task_3.Matrix;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 10;
            Vector arr = new Vector(n);
            Vector arr1 = new Vector(n);
            arr.RandomInitialization(1, 20);
            Console.WriteLine(arr);
            arr.ReverseMassive();
            Convert.ToString(arr);
            Console.WriteLine(arr);
            arr.IsPalindrome();
            Console.WriteLine(arr1);
            arr1.IsPalindrome();
            Console.WriteLine(arr.BiggestPair());
            Console.WriteLine(arr1.BiggestPair());
            Console.WriteLine("input the the type of diagonal snake for matrix (Right or Down):");
            string UserTypeOfSnakeStart = Console.ReadLine();
            TypeOfSnakeStart typeOfSnakeStart = (TypeOfSnakeStart)Enum.Parse(typeof(TypeOfSnakeStart), UserTypeOfSnakeStart);
            Matrix matrix = new Matrix(5,5);
            matrix.DioganalSnake(typeOfSnakeStart);
            matrix.ShowMatrix();









        }
    }
}
