using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Services
{
    public interface IProdutoService
    {

        Produto GetById(int id);
        IEnumerable<Produto> GetAll();
        void Create(Produto produto, string name);
        void Update(Produto produto, string name);
        void Delete(int id);
    }

    public class ProdutoService : IProdutoService
    {
        private DataContext _context;

        public ProdutoService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Produtos;
        }


    public Produto GetById(int id)
        {
            return _context.Produtos.Find(id);
        }

        public void Create(Produto produto, string name)
        {

            _context.Produtos.Add(produto);
            _context.SaveChanges();

            Console.WriteLine($"Total Registro(s): {produto}");
            
        }

        public void Update(Produto produtoParam, string name)
        {
            var produto = _context.Produtos.Find(produtoParam.Id);

            // update user properties if provided 
            // atualize as propriedades do produto, se fornecidas

            if (!string.IsNullOrWhiteSpace(produtoParam.Name))
                produtoParam.Name = produtoParam.Name;

            if (!string.IsNullOrWhiteSpace(produtoParam.Categoria))
                produtoParam.Categoria = produtoParam.Categoria;

            if (!string.IsNullOrWhiteSpace(produtoParam.Altura))
                produtoParam.Altura = produtoParam.Altura;

            if (!string.IsNullOrWhiteSpace(produtoParam.Largura))
                produtoParam.Largura = produtoParam.Largura;
                
            if (!string.IsNullOrWhiteSpace(produtoParam.Comprimento))
                produtoParam.Comprimento = produtoParam.Comprimento;

            if (!string.IsNullOrWhiteSpace(produtoParam.CodigoBarras))
                produtoParam.CodigoBarras = produtoParam.CodigoBarras;
    
            if (!string.IsNullOrWhiteSpace(produtoParam.Peso))
                produtoParam.Peso = produtoParam.Peso;

            if (!string.IsNullOrWhiteSpace(produtoParam.Preco))
                produtoParam.Preco = produtoParam.Preco;
                
            if (!string.IsNullOrWhiteSpace(produtoParam.Descricao))
                produtoParam.Descricao = produtoParam.Descricao;    
    
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
            }
        }
  
    }
}