using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Libro : Publicacion
    {
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public Libro(Tema tema, double precioSugerido, Editorial editorial, int cantPag, DateTime fechaPublicacion, string portadaIMG, int stock, int stockMinimo, string titulo, string isbn) : base(tema, precioSugerido, editorial, cantPag, fechaPublicacion, portadaIMG, stock, stockMinimo)
        {
            Titulo = titulo;
            ISBN = isbn;
            Validate();
        }
        public void Validate()
        {
            if (string.IsNullOrEmpty(Titulo))
            {
                throw new ArgumentException("El título del libro no puede ser nulo o vacío");
            }
            if (string.IsNullOrEmpty(ISBN))
            {
                throw new ArgumentException("El ISBN del libro no puede ser nulo o vacío");
            }
            
        }
    }
}
