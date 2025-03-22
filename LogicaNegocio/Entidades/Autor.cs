using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        private static int _ultimoId = 0;
        public string Nombre { get; set; }
        public Pais Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime? FechaDefuncion { get; set; }

        public Autor(string nombre, Pais nacionalidad, DateTime fechaNacimiento, DateTime fechaDefuncion)
        {
            Id = ++_ultimoId;
            Nombre = nombre;
            Nacionalidad = nacionalidad;
            FechaNacimiento = fechaNacimiento;
            FechaDefuncion = fechaDefuncion;
            Validate();
        }
        public void Validate()
        {
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new ArgumentException("El nombre del autor no puede ser nulo o vacío");
            }
            if (Nacionalidad == null)
            {
                throw new ArgumentException("La nacionalidad del autor no puede ser nula");
            }
            if (FechaNacimiento == null)
            {
                throw new ArgumentException("La fecha de nacimiento del autor no puede ser nula");
            }
            if (FechaDefuncion != null && FechaDefuncion < FechaNacimiento)
            {
                throw new ArgumentException("La fecha de defunción no puede ser anterior a la fecha de nacimiento");
            }
        }
    }
}
