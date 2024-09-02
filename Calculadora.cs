using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora3._0
{
    internal class Calculadora
    {
        double cantidad1;
        double cantidad2;
        double resultado;

        public Calculadora(double cantidad1, double cantidad2)
        {
            this.cantidad1 = cantidad1;
            this.cantidad2 = cantidad2;
        }

        public void RealizarOperacion(string operacion)
        {
            Console.Write("Ingrese el primer número: ");
            cantidad1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            cantidad2 = double.Parse(Console.ReadLine());
        }
        public double Sumar()
        {
            resultado = cantidad1 + cantidad2;

            return resultado;
        }

        public double Restar()
        {
            resultado = cantidad1 - cantidad2;

            return resultado;
        }
        public double Multiplicar()
        {
            resultado = cantidad1 * cantidad2;

            return resultado;
        }
        public double Dividir()
        {
            resultado = cantidad1 / cantidad2;

            return resultado;
        }
    }
}
