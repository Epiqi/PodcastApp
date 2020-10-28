using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using Entities;

namespace DL
{
    public class RSSReader : GeneralReader<Feed>
    {
        public RSSReader()
        {

        }

        public async override Task<Feed> Read(string url)
        {
            return await ReadPodcastRSS(url);
        }

        public async Task<Feed> ReadPodcastRSS(string url)
        {
            Feed podcast = new Feed();
            podcast.Url = url;
            podcast.Avsnitten = new List<Avsnitt>();

            XmlReaderSettings xmlsettings = new XmlReaderSettings();
            xmlsettings.Async = true;

            using (XmlReader reader = XmlReader.Create(url, xmlsettings))
            {
                SyndicationFeed nyFeed = SyndicationFeed.Load(reader);

                podcast.Namn = nyFeed.Title.Text;
                podcast.Beskrivning = nyFeed.Description.Text;

                int counter = 1;


                foreach (SyndicationItem avsn in nyFeed.Items)
                {
                    Avsnitt avsnitt = new Avsnitt();
                    avsnitt.Namn = avsn.Title.Text;
                    if (avsn.Summary != null)
                        avsnitt.Beskrivning = avsn.Summary.Text;
                    avsnitt.Nummer = counter;

                    podcast.Avsnitten.Add(avsnitt);
                    counter++;
                }

            }
            // podcast.Avsnitten = allaAvsnitt;
            return podcast;
        }
    }


}
