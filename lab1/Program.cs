using System;

namespace lab_1
{
    public class Program
    {
        public static double CalculateHypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        public static double CalculatePerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        public static void Main(string[] args)
        {
            // Вхідні дані: катети a і b
            double a = 7;
            double b = 9;

            // Знаходимо гіпотенузу c за формулою Піфагора
            double c = CalculateHypotenuse(a, b);
            Console.WriteLine("Гіпотенуза c = " + c);

            // Знаходимо периметр прямокутного трикутника
            double p = CalculatePerimeter(a, b, c);
            Console.WriteLine("Периметр p = " + p);

            // Зупиняємо консоль, щоб користувач міг переглянути результати
            Console.ReadLine();
        }
    }
}
