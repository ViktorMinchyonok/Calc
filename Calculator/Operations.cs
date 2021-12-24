using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  public static class Operations
    {
        public static string Add(string num1, string num2)
        {
            double a, b;
            if(!Double.TryParse(num1,out a)||!Double.TryParse(num2, out b)) { return null; }
            return (a + b).ToString();
        }
        public static string Sub(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return (a - b).ToString();
        }
        public static string Multiply(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return (a * b).ToString();
        }
        public static string Divide(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return (a / b).ToString();
        }
        public static string PDivide(string num1, string num2)
        {
            double a, b;
            if (!Double.TryParse(num1, out a) || !Double.TryParse(num2, out b)) { return null; }
            return (a * b / 100).ToString();
        }
        public static string Sinus(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Sin(a).ToString();
        }
        public static string Cosinus(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Cos(a).ToString();
        }
        public static string Factorial(string num1)
        {
            int a,  Factorial=1;
            double b;
            if ((!Double.TryParse(num1, out b))||(!Int32.TryParse(num1, out a))) { return "Ошибка"; }
            for (int i = 1; i < a+1; i++)
            { Factorial *= i; }
            return Factorial.ToString();
        }
        public static string Sqrt(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Sqrt(a).ToString();
        }

        public static string Log(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Log(a).ToString();
        }
        public static string Onedel(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            if (a == 0) return "Ошибка";
            return (1/a).ToString();
        }
        public static string Exp(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Exp(a).ToString();
        }
        public static string Pow(string num1)
        {
            double a;
            if (!Double.TryParse(num1, out a)) { return null; }
            return Math.Pow(a,2).ToString();
        }
    }
}
