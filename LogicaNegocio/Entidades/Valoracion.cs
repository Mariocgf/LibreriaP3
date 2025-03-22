using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Valoracion
    {
        public string Comentario { get; set; }
        public int Puntuacion { get; set; }
        public int Alias { get; set; }
        public string Lineas { get; set; }
        public Valoracion(string comentario, int puntuacion, int alias, string lineas)
        {
            Comentario = comentario;
            Puntuacion = puntuacion;
            Alias = alias;
            Lineas = lineas;
            Validate();
        }
        public void Validate()
        {
            if (string.IsNullOrEmpty(Comentario))
            {
                throw new ArgumentException("El comentario de la valoración no puede ser nulo o vacío");
            }
            if (Puntuacion < 0 || Puntuacion > 5)
            {
                throw new ArgumentException("La puntuación de la valoración debe estar entre 0 y 5");
            }
            if (Alias < 0)
            {
                throw new ArgumentException("El alias de la valoración no puede ser negativo");
            }
            if (string.IsNullOrEmpty(Lineas))
            {
                throw new ArgumentException("Las líneas de la valoración no pueden ser nulas o vacías");
            }
        }
    }
}
