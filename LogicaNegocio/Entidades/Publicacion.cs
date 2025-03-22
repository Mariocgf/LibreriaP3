using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    abstract class Publicacion
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
    }
}
