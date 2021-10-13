using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIcrud.Dtos
{
    public class UsuarioRegisterDto
    {
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public bool Activo { get; set; }
        public UsuarioRegisterDto()
        {
            FechaDeAlta = DateTime.Now;
            Activo = true;
        }
    }
}
