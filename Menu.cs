using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;



namespace Calculadora3._0
{
    internal class Menu
    {
        List<Opcion> opciones;
        Calculadora calculadora = new Calculadora(0, 0);

        public Menu()
        {


            opciones = new List<Opcion>() {
            new Opcion("Sumar", Sumar),
            new Opcion("Restar", Restar),
            new Opcion("Multiplicar", Multiplicar),
            new Opcion("Dividir", Dividir),
            new Opcion("Salir", () => Environment.Exit(0))
        };

            while (true)
            {
                MostrarMenu();
                seleccionarOpcion();
            }
        }

        public void MostrarMenu()
        {
            foreach (Opcion opcion in opciones)
            {
                Console.WriteLine(opciones.IndexOf(opcion) + "." + opcion.Message);
            }
        }

        public void seleccionarOpcion()
        {
            int numOpcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            opciones[numOpcion].Action.Invoke();
            

        }

        private void Sumar()
        {
            calculadora.RealizarOperacion("Sumar");
            calculadora.Sumar();
            Console.WriteLine("El resultado es: " + calculadora.Sumar());
        }

        private void Restar()
        {
            calculadora.RealizarOperacion("Restar");
            calculadora.Restar();
            Console.WriteLine("El resultado es: " + calculadora.Restar());
        }

        private void Multiplicar()
        {
            calculadora.RealizarOperacion("Multiplicar");
            calculadora.Multiplicar();
            Console.WriteLine("El resultado es: " + calculadora.Multiplicar());
        }

        private void Dividir()
        {
            calculadora.RealizarOperacion("Dividir");
            calculadora.Dividir();
            Console.WriteLine("El resultado es: " + calculadora.Dividir());
        }




    }
}
