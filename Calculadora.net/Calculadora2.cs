using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.net
{
    internal class Calculadora2
    {
        private bool esNumero1;
        private bool esNumero2;

        private double num1 {  get; set; }
        private double num2 { get; set; }

        public Calculadora2(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public double sumar()
        {
            return num1 + num2;
        }
        public double restar()
        {
            return num1 - num2;
        }
        public double multiplicar()
        {
            return num1 * num2;
        }
        public double dividir()
        {
            if (num1 == 0)
            Console.WriteLine("No se puede dividir por 0");
            return num1 / num2;
        }
    }
}
