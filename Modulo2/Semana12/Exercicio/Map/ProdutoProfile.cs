using AutoMapper;
using Ex1.DTOs;
using Ex1.Models;

namespace Ex1.Map
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile()
        {
            CreateMap<Produto, ProdutoDTO>().ReverseMap();
        }
    }
}
