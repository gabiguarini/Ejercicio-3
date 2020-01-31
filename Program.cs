using System;

namespace Ejercicio_3
{
    class Program
    {
       
        public static void Main(string[] args)
        {
             Program ob = new Program();

             int nro;
             bool result;

            string happy = " es múltiplo de 3 pero no de 5, genial!";
            string sad = " boo! al parecer no es lo que buscamos :(";

            Console.WriteLine("Ingrese cualquier nro :)");
            nro = int.Parse(Console.ReadLine());

            result = ob.esMultiplo(nro);
            
            Console.WriteLine();
            Console.WriteLine(nro + (result?happy:sad));
            listado(nro);

        }

        public static void listado(int nro)
        {

            for (int i = 1; i < nro | i == nro & i % 5 != 0; i++)
            {
                Console.WriteLine(i * 3 + " es múltiplo de 3");
            }


        }

        public bool esMultiplo(int nro)
        {
            
        
            if (nro % 3 == 0 & nro % 5 != 0)
            {   
                
                return true;
                
            }

           
            return false;  
           
        }

        

    }
}
