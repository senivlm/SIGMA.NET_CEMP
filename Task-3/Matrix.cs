using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public partial class Matrix
    {
    

    public TypeOfSnakeStart SnakeStart { get; }
        private int n;
        private int m;
        private int[,] matrix;

        // Создаем конструкторы матрицы
        public Matrix() { }
        public int N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }
        public int M
        {
            get { return m; }
            set { if (value > 0) m = value; }
        }

        // Задаем аксессоры для работы с полями вне класса Matrix
        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
            matrix = new int[this.n, this.m];
        }
        public int this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }

        // Ввод матрицы с клавиатуры
        public void SpiralSnake()
        {
            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int dirChanges = 0;
            int visits = m;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[row, col] = i + 1;
                if (--visits == 0)
                {
                    visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }

                col += dx;
                row += dy;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    var tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, m - j - 1];
                    matrix[i, m - j - 1] = tmp;
                }
            }

        }

        public void VerticalSnake()
        {
            int value = 1;
            for(int j = 0; j < m; j++)
            {
                if(j%2 == 0)
                {
                    for (int i = 0; i<n; i++)
                    {
                        matrix[i, j] = value;
                        value++;
                    }
                }
                else
                {
                    for (int i = n-1; i>=0; i--)
                    {
                        matrix[i,j] = value;
                        value++;
                    }
                }
            }
        }

        public void DioganalSnake(TypeOfSnakeStart SnakeStart)
        {
            if (SnakeStart == TypeOfSnakeStart.Right)
            {
                int value = 1;
                for (int diff = 1 - n; diff <= n - 1; diff++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        int j = i - diff;

                        if (j < 0 || j >= n)
                            continue;

                        if (((diff + n + 1) % 2) != 0)
                            matrix[i, n - 1 - j] = value++;
                        else
                            matrix[n - 1 - j, i] = value++;
                    }
                }
            }

            if (SnakeStart == TypeOfSnakeStart.Down)
            {
                int value = 1;
                for (int diff = 1 - n; diff <= n - 1; diff++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        int j = i - diff;

                        if (j < 0 || j >= n)
                            continue;

                        if (((diff + n + 1) % 2) != 0)
                            matrix[n - 1 - j, i] = value++;
                        
                        else
                            matrix[i, n - 1 - j] = value++;
                    }
                }
            }
        }
       
        public void ShowSpiralSnake()
        {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n / 2; j++)
                    {
                        var tmp = matrix[i, j];
                        matrix[i, j] = matrix[i, m - j - 1];
                        matrix[i, m - j - 1] = tmp;
                    }
                }

        }

        public void ShowMatrix()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
