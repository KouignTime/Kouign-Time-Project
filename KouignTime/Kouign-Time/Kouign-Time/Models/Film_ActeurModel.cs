using System;

namespace Kouign_Time.Models
{
    public class Film_ActeurModel
    {
        public ActeurModel unActeur { get; set; }
        public FilmModel unFilm { get; set; }
        public String NomPerssonage { get; set; }
    }
}