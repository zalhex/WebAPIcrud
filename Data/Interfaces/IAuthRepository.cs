using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIcrud.Models;

namespace WebAPIcrud.Data.Interfaces
{
    public interface IAuthRepository
    {
        Task<Usuario> Register(Usuario usuario, string password);
        Task<Usuario> Login(string correo, string password);
        Task<bool> UserExists(string Correo);
    }
}
