﻿using System;
using System.Globalization;

namespace DioExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("nota invalida");

                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }

            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");

                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double media = (nota1 + nota2) / 2;

            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
