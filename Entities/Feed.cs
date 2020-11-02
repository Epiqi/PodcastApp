using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Feed
    {
        public List<Avsnitt> Avsnitten { get; set; }

        public string Kategorier { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public string Url { get; set; }
        public string UppdateringsTid { get; set; }

        public DateTime NestaUppdatering { get; set; }

        public Feed()
        {
            // Avsnitten = new List<Avsnitt>();

        }

        public bool BehovsUpdatera
        {
            get
            {
                return NestaUppdatering <= DateTime.Now;
            }
        }



    }
}
