using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Configuracion.Inicial
{
    public class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper()
        {
            // Si son los mismos nombres de los parametros
            // CreateMap<ClienteEntity, ClienteContract>().ReverseMap();

            CreateMap<ClienteEntity, ClienteContract>()
                    .ForMember(dest => dest.id_cliente, opt => opt.MapFrom(src => src.cedula_cliente))
                    .ForMember(dest => dest.nombre, opt => opt.MapFrom(src => src.nombre_cliente))
                    .ForMember(dest => dest.contrasena, opt => opt.MapFrom(src => src.contrasena_cliente))
                    .ForMember(dest => dest.correo, opt => opt.MapFrom(src => src.correo_cliente))
                    .ForMember(dest => dest.direccioncliente, opt => opt.MapFrom(src => src.direccion_cliente))
                    .ForMember(dest => dest.telefono, opt => opt.MapFrom(src => src.telefono_cliente))
                    .ReverseMap();

            CreateMap<ProductoEntity, ProductoContract>().ReverseMap();

        }
    }
}
