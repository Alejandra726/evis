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
            float suma = 0;

            Console.Write("¿De que tamaño desea el vector?");
            int v = int.Parse(Console.ReadLine());

            float[] vector = new float[v];
            float[] vVector = new float[v];
            float varianza = 0, var = 0, m = 0, a1=0, a2=0;


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
            float media = suma / v;

            for (int i = 0; i < v; i++){
                float t = vector[i] - media;
                vVector[i] = t * t;
            }
            for (int i=0; i<v; i++){
                varianza = varianza + vVector[i];
            }
            varianza = varianza / v;

            do
            {
                var = var + 0.1F;
                m = var * var;
            } while (m <= varianza);
            a1 = var;
            a2 = varianza;
            a2 = a2 / a1;
            a2 = a2 + a1;
            a2 = a2 / 2;

            Console.WriteLine("La desviación estándar es:" + a2);
            Console.WriteLine("La varianza es: " + varianza);
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
