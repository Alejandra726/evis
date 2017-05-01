using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianzaDesviacion
{
    class Program
    {
       public static void Main(string[] args)
        {
            int suma = 0;

            Console.Write("¿De que tamaño desea el vector?");
            int v = int.Parse(Console.ReadLine());

            int[] vector = new int[v];

            for (int i = 0; i < v; i++)
            {
                Console.WriteLine("Ingrese el numero:");
                int num = int.Parse(Console.ReadLine());
                vector[i] = num;
            }

            for (int i = 0; i < v; i++)
            {
                suma = suma + vector[i];               
            }

            //int n = 0, val = 0, rep = 0;
            //for (int m = 0; m < v; m++)
            //{
            //    n = vector[m];
            //    if (rep<)
            //    {

            //    }
            //}

            double media = suma / v;
            Console.WriteLine("la suma es: {0} ", suma);
            Console.ReadLine();

        //    public static void ordenar()
        //    {
        //    int cambio;
        //    for(int i=0; i<v; i++)
        //    {

        //    }
        //}
        }
    }
}
