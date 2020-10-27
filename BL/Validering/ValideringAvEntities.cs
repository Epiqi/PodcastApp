using BL.Validering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Validering
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
            // hämta lista och jämför?
            bool korrekt = true;
            if (!korrekt)
            {
                throw new UserException("Ingen kategori är vald");
            }
            return korrekt;
        }

        public static bool KorrektNamn(string ettNamn)
        {
            // hämta lista och jämför så inte namnet finns redan?
            bool korrekt = true;
            if (!korrekt)
            {
                throw new UserException("Namnet du valt används redan");
            }
            return korrekt;
        }


        private static void VisaMeddelande(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

    }
}
