using System;
using System.Globalization;
namespace URI { 
class URI
{

    static void Main(string[] args)
    {
            /*int A, B, C, D, diferença;

            A= int.Parse(Console.ReadLine());
            B= int.Parse(Console.ReadLine());
            C= int.Parse(Console.ReadLine());
            D= int.Parse(Console.ReadLine());

            diferença= ((A * B) - (C * D));

            Console.WriteLine("DIFERENCA = " + diferença);
            */

            int numeroFuncionario, horasTrabalhadas;
            double ValorHora, salario;

            numeroFuncionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horasTrabalhadas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ValorHora= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = (horasTrabalhadas * ValorHora);

            Console.WriteLine("NÚMERO = " + numeroFuncionario);
            Console.WriteLine("SALÁRIO = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

        }
}
}