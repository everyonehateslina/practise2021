using System;

namespace Practice_10
{
    class Program
    {
     
        public static void ShowArray(int[] array)
        {
            Console.WriteLine("Ваш массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "   ");
            }
            Console.Write("\n");
        }
        private static int[,] GenerateMatrix(int n, int a, int b)
        {
            int[,] myArr = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    myArr[i, j] = rnd.Next(a, b);
                    Console.Write("{0,4}", myArr[i, j]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            return myArr;
        }
        
        
        private static void Kvadrat(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }
            ShowArray(array);
        }
        
        public static void Peretvorennya(int[] array, int n)
        {
            for(int i=0; i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    array[i] *= n;
                }
            }
            ShowArray(array);
        }
        
        public static void Numeracja(int[,] matrix)
        {
            Console.WriteLine("З якого рядка нумерувати: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[,] array = new string[matrix.GetLength(0) + 1, matrix.GetLength(1)];
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    array[i + 1, j] = Convert.ToString(matrix[i, j]);
                }
            }
            for(int i = 0; i < array.GetLength(0); i++)
            {
                if (i < n)
                {
                    array[i, 0] = " ";
                }
                else
                {
                    array[i, 0] = Convert.ToString(i-n+1);
                }
            }
            Console.WriteLine("Ваша пронумерована матриця: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "   ");
                }
                Console.Write("\n");
            }
        }
        
        static double FindBiggerNumber(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static double FindBiggerNumber(double a, double b, double c)
        {
            if (FindBiggerNumber(a,b)>c)
                return FindBiggerNumber(a,b);
            else
                return c;
        }
        
        static uint Mult(uint x, uint y) => x * y + 1;
        static int Mult(int x, int y) => x * y + 2;
        static long Mult(long x, long y) => x * y + 3;
        
        static int Progression(int n)
        {
            if (n == 0)
            {
                return 1;
            }
                return Progression(n - 1) + 1;

        }
        
        static int ArifmeticProgression(int n, int d)
        {
            if (n == 0)
            {
                return d;
            }

            return ArifmeticProgression(n - 1, d) + d;
        }
        
        static string Reverse(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            return Reverse(s.Substring(1)) + s[0].ToString();
        }

        static int IndexOfMax(int[] array, int len)
        {
            if (len == 0)
            {
                return len;
            }

            var i = IndexOfMax(array, len - 1);
            return array[len] > array[i] ? len : i;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введiть числа якi хочете пiднести до квадрату: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", "; " }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }
            Kvadrat(array);
            
            Console.WriteLine("Введiть масив: ");
            var parts1 = Console.ReadLine().Split(new[] { " ", ",", "; " }, StringSplitOptions.RemoveEmptyEntries);
            var array1 = new int[parts1.Length];

            for (int i = 0; i < parts1.Length; i++)
            {
                array1[i] = Convert.ToInt32(parts1[i]);
            }
            Console.WriteLine("На що ви хочете домножити вiд'ємнi числа: ");
            int  n = Convert.ToInt32(Console.ReadLine());
            Peretvorennya(array1, n);
            
           
            int[,] matrix = GenerateMatrix(5,-30,30);
            Numeracja(matrix);

            
            Console.WriteLine("Введiть три числа типу double: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double res = FindBiggerNumber(a, b, c);
            Console.WriteLine($"Найбiльше число це:  " + res);

            
            Console.WriteLine("Введiть бажану довжину ароифметичної прогресiї: ");
            var arifmetic = Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i < arifmetic; i++)
            {
                Console.Write("   " + Progression(i));
            }
 
            
            Console.Write("Введiть бажану довжину ароифметичної прогресiї:");
            var z = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введiть крок прогрессiї: ");
            var d = Convert.ToInt32(Console.ReadLine());

            var sum = 0;
            for (var i = 0; i < z; i++)
            {
                sum += ArifmeticProgression(i, d);
            }

            Console.WriteLine($"Сума {z} перших членiв арифметичної прогресiї дорi внює {sum}");

             
            Console.Write("Введiть строку для реверсу: ");
            var inputText = Console.ReadLine();
            Console.WriteLine("Iнвертована строка: " + Reverse(inputText));
            
           
            Console.WriteLine("Введiть строку для знаходження iндексу її максимального члена: ");
            var p = Console.ReadLine().Split(new[] { " ", ",", "; " }, StringSplitOptions.RemoveEmptyEntries);
            var aa = new int[p.Length];

            for (int i = 0; i < p.Length; i++)
            {
                aa[i] = Convert.ToInt32(p[i]);
            }
            Console.WriteLine("Iндекс максимального елементу масиву: " + IndexOfMax(aa, aa.Length -1));

            Console.ReadLine();
        }
    }
}
