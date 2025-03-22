using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Tema
    {
        public int Id { get; set; }
        private static int s_ultimoId = 0;
        public string Nombre { get; set; }
        public Tema(string nombre)
        {
            Id = ++s_ultimoId;
            Nombre = nombre;
            Validate();
        }
        public void Validate()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new ArgumentException("El nombre del tema no puede ser nulo o vacío");
            }
        }
    }
}
