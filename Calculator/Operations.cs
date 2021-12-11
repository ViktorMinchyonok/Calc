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

    }
}
