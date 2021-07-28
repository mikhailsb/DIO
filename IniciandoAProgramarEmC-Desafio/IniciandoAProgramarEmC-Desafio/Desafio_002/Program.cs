using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());

            //Insira as variaveis de acordo com o solicitado
            int SOMA = A + B;

            //Print
            Console.WriteLine("SOMA = {0}", SOMA);
            Console.ReadLine();
        }
    }
}
