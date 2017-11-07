using System;

namespace Kouign_Time.Models
{
    public class ActeurModel
    {
        public int IDActeur { get; set; }
        public String NomActeur { get; set; }
        public String PrenomActeur { get; set; }
        public OrigineModel uneOrigine { get; set; }
    }
}