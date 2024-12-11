using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MyCompiler
{
    class Program
    {
        public static void Main(string[] args)
        {

            char[,] asientos = new char[10, 10];
            bool b = true; //bandera para finalizar el proceso
            int k;  // eleccion del usuario

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    asientos[i, j] = 'L';
                }
            }

            while (b)
            {
                Console.WriteLine("1 - ver asientos disponibles \n" +
                                    "2 - reservar asientos \n" +
                                    "3 - salir");

                k = int.Parse(Console.ReadLine());

                if (k == 1)
                {
                    VerDisponibles(asientos);
                }
                else if (k == 2)
                {
                    Reserva(asientos);
                }
                else if (k == 3)
                {
                    b = false;
                }
                else
                {
                    Console.WriteLine("el numero ingresado no es valido");
                }

            }

        }

        static void VerDisponibles(char[,] arr)
        {
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    Console.Write("[" + arr[i, j] + "]");

                    if (arr[i, j] == 'L')
                    {
                        count++;
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("asientos disponibles: " + count);
        }

        static void Reserva(char[,] arr)
        {

            int f; //numero de fila
            int c; //numero de columna
            int k; // eleccion de usuario 
            bool b = true; // bandera


            while (b)
            {

                Console.WriteLine("Ingrese numero de fila (1 a 10):");
                f = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine("Ingrese numero de columna (1 a 10)");
                c = int.Parse(Console.ReadLine()) - 1;

                if (arr[f, c] == 'L')
                {
                    arr[f, c] = 'X';
                    Console.WriteLine("Reserva realizada con exito. \nDesea realizar otra reserva? \n1 - SI \n2 - NO");
                    k = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("No se ha podido realizar la operacion, el asiento seleccionado se encuentra ocupado");
                    Console.WriteLine("Desea elegir otro asiento? \n1 - SI \n2 - NO");
                    k = int.Parse(Console.ReadLine());
                }
                if (k == 2)
                {
                    b = false;
                }
            }

        }

    }
}