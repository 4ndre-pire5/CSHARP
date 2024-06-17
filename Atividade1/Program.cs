using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Somar dois numeros
            int num1, num2, resultado;

            Console.Write("Digite o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            resultado = num1 + num2;
            Console.WriteLine("A soma de {0} e {1} é {2}", num1, num2, resultado);
            Console.ReadLine();
        }
    }
}
