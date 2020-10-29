﻿using DL;
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
        private readonly RSSReader reader = new RSSReader();
        private readonly FeedRepository feed = new FeedRepository();

        public FeedController()
        {

        }

        public async void SkapaFeedObjekt(string namn, string url, string frekvens, string kategori)
        {
            Feed pod = await reader.ReadPodcastRSS(url);
            pod.Namn = namn;
            pod.Kategorier = kategori;
            pod.UppdateringsTid = frekvens;
            feed.Create(pod);
        }

        public Feed GetFeed(string url)
        {

            return feed.GetAll().Where(f => string.Equals(f.Url, url, StringComparison.OrdinalIgnoreCase)).First();

        }

        public List<Feed> GetAll()
        {
            return feed.GetAll();
        }

        public List<Feed> GetAllKategori(string kategori)
        {
            return (feed.GetAll().Where(f => string.Equals(f.Kategorier, kategori, StringComparison.OrdinalIgnoreCase))).ToList();
        }

        public void DeleteByKategori(string kategori)
        {

            List<int> indexDelete = new List<int>();
            for (int i = 0; i < feed.GetAll().Count; i++)
            {
                if (string.Equals(feed.GetAll()[i].Kategorier, kategori, StringComparison.OrdinalIgnoreCase))
                    indexDelete.Add(i);
            }
            foreach (int j in indexDelete)
            {
                feed.Delete(j);
            }
        }

        public void DeleteFeed(string url)
        {
            int indexDelete = -1;
            for (int i = 0; i < feed.GetAll().Count; i++)
            {
                if (string.Equals(feed.GetAll()[i].Url, url, StringComparison.OrdinalIgnoreCase))
                    indexDelete = i;
            }

            if (indexDelete > -1)
                feed.Delete(indexDelete);

        }
    }
}
