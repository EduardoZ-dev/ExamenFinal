using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class GestorReadersCove
    {
        ListaLibros listalibros = new ListaLibros();
        

        public void GestionAdmin()
        {

        }

        public void GestionUsuario()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("***Atencion al Cliente ReadersCove***");
                Console.WriteLine("¿Que desea realizar? ");
                Console.WriteLine("1. -> Ver libros disponibles ");
                Console.WriteLine("2. -> Comprar un libro ");
                Console.WriteLine("3. -> Obtener informacion de un libro ");
                Console.WriteLine("4. -> Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                int eleccion;
                switch (opcion)
                
                {
                    case 1:
                        listalibros.LibrosDisponibles();
                        break;
                    case 2:
                        Console.WriteLine("***Sistema de compras de libros***");
                        break;
                }

            } while (opcion != 4);


        }
    }
}
