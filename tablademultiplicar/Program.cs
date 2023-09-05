

namespace tablademultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }using System;

class TablaMultiplicar
    {
        static void Main()
        {
            int numero, resultado;

            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);
            }
        }
    }
}
}
