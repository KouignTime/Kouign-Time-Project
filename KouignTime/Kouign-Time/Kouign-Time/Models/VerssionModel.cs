using System;

namespace Kouign_Time.Models
{
    public class VerssionModel
    {
        public int IDVerssion { get; set; }
        public LangueModel uneLangue { get; set; }
        public QualitéAudioModel uneQualitéAudio { get; set; }
        public QualitéVidéoModel uneQualitéVidéo { get; set; }
        public bool VerssionLongue { get; set; }
        public int Durée { get; set; }
        public DateTime DateSortie { get; set; }
        public TorrentModel unTorrent { get; set; }
        public DateTime DateAjout { get; set; }
    }
}