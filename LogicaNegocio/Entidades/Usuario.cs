using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public enum Rol
    {
        Gerente,
        Vendedor,
        Cliente
    }
    public class Usuario
    {
        public int Id { get; set; }
        private static int _ultimoId = 0;
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public Rol RolUsuario { get; set; }
        public Usuario(string nombreUsuario, string password, Rol rolUsuario)
        {
            Id = ++_ultimoId;
            NombreUsuario = nombreUsuario;
            Password = password;
            RolUsuario = rolUsuario;
            Validate();
        }
        public void Validate()
        {
            if (string.IsNullOrEmpty(NombreUsuario))
            {
                throw new ArgumentException("El nombre de usuario no puede ser nulo o vacío");
            }
            if (string.IsNullOrEmpty(Password))
            {
                throw new ArgumentException("La contraseña no puede ser nula o vacía");
            }
        }
    }
}
