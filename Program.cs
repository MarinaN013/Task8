// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Segment()
        {
            Console.WriteLine("отрезок");
        }
        static void TwoSegments()
        {
            Console.WriteLine("два отрезка");
        }
        static void Triangle(int m1, int m2, int m3)
        {
            int a, b, c;
            if (m1 > m2 && m1 > m3)
            {
                c = m1;
                a = m2;
                b = m3;
            }
            else
                if (m2 > m3 && m2 > m1)
            {
                c = m2;
                a = m1;
                b = m3;
            }
            else
            {
                c = m3;
                a = m2;
                b = m1;
            }
            if (a + b <= c)
                Console.WriteLine("три отрезка");
            else
                if (c * c == a * a + b * b)
                Console.WriteLine("прямоугольный треугольник");
            else
                    if (c * c < a * a + b * b)
                Console.WriteLine("остроугольный треугольник");
            else
                Console.WriteLine("тупоугольный треугольник");
        }
        static void Tetragon(int m1, int m2, int m3, int m4)
        {
            if (m1 + m2 + m3 > m4 || m1 + m2 + m4 > m3 || m1 + m4 + m3 > m2 || m4 + m2 + m3 > m1)
                if (m1 == m2 && m2 == m3 && m3 == m4)
                    Console.WriteLine("квадрат");
                else
                    Console.WriteLine("четырехугольник");
            else
                Console.WriteLine("четыре отрезка");

        }

        static void Main()
        {
            int[] a;

            string[] s = Console.ReadLine().Split();
            a = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
                a[i] = Convert.ToInt32(s[i]);
            for (int i = 0; i < s.Length; i++)
            {
                if (a[i] <= 0)
                {
                    Console.WriteLine("сторона не может быть меньше нуля");
                    Console.ReadKey();
                    return;
                }
            }
            switch (s.Length)
            {
                case 1:
                    Segment();
                    break;
                case 2:
                    TwoSegments();
                    break;
                case 3:
                    Triangle(a[0], a[1], a[2]);
                    break;
                case 4:
                    Tetragon(a[0], a[1], a[2], a[3]);
                    break;
                default:
                    Console.WriteLine("фигура не определена");
                    break;
            }
            Console.ReadKey();
        }
    }
}