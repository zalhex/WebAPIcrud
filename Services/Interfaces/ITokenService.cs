using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIcrud.Models;

namespace WebAPIcrud.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(Usuario usuario);
    }
}
