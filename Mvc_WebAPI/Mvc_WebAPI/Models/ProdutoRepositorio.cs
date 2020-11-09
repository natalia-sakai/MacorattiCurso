using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_WebAPI.Models
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> produtos = new List<Produto>();
        private int _nextid = 1;

        public ProdutoRepositorio()
        {
            Add(new Produto { Nome = "Lapis", Categoria = "Escolar", Preco = 1.99M });
            Add(new Produto { Nome = "Bolacha", Categoria = "Alimentos", Preco = 1.99M });
            Add(new Produto { Nome = "Suco", Categoria = "Bebidas", Preco = 1.99M });
            Add(new Produto { Nome = "Panela", Categoria = "Cozinha", Preco = 1.99M });
            Add(new Produto { Nome = "PC", Categoria = "Eletronicos", Preco = 1.99M });
        }
        public Produto Add(Produto item)
        {
            if(item == null)
            {
                throw new ArgumentException("item");
            }
            item.Id = _nextid++;
            produtos.Add(item);
            return item;
            
        }

        public Produto Get(int id)
        {
            return produtos.Find(p => p.Id == id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return produtos;   
        }

        public void Remove(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentException("item");
            }
            //localiza produto com id igual ao passaado por parametro
            int index = produtos.FindIndex(p => p.Id == item.Id);
            if(index == -1)
            {
                return false;
            }
            produtos.RemoveAt(index);
            produtos.Add(item);
            return true;
        }
    }
}
