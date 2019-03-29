using AutoMapper;
using Generales.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ventura.API.Dtos.Generales;

namespace Ventura.API.Helpers
{
    public class AuthoMapperProfilesGenerales : Profile
    {
        public AuthoMapperProfilesGenerales()
        {
            CreateMap<Producto, ProductoToReturnDTO>()
            .ForMember(dest => dest.Clasificacion, opt => {
                opt.MapFrom(src => src.Clasificacion.Descripcion);

            });


            CreateMap<ProductoForCreationDTO, Producto>().ReverseMap();
         

        }

    }
}