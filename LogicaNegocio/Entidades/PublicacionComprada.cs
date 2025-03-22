using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class PublicacionComprada
    {
        public int Cantidad { get; set; }
        public Publicacion PublicacionCom { get; set; }
        public PublicacionComprada (int cantidad, Publicacion publicacionCom)
        {
            Cantidad = cantidad;
            PublicacionCom = publicacionCom;
            Validate();
        }
        public void Validate()
        {
            if (Cantidad <= 0)
            {
                throw new ArgumentException("La cantidad de publicaciones compradas no puede ser menor o igual a cero");
            }
            if (PublicacionCom == null)
            {
                throw new ArgumentException("La publicación comprada no puede ser nula");
            }
        }
    }
}
