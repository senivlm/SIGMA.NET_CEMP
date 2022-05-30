using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Vector
    {
        int[] arr;


        public int this[int index]
        {
            get
            { 
                if(index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new Exception("Index out of range array");
                }
            }
            set 
            {
                arr[index] = value;
            }
        }

        public Vector(int[] arr)
        {// Так не можна робити. Ви робите прив'язку 2 об'єктів!!! Тут слід реалізувати глибоку копію!! Якщо не зрозуміли коментар, зверніться особисто, я поясню.Дуже важливо!!
            this.arr = arr;
        }

        public Vector(int n)
        {
            arr = new int[n];
        }

        public Vector() { }

        public void RandomInitialization(int a, int b)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(a, b);
            }
        }


        public void InitShufle()
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                int val = 0;
                do
                {
                    val = random.Next(1, arr.Length + 1);
                } while (!arr.Contains(val));
                arr[i] = val;
            }
        }
        public bool IsPalindrome()
        {
            int lenght = arr.Length;
            int middle = arr.Length / 2 + 1;
            for (int i = 0; i < middle; i++)
            {
                if (!(arr[i] == arr[lenght - 1 - i]))
                {// тут треба не роздруковувати, а генерувати виняток!
                    Console.WriteLine("Not a Palindrome");
                    return false;
                    
                }
                    
            }
            Console.WriteLine("Array a Palindrome");
            return true;
        }

        public void ReverseMassive()
        {
            int lenght = arr.Length;
            int halfLenght = lenght / 2;
            int temp = 0;
            for (int i = 0; i < halfLenght; i++)
            {
                temp = arr[i];
                arr[i] = arr[lenght - i-1];
                arr[lenght - i-1] = temp;
            }
        }
        public void ReverseMassiveDeffolt()
        {
            var arr1 = arr.Reverse();
            Console.WriteLine(arr1);
            
        }

        public Pair[] CalculateFreq()
        {
            
            Pair[] pairs = new Pair[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                pairs[i] = new Pair(0,0);

            }
            int countDifference = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isElement = false;
                for (int j = 0; j < countDifference; j++)
                {
                    if(arr[i] == pairs[j].Number)
                    {
                        pairs[j].Freq++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Freq++;
                    pairs[countDifference].Number = arr[i];
                    countDifference++;
                }
            }

            Pair[] result = new Pair[countDifference];
            for (int i = 0; i < countDifference; i++)
            {
                result[i] = pairs[i];
            }

            return result;
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i] + " ";
            }
            return str;
        }

        public Pair BiggestPair()
        {
            Pair[] pairs = CalculateFreq();
            Pair result = new Pair(0, 0);
            for (int i = 0; i < pairs.Length; i++)
            {
                if (pairs[i].Freq > result.Freq)
                {
                    result = pairs[i];
                }
            }
            return result;
        }
    }
}
