using System;

namespace Examples_For_Practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 100;
            int minPrice = 20;

            Console.Write("Введіть ціну товару:");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Варіант 1 - && логічне І");

            if (minPrice <= price && price <= money)
            { 
                Console.WriteLine("Придбаємо");
            }
            else
            {
                Console.WriteLine("Не придбаємо");
            }

            Console.WriteLine();
            Console.WriteLine("Варіант 2 - || логічне АБО");
           
            if (price < minPrice || price > money)
            {
                Console.WriteLine("Не придбаємо");
            }
            else
            {
                Console.WriteLine("Придбаємо");
            }

            Console.WriteLine();
            Console.WriteLine("Варіант 3 - ! НЕ та || логічне АБО");
            
            if (!(price < minPrice || price > money))
            {
                Console.WriteLine("Придбаємо");
            }
            else
            {
                Console.WriteLine("Не придбаємо");
            }
        }
    }
}
