using System;
using System.Collections.Generic;
using System.Linq;

namespace RevichevaLab7
{
    public class Params
    {
        public static int[] DoubleEl(params int[] args)
        {
            return args.Select(num => (int) Math.Pow(num, 2)).ToArray();
        }

        public static int[] ArrChange(int[] value, int multiplier)
        {
            for (var i = 0; i <= value.Length - 1; i++)
            {
                if (value[i] < 0)
                {
                    value[i] *= multiplier;
                }
            }

            return value;
        }

        public static string[] Numerate(int startNum, params string[] args)
        {
            for (var i = 0; i < args.Length - 1; i++)
            {
                args[i] = $"{startNum + i}{args[i]}";
            }

            return args;
        }
    }
}