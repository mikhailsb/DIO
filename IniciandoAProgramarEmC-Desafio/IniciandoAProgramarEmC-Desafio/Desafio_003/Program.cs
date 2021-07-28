using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_003
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            //complete com as variaveis
            mediaP = ((Math.Abs(a)*3.5) + (Math.Abs(b)*7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));
            Console.ReadLine();
        }
    }
}
