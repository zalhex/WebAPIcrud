﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIcrud.Dtos
{
    public class UsuarioLoginDto
    {
        public string Correo { get; set; }
        public string Password { get; set; }
    }
}
