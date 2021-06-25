using System;

namespace RevichevaLab10
{
    public class Recursion
    {
        public static void GetNFirst(int count, int current = 1, int diff = 1)
        {
            if(count == 0)
               return;
            
            Console.WriteLine(current);

            GetNFirst(count - 1, current + diff);
        }
        
        public static void SumOfFirst(int count, int difference, int current, int sum = 0)
        {
            if (count > 0)
                sum += current;
 
            if (count >= 1)
            {
                current += difference;
                Console.WriteLine($"The sum is {sum}");
                SumOfFirst(count - 1, difference, current, sum);
            } 
        }

        public static string ReverseRec(string origin)
        {
            if (origin == null || origin.Length <= 1)
                return origin;

            return ReverseRec(origin.Substring(1)) + origin[0];
        }
        
        public static int FindMaxIndex(int[] array, int index = 0, int currentMax = 0)
        {
            if (index == 0)
            {
                currentMax = array[0];
            }
    
            if (index == array.Length)
            {
                return Array.IndexOf(array, currentMax);
            }
            else
            {
                currentMax = Math.Max(currentMax, array[index]);
                return FindMaxIndex(array, index + 1, currentMax);
            }
        }
    }
}