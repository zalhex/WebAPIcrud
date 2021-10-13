using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIcrud.Dtos;
using WebAPIcrud.Models;

namespace WebAPIcrud.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Productos
            CreateMap<ProductoCreateDto, Producto>();
            CreateMap<ProductoUpdateDto, Producto>();
            //Usuarios
            CreateMap<UsuarioRegisterDto, Usuario>();
            CreateMap<UsuarioLoginDto, Usuario>();
            CreateMap<Usuario, UsuarioListDto>();
        }
    }
}
