using System;

namespace Kouign_Time.Models
{
    public class FilmModel
    {
        public int IDFilm { get; set; }
        public DateTime DateProduction { get; set; }
        public OrigineModel uneOrigine { get; set; }
    }
}