using System;
using System.Collections.Generic;
using System.Text;

namespace ArtistasDAL.Entities.Repositorio
{
    public interface IArtistaDetalheRepository : IRepository<ArtistaDetalhe>
    {
        IEnumerable<ArtistaDetalhe> GetDetalhesComArtistas(int pageIndex, int pageSize);
    }
}
