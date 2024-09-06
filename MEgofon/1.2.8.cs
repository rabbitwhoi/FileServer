using System;
namespace program 
{
    class Program
    {
        static void Main()
        {
            double sk = 121;
            //Сторона квадрата
            double ak = Math.Sqrt(sk);
            //Ширина прямоугольника
            double b = ak - 0.2;
            //Длина прямоугольника
            double a = 2 * ak;
            //Площадь прямоугольника
            double s = a * b;

            Console.WriteLine("Площадь прямоугольника: " + s);

            
        }


    }

}
