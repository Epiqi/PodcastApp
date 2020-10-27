using BL.Validering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public static class ValideringAvEntities 
    {
        

        public static bool KorrektURL(string urlAdress)
        {
            Uri uriResult;
            bool korrekt = Uri.TryCreate(urlAdress, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!korrekt)
            {
               throw new UserException("URLadressen är inte korrekt");
            }
            return korrekt;
        }

        public static bool EnFrekvensArVald(string frekvens) 
        {
            bool korrekt = Int32.TryParse(frekvens, out int frekvensArVald);
            if (!korrekt)
            {
                throw new UserException("Ingen frekvens är vald");
            }
            return korrekt;
        }
        public static bool KorrektKategori(string enKategori)
        {
            bool korrekt = ??;
            if (!korrekt)
            {
                throw new UserException("Ingen kategori är vald");
            }
            return korrekt;
        }
        
    }
}
