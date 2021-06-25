using System;
using RevichevaLab7;

namespace RevichevaLab10
{
    public class Program
    {
        public static void Main()
        {
            var toDouble = new []{2, 4, 8};
            var res = Params.DoubleEl(toDouble);
            foreach (var num in res)
            {
                Console.WriteLine(num);
            }
           
            
            var arrTochange = new int[] {1, 2, 3, 5};
            var diff = int.Parse(Console.ReadLine());
            var resTwo = Params.ArrChange(arrTochange, diff);
            foreach (var num in resTwo)
            {
                Console.WriteLine(num);
            }
            
            var toNumerate = new string[] {"hello", "world", "I am", "Lina"};
            var startNum = int.Parse(Console.ReadLine());
            var resThird = Params.Numerate(startNum, toNumerate);
            foreach (var word in resThird)
            {
                Console.WriteLine(word);
            }
            
            var one = double.Parse(Console.ReadLine());
            var two =  double.Parse(Console.ReadLine());
            var three = double.Parse(Console.ReadLine());
            Console.WriteLine(Overloads.FindMax(one, two, three));
            
            (uint, uint) firstEx = (2, 2);
            Console.WriteLine(Overloads.Multiply(firstEx.Item1, firstEx.Item2));
            
            (int, int) secondEx = (3, 3);
            Console.WriteLine(Overloads.Multiply(secondEx.Item1, secondEx.Item2));
            
            (long, long) thirdEx = (4, 4);
            Console.WriteLine(Overloads.Multiply(thirdEx.Item1, thirdEx.Item2));
            
            var progressionStart = int.Parse(Console.ReadLine());
            Recursion.GetNFirst(progressionStart);

            var count = 5;
            var dif = 3;
            var startFrom = 1;
            Recursion.SumOfFirst(count, dif, startFrom);
            
            var toReverseRec = Console.ReadLine();
            Console.WriteLine(Recursion.ReverseRec(toReverseRec));

            var arr = new[] {12, 15, 5, 19, 8, 20, 4, 13, 20, 65, 7, 8, 9,};
            Console.WriteLine(Recursion.FindMaxIndex(arr));

        }
    }
}