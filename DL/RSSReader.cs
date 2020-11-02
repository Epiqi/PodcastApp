using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using Entities;
using System.Text.RegularExpressions;

namespace DL
{
    public class RSSReader : GeneralReader<Feed>
    {
        int counter = 1;
        public RSSReader()
        {

        }

        public  async override Task<Feed> Read(string url)
        {
            return await ReadPodcastRSSAsync(url);
        }

        public async Task<Feed> ReadPodcastRSSAsync(string url)
        {
            Feed podcast = new Feed();
            podcast.Url = url;
            podcast.Avsnitten = new List<Avsnitt>();
            Avsnitt avsnitt = new Avsnitt();

            List<Task<Avsnitt>> taskAvsnitt = new List<Task<Avsnitt>>();

            XmlReaderSettings xmlsettings = new XmlReaderSettings();
            xmlsettings.Async = true;

            using (XmlReader reader = XmlReader.Create(url, xmlsettings))
            {
                SyndicationFeed nyFeed = SyndicationFeed.Load(reader);

                podcast.Namn = nyFeed.Title.Text;
                podcast.Beskrivning = nyFeed.Description.Text;

                


                foreach (SyndicationItem avsn in nyFeed.Items)
                {
                    
                    taskAvsnitt.Add(Task.Run(() => OrdnaAvsnitt(avsn)));
                    
                }

                var arrayAvAvsnitt = await Task.WhenAll(taskAvsnitt);

                podcast.Avsnitten = arrayAvAvsnitt.ToList();
            }
            //podcast.Avsnitten.Add(avsnitt);
            // podcast.Avsnitten = allaAvsnitt;
            return podcast;
        }

        private Avsnitt OrdnaAvsnitt(SyndicationItem avsn)
        {
            Avsnitt avsnitt = new Avsnitt();
            

            avsnitt.Namn = avsn.Title.Text;
            if (avsn.Summary != null)
            {
                avsnitt.Beskrivning = avsn.Summary.Text;
            }
            else
            {
                // För vissa RSS-feeds blir SyndicationItem.Summary null och infon hamnar i .Content istället.
                TextSyndicationContent text = (TextSyndicationContent)avsn.Content;
                avsnitt.Beskrivning = Regex.Replace(text.Text, "<.*?>", String.Empty);
            }
            avsnitt.Nummer = counter;
            counter++;
            return avsnitt;
        }
    }

    
}
