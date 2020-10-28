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
            //   pod.Namn = namn;
            pod.Kategorier = kategori;
            pod.UppdateringsTid = frekvens;
            feed.Create(pod);
        }

        public Feed GetFeed(string url)
        {
            foreach (Feed f in feed.GetAll())
            {
                if (f.Url.ToLower() == url.ToLower())
                    return f;
            }
            return null;
        }

        public List<Feed> GetAll()
        {
            return feed.GetAll();
        }

        public List<Feed> GetAllKategori(string kategori)
        {
            List<Feed> feedsReturn = new List<Feed>();
            foreach (Feed f in feed.GetAll())
            {
                if (f.Kategorier.ToLower() == kategori.ToLower())
                    feedsReturn.Add(f);
            }
            return feedsReturn;
        }

        public void DeleteByKategori(string kategori)
        {

            List<int> indexDelete = new List<int>();
            for (int i = 0; i < feed.GetAll().Count; i++)
            {
                if (feed.GetAll().ElementAt(i).Kategorier.ToLower() == kategori.ToLower())
                    indexDelete.Add(i);
            }
            foreach (int j in indexDelete)
            {
                feed.Delete(j);
            }
        }
    }
}
