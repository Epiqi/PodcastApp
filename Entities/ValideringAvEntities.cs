using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public abstract class ValideringAvEntities
    {
        public bool korrekt;

        public static bool KorrektURL(string urlAdress)
        {
            Uri uriResult;
            bool korrekt = Uri.TryCreate(urlAdress, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!korrekt)
            {
                System.Windows.Forms.MessageBox.Show("Felaktig URL");
            }
            return korrekt;
        }

        public static bool KorrektKategori(string enKategori)
        {
            throw new NotImplementedException();
        }
        // throw exceptions med meddelanden till användaren
    }
}
