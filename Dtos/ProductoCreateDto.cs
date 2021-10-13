using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIcrud.Dtos
{
    public class ProductoCreateDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public bool Activo { get; set; }

        public ProductoCreateDto()
        {
            FechaDeAlta = DateTime.Now;
            Activo = true;
        }
    }
}
