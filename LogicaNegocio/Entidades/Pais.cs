using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Pais
    {
        public int Id { get; set; }
        private static int s_ultimoId = 0;
        public string Nombre { get; set; }
        public Pais(string nombre)
        {
            Id = ++s_ultimoId;
            Nombre = nombre;
        }
    }
}
