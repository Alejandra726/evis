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
            int[] vVector = new int[v];
            int varianza = 0;

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
            double media = suma / v;
            for (int i = 0; i < v; i++){
                int a = vector[i] - Convert.ToInt16(media);
                vVector[i] = a * a;
            }
            for (int i=0; i<v; i++){
                varianza += vVector[i];
            }
            varianza = varianza / v;
            Console.WriteLine("La varianza es: " + varianza);
            Console.WriteLine("La suma es: {0} ", suma);
            Console.WriteLine("La media es: " + media);
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
