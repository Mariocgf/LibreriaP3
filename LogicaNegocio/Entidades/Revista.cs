using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Revista : Publicacion
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public int Anio { get; set; }
        public string Contenido { get; set; }
        public Revista(Tema tema, double precioSugerido, Editorial editorial, int cantPag, DateTime fechaPublicacion, string portadaIMG, int stock, int stockMinimo, int numero, int anio, string contenido) : base(tema, precioSugerido, editorial, cantPag, fechaPublicacion, portadaIMG, stock, stockMinimo)
        {
            Numero = numero;
            Anio = anio;
            Contenido = contenido;
            Validate();
        }
        public void Validate()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new ArgumentException("El nombre de la revista no puede ser nulo o vacío");
            }
            if (Numero <= 0)
            {
                throw new ArgumentException("El número de la revista no puede ser menor o igual a cero");
            }
            if (Anio <= 0)
            {
                throw new ArgumentException("El año de la revista no puede ser menor o igual a cero");
            }
            if (string.IsNullOrEmpty(Contenido))
            {
                throw new ArgumentException("El contenido de la revista no puede ser nulo o vacío");
            }
        }
    }
}
