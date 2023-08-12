using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class Libro
    {
        public string Titulo { private set; get; } = string.Empty;
        public int ISBN { private set; get; }
        public string Autor { private set; get; } = string.Empty;
        public double PrecioU { private set; get; }
        public int CantidadStock {private set; get; }

        public Libro(string titulo, int isbn,string autor,double preciou,int cantidadu ) 
        {
         Titulo = titulo;
            ISBN = isbn;
            Autor = autor;
            CantidadStock = cantidadu;
        }
    }
}
