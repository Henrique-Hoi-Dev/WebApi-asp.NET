using AutoMapper;
using Web.Models.Comentarios;
using WebApi.Entities;

using WebApi.Models.Comentarios;

namespace WebApi.Helpers
{
    public class AutoMapperComentario : Profile
    {
        public AutoMapperComentario()
        {
            CreateMap<Comentario, ComentarioModel>();
            CreateMap<RegisterModel, Comentario>();
            CreateMap<UpdateModel, Comentario>();
            
        }
    }
}