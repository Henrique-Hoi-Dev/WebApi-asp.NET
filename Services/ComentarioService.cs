using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface IComentarioService
    {

        Comentario GetById(int id);
        IEnumerable<Comentario> GetAll();
        void Create(Comentario descricao, string name);
        void Update(Comentario descricao, string name);
        void Delete(int id);
    }

    public class ComentarioService : IComentarioService
    {
        private DataContext _context;

        public ComentarioService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Comentario> GetAll()
        {
            return _context.Comentarios;
        }


    public Comentario GetById(int id)
        {
            return _context.Comentarios.Find(id);
        }

        public void Create(Comentario descricao, string name)
        {

            _context.Comentarios.Add(descricao);
            _context.SaveChanges();

            Console.WriteLine($"Total Registro(s): {descricao}");
            
        }

        public void Update(Comentario comentarioParam, string name)
        {
            var comentario = _context.Comentarios.Find(comentarioParam.Id);

            // atualize as propriedades do comentario, se fornecidas

            if (!string.IsNullOrWhiteSpace(comentarioParam.Name))
                comentarioParam.Name = comentarioParam.Name;

            _context.Comentarios.Update(comentario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var comentario = _context.Comentarios.Find(id);
            if (comentario != null)
            {
                _context.Comentarios.Remove(comentario);
                _context.SaveChanges();
            }
        }
  
    }
}