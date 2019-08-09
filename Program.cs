using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {

           

            int calcularPasos(int X, int Y, int D) {

                int cantPasos = 0;
                int suma = 0+X;

                while (suma<Y)
                {
                    suma += D;

                    cantPasos++;

                }
                
                return cantPasos;

            }

            Console.WriteLine(calcularPasos(10,85,30));
            Console.ReadKey();
        }

       
    }
}
