using System;
using System.Collections.Generic;
using System.Text;

namespace ArtistasDAL.Entities
{
    public class Artista
    {
        public int ArtistaId { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Site { get; set; }
        public DateTime Nascimento { get; set; }

        //um artista tem muitos detalhes por isso cria uma lista para isso
        public virtual IList<ArtistaDetalhe> ArtistaDetalhes { get; set; }
    }
}
