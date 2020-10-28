using DL;
using DL.Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Controllers
{
    public class FeedController
    {
        RSSReader reader = new RSSReader();
        FeedRepository feed = new FeedRepository();

        public FeedController()
        {

        }

        public async void SkapaFeedObjekt(string namn, string url, string frekvens, string kategori)
        {
            Feed pod = await reader.ReadPodcastRSS(url);
            pod.Namn = namn;
            pod.Kategorier = kategori;
            pod.UppdateringsTid = Int32.Parse(frekvens);
            feed.Create(pod);
        }

        public Feed GetFeed(string namn)
        {
            foreach (Feed f in feed.GetAll())
            {
                if (f.Namn.ToLower() == namn.ToLower())
                    return f;
            }
            return null;
        }
    }
}
