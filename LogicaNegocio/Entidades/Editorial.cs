using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Editorial
    {
        public int Id { get; set; }
        private static int s_ultimoId = 0;
        public string Nombre { get; set; }
        public Pais PaisOrigen { get; set; }
        public Editorial(string nombre, Pais paisOrigen)
        {
            Id = ++s_ultimoId;
            Nombre = nombre;
            PaisOrigen = paisOrigen;
            Validate();
        }
        public void Validate()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new ArgumentException("El nombre de la editorial no puede ser nulo o vacío");
            }
            if (PaisOrigen == null)
            {
                throw new ArgumentException("El país de origen de la editorial no puede ser nulo");
            }
        }
    }
}
