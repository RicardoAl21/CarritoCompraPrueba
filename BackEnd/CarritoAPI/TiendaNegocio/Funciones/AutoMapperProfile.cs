using AutoMapper;
using Tienda.Negocio.DTO;
using Tienda.Repositorio.Modelos;

namespace Tienda.Negocio.Funciones
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UsuarioDTO,Usuario>().ReverseMap();
            CreateMap<OrdenDTO, Ordenes>().ReverseMap();
            CreateMap<ProductoDTO, Producto>().ReverseMap();
            CreateMap<DetCompraDTO, DetalleCompra>().ReverseMap();
            CreateMap<CarritoDTO, Carrito>().ReverseMap();
        }
    }
}
