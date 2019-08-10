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

                double cantPasos = (Double)(Y - X) / D;
                double prueba = cantPasos % 1;
                if (cantPasos%1!=0)
                {
                    cantPasos = Math.Floor(cantPasos);
                    cantPasos += 1;
                }

                return (int) cantPasos;

            }

            Console.WriteLine(calcularPasos(10, 85, 30));
            Console.ReadLine();
        }

       
    }
}
