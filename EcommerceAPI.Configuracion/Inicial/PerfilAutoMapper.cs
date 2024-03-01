using AutoMapper;
using EcommerceAPI.Comunes.Classes.Contracts.Ecommerce;
using EcommerceAPI.Infraestructura.Database.Entities;

namespace EcommerceAPI.Configuracion.Inicial
{
    public class PerfilAutoMapper : Profile
    {
        public PerfilAutoMapper()
        {
            //usamos este si tenemos los mismos parámetros en la entidad y en el contract
            CreateMap<ClienteEntity, ClienteContract>().ReverseMap();
            //si son distintos usamos este
            //CreateMap<ClienteContract, ClienteEntity>()//MapFRom son los atributos del entity y Form Member es el contrato
            //        .ForMember(dest => dest.id_cliente, opt => opt.MapFrom(src => src.id_cliente))
            //        .ForMember(dest => dest.nombre, opt => opt.MapFrom(src => src.nombre))
            //        .ForMember(dest => dest.cedula, opt => opt.MapFrom(src => src.cedula))
            //        .ForMember(dest => dest.coorreo, opt => opt.MapFrom(src => src.coorreo))
            //       .ForMember(dest => dest.direccion, opt => opt.MapFrom(src => src.direccion))
            //        .ForMember(dest => dest.telefono, opt => opt.MapFrom(src => src.telefono)).ReverseMap();

        }
    }
}
