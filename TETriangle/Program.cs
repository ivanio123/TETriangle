using System;

namespace TETriangle
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Сторони першого трикутника 6 см");
                TETriangle triangle = new TETriangle(6,6,6);
                Console.WriteLine(triangle.ToString());
                Console.WriteLine("Периметр = " + triangle.CalculatePerimeter(triangle));
                Console.WriteLine("Площа = " + triangle.CalculateArea(triangle));

                Console.WriteLine("Сторони другого трикутника 7 см");
                TETriangle triangle1 = new TETriangle(7, 7, 7);
                Console.WriteLine(triangle1.ToString());
                Console.WriteLine("Периметр = " + triangle.CalculatePerimeter(triangle1));
                Console.WriteLine("Площа = " + triangle.CalculateArea(triangle1));

                Console.WriteLine("Перевiрка на рiвнiсть трикутникiв:");
                if (triangle.Equals(triangle, triangle1)) Console.WriteLine("Рiвнi");
                else Console.WriteLine("Не рiвнi");

                Console.WriteLine("Довжина сторони основи правильної трикутної піраміди 6 см, висота 5 см");
                TEPyramid pyramid = new TEPyramid(6, 6, 6, 5);
                Console.WriteLine(pyramid.ToString());

                Console.WriteLine("Об'єм = " + pyramid.CalculateVolume(pyramid));
            }
        }
    }

