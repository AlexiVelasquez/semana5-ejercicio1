﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 7;

            int resultado = 0;

            for (int i = 1; i <=10 ; i++)
            {


                Console.WriteLine(numero+"x"+i+"="+(numero*i));

            }
           Console.ReadKey();

        }
    }
}
   