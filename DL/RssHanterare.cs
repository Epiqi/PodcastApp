using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;

namespace DL
{
    public class RssHanterare
    {
        public static void prov(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            Console.WriteLine("--- Title:" + feed.Title.Text);
            Console.WriteLine("--- Desctription:" + feed.Description.Text);
            foreach (SyndicationItem item in feed.Items)
            {
                Console.WriteLine(item.Title.Text);
                Console.WriteLine("->" + item.Summary.Text);
            }
        }

    }

    
}
