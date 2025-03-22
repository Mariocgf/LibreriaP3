using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Compra
    {
        public int Id { get; set; }
        private static int _ultimoId = 0;
        private List<PublicacionComprada> _publicacionesComprada = new List<PublicacionComprada>();
        public Usuario Cliente { get; set; }
        public Compra(Usuario cliente)
        {
            Id = ++_ultimoId;
            Cliente = cliente;
            Validate();
        }
        public void Validate()
        {
            if (Cliente == null)
            {
                throw new ArgumentException("El cliente de la compra no puede ser nulo");
            }
        }
    }
}
