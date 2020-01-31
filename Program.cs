using System;

namespace Ejercicio_3
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cualquier nro :)");
            int nro = int.Parse(Console.ReadLine());
            Console.WriteLine();
            listado(nro);

        }

        public static void listado(int nro)
        {
            
            int veces = nro+1;
            for (int i = 1; i < veces;)
            {
                if(i % 5 != 0)
                {
                    Console.WriteLine(i * 3 + " es múltiplo de 3");
                }
                
                 i++;
            }


        }

    }
}
