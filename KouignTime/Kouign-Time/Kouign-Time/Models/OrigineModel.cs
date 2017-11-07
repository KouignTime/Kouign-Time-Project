using System;

namespace Kouign_Time.Models
{
    public class OrigineModel
    {
        public int IDOrigine { get; set; }
        public String Pays { get; set; }
        public String Drapeau { get; set; }
        public LangueModel uneLangue { get; set; }
    }
}