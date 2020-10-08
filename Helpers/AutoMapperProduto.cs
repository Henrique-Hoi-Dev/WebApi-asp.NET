using AutoMapper;
using WebApi.Entities;
using WebApi.Models.Produtos;

namespace WebApi.Helpers
{
    public class AutoMapperProduto : Profile
    {
        public AutoMapperProduto()
        {
            CreateMap<Produto, ProdutoModel>();
            CreateMap<RegisterModel, Produto>();
            CreateMap<UpdateModel, Produto>();
        }
    }
}