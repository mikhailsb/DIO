﻿using System;

namespace IniciandoAProgramarEmC_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                
                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = (double)X / Y; // Digite aqui o calculo da divisao
                    Console.WriteLine(divisao.ToString("N1"));
                }
            }
            Console.ReadLine();

        }
    }
}
