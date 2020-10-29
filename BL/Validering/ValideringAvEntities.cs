using BL.Validering;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace BL.Validering
{
    public class ValideringAvEntities 
    {
        public ValideringAvEntities()
        {
                
        }

        public bool KorrektURL(string urlAdress)
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

        public bool EndastEnURL(List<Feed> allaFeeds, string url) 
        {
            bool korrekt = true;
            foreach (Feed feed in allaFeeds)
            {
                if(string.Equals(url, feed.Url, StringComparison.OrdinalIgnoreCase))
                    {
                    korrekt = false;
                    }
            }

            return korrekt;
        }

        public bool EnFrekvensArVald(string frekvens) 
        {
            bool korrekt = Int32.TryParse(frekvens, out int frekvensArVald);
            if (!korrekt)
            {
                throw new UserException("Ingen frekvens är vald");
            }
            return korrekt;
        }
        public bool KorrektKategori(List<Feed> allaFeeds, string kategori)
        {
            // hämta lista och jämför?
            bool korrekt = true;
            if (!korrekt)
            {
                throw new UserException("Ingen kategori är vald");
            }
            return korrekt;
        }


        public bool EndastEttNamn(List<Feed> allaFeeds, string namn)
        {
            bool korrekt = true;
            foreach (Feed feed in allaFeeds)
            {
                if (string.Equals(namn, feed.Namn, StringComparison.OrdinalIgnoreCase))
                {
                    korrekt = false;
                    throw new UserException("Namnet du valt används redan");
                }
            }

            return korrekt;
        }


        private void VisaMeddelande(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

    }
}
