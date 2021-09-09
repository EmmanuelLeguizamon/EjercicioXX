using System;

namespace EjercicioXX
{
    class Program
    {
        static void Main(string[] args)


        {
            ConsoleKeyInfo cki;

            do
            {
                bool isString;
                string n1, n2;
                Console.WriteLine("'Vamos a determinar cual es el mayor entre 2 números'");


                Console.Write("Ingrese el primer número: \n");
                n1 = Console.ReadLine();

                isString = Decimal.TryParse(n1, out decimal m1);



                Console.Write("Ingrese el segundo número: \n");
                n2 = Console.ReadLine();


                Decimal.TryParse(n2, out decimal m2);

                if (m1 > m2)
                {
                    Console.WriteLine("El primer numero es mayor al segundo");
                }
                else
                {
                    if (m2 > m1)
                    {
                        Console.WriteLine("El segundo numero es mayor al primero");

                    }
                    else
                    {
                        Console.WriteLine("Los dos numeros son iguales");
                    }
                }
               
               
                Console.WriteLine("Si queres salir, apreta 'S'. Sino, apreta cualquier tecla.");
                cki = Console.ReadKey();


                Console.Clear();
            } while (cki.Key != ConsoleKey.S);

            
          
        }
    }
}
