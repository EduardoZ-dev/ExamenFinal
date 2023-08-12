using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class ListaLibros
    {
        List<Libro> Libros = new List<Libro>();

        public void LibrosDisponibles()
        {
            foreach (Libro libro in Libros)
            {
                Console.WriteLine("Los libros son: " + libro.ToString());
            }

        }
    }
}
