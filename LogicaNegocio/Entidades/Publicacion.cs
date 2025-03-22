using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public abstract class Publicacion
    {
        public int Id { get; set; }
        private static int _ultimoId = 0;
        public Tema Tema { get; set; }
        public double PrecioSugerido { get; set; }
        public Editorial Editorial { get; set; }
        public int CantPag { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string PortadaIMG { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        private List<Autor> _autores = new List<Autor>();
        private List<Valoracion> _valoraciones = new List<Valoracion>();
        public Publicacion(Tema tema, double precioSugerido, Editorial editorial, int cantPag, DateTime fechaPublicacion, string portadaIMG, int stock, int stockMinimo)
        {
            Id = ++_ultimoId;
            Tema = tema;
            PrecioSugerido = precioSugerido;
            Editorial = editorial;
            CantPag = cantPag;
            FechaPublicacion = fechaPublicacion;
            PortadaIMG = portadaIMG;
            Stock = stock;
            StockMinimo = stockMinimo;
            Validate();
        }
        public void Validate()
        {
            if (Tema == null)
            {
                throw new ArgumentException("El tema de la publicación no puede ser nulo");
            }
            if (PrecioSugerido < 0)
            {
                throw new ArgumentException("El precio sugerido de la publicación no puede ser negativo");
            }
            if (Editorial == null)
            {
                throw new ArgumentException("La editorial de la publicación no puede ser nula");
            }
            if (CantPag < 0)
            {
                throw new ArgumentException("La cantidad de páginas de la publicación no puede ser negativa");
            }
            if (FechaPublicacion == null)
            {
                throw new ArgumentException("La fecha de publicación de la publicación no puede ser nula");
            }
            if (string.IsNullOrEmpty(PortadaIMG))
            {
                throw new ArgumentException("La imagen de portada de la publicación no puede ser nula o vacía");
            }
            if (Stock < 0)
            {
                throw new ArgumentException("El stock de la publicación no puede ser negativo");
            }
            if (StockMinimo < 0)
            {
                throw new ArgumentException("El stock mínimo de la publicación no puede ser negativo");
            }
        }
    }
}
