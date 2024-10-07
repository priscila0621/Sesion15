﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Operation
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Substraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }
        public double Power(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
        public double SquareR(double num) 
        {
            return Math.Sqrt(num);
        }
        public string ShutDown()
        {
            return "Adios Usuario";
        }
    }
}
