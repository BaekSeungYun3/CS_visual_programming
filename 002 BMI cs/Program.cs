using System;
using System.Collections.Generic;
using System.Linq;

namespace _002_BMI_cs // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double weight, height;

            Console.Write("체중(kg): ");
            string s = Console.ReadLine();
            weight = double.Parse(s);

            Console.Write("키(cm): ");
            s = Console.ReadLine();
            height = double.Parse(s);

            double bmi = weight / (height / 100 * height / 100);
            Console.WriteLine("BMI = " + bmi);

        }
    }
}