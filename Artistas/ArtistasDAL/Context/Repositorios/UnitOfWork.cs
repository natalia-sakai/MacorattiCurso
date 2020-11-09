using ArtistasDAL.Entities.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtistasDAL.Context.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArtistaContext _context;

        public UnitOfWork(ArtistaContext context)
        {
            _context = context;
            ArtistaDetalhe = new ArtistaDetalheRepository(_context);
            Artistas = new ArtistaRepository(_context);
        }

        public IArtistaRepository Artistas { get; private set; }
        public IArtistaDetalheRepository ArtistaDetalhe { get; private set; }


        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
