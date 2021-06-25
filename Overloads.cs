using System;

namespace RevichevaLab7
{
    public class Overloads
    {
        //Task 1
        // The signature is: Summa(int, int, int)

        public static double FindMax(double one, double two, double three) => Math.Max(one, Math.Max(two, three));

        public static uint Multiply(uint first, uint second) => (first * second) + 1;
        public static int Multiply(int first, int second) => (first * second) + 2;
        public static long Multiply(long first, long second) => (first * second) + 3;
    }
}