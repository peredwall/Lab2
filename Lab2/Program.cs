using System;

namespace Lab2
{
    class Program
    {
        private static double GetHeight()
        {
            double height;

            Console.Write("Ange höjden: ");

            while (!double.TryParse(Console.ReadLine(), out height))
                Console.WriteLine("Ogiltigt värde!");

            return height;
        }

        private static double GetLength()
        {
            double length;

            Console.Write("Ange längden: ");

            while (!double.TryParse(Console.ReadLine(), out length))
                Console.WriteLine("Ogiltigt värde!");

            return length;
        }

        private static double GetRadius()
        {
            double radius;

            Console.Write("Ange radien: ");

            while (!double.TryParse(Console.ReadLine(), out radius))
                Console.WriteLine("Ogiltigt värde!");

            return radius;
        }

        private static double GetWidth()
        {
            double width;

            Console.Write("Ange bredden: ");

            while (!double.TryParse(Console.ReadLine(), out width))
                Console.WriteLine("Ogiltigt värde!");

            return width;
        }



        static void Main(string[] args)
        {
           


        }   
    }
}
