using System;
namespace program 
{
    class Program
    {
        static void Main()
        {

            double a = 25;
            double b = 3;

            // Скорость катера по течению 
            double v_po_teceniu = a + b;
            //Скорость катера против течения
            double v_protiv = a - b;
            //Отношение
            double result = v_po_teceniu / v_protiv;
            Console.WriteLine("Скорость катера по течению больше скорости против течения в " + result + " раза");

            
        }


    }

}
