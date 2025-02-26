using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
namespace FixacaoConceitosBasicos1.Model
{
    using System;

    class MetrosMilimetros
    {

        public static double Converter(double metros)
        {
            return metros * 1000;
        }
    }

    class Program
    {
        static void Main()
        {

            double metros = 54;
            double milimetros = MetrosMilimetros.Converter(metros);
            Console.WriteLine($"{metros} metros é igual a {milimetros} milímetros.");
        }
    }
}

  