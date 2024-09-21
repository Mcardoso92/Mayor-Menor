using System;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PASO 0: DECLARACION DE VARIABLES
            int NUM;

            //PASO 1: INGRESAR NUMERO
            Console.WriteLine("Ingrese un numero: ");
            NUM = int.Parse(Console.ReadLine());

            //PASO 2: MOSTRAR AVISO

            if(NUM > 10)
                Console.WriteLine("El Numero es mayor a 10");
            
            else
                Console.WriteLine("El numero no es mayor a 10");                    
    
        }
    }
}
