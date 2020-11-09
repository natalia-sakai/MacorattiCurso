using System;
using System.Collections.Generic;
using System.Text;

namespace ArtistasDAL.Entities.Repositorio
{
    public interface IArtistaRepository : IRepository<Artista>
    {
        Artista getArtistaComDetalhes(int? id);
    }
}
