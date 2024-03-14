using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Configuracion.Inicial
{
    public class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper()
        {
            //si son los mismos nombres de los parametros
            //CreateMap<ClienteEntity, ClienteContract>().ReverseMap();

            // Si los campos tienen diferentes nombres en la BD y en el desarrollo
            CreateMap<ClienteContract, ClienteEntity>()
                    .ForMember(dest => dest.id_cliente, opt => opt.MapFrom(src => src.id_cliente))
                    .ForMember(dest => dest.nombre, opt => opt.MapFrom(src => src.nombre))
                    .ForMember(dest => dest.password, opt => opt.MapFrom(src => src.contrasena))
                    .ForMember(dest => dest.correo, opt => opt.MapFrom(src => src.correo))
                    .ForMember(dest => dest.direccionfacturacion, opt => opt.MapFrom(src => src.direccioncliente))
                    .ForMember(dest => dest.telefono, opt => opt.MapFrom(src => src.telefono))
                    .ReverseMap();




        }
    }
}
