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

        private static void VolumeCube()
        {
            double volume = (GetHeight() * GetLength() * GetWidth());
            Console.WriteLine("Volymen av din kub är: {0}", volume);
            Console.ReadKey();
        }

        private static void VolumeCylinder()
        {
            const double pi = Math.PI;
            double volume = (GetHeight() * pi * Math.Sqrt(GetRadius()));
            Console.WriteLine("Volymen av din cylinder är: {0}", volume);
            Console.ReadKey();
        }

        private static void VolumeCone()
        {
            const double pi = Math.PI;
            double volume = ((GetHeight() * pi * Math.Sqrt(GetRadius())) / 3);
            Console.WriteLine("Volymen av din kon är: {0}", volume);
            Console.ReadKey();
        }

        private static void VolumeGlobe()
        {
            const double pi = Math.PI;
            double volume = ((4 * Math.Pow(GetRadius(), 3) * pi) / 3);
            Console.WriteLine("Volymen av ditt klot är: {0}", volume);
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
           


        }   
    }
}
