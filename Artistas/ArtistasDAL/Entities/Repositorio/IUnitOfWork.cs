using System;
using System.Collections.Generic;
using System.Text;

namespace ArtistasDAL.Entities.Repositorio
{
    public interface IUnitOfWork : IDisposable
    {
        IArtistaRepository Artistas { get; }

        IArtistaDetalheRepository ArtistaDetalhe { get; }

        int Commit();
    }
}
