using ArtistasDAL.Entities;
using ArtistasDAL.Entities.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtistasDAL.Context.Repositorios
{
    //herda de repository e implementa a classe especifica
    public class ArtistaRepository : Repository<Artista>, IArtistaRepository
    {
        public ArtistaRepository(ArtistaContext context) : base(context)
        {
        }

        public Artista getArtistaComDetalhes(int? id)
        {
            return ArtistaContext.Artistas.Include(a => a.ArtistaDetalhes)
                .SingleOrDefault(a => a.ArtistaId == id);
        }

        public ArtistaContext ArtistaContext
        {
            get { return Context as ArtistaContext; }
        }
    }
}
