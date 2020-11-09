using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ArtistasDAL.Entities.Repositorio
{
    public interface IRepository<TEntity> where TEntity:class
    {
        //metodos de consulta
        TEntity Get(int? id);
        IEnumerable<TEntity> GetAll();
        //retornar filtrado
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //metodos de adicionar
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        //metodos de remocao
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        //atualizar na memória ???
        void Update(TEntity entity);
    }
}
