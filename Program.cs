using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;
            bool result;
            string happy = " es múltiplo de 3 pero no de 5, genial!";
            string sad = " boo! al parecer no es lo que buscamos :(";
            Program ob = new Program();
            Console.WriteLine("Ingrese cualquier nro :)");
            nro = int.Parse(Console.ReadLine());

            result = ob.esMultiplo(nro);

            Console.WriteLine();
            Console.WriteLine(nro + (result?happy:sad));

            

        }

        private bool esMultiplo(int nro)
        {
            if (nro % 3 == 0 & nro % 5 != 0)
            {
                return true;
            }
            return false;
        }

        
    }
}
