﻿using BL.Validering;
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
        private readonly RSSReader reader = new RSSReader();
        private readonly FeedRepository feed = new FeedRepository();

        public FeedController()
        {

        }

        public async void SkapaFeedObjekt(string namn, string url, string frekvens, string kategori)
        {
            try
            {
                Feed pod = await reader.ReadPodcastRSS(url);
                pod.Namn = namn;
                pod.Kategorier = kategori;
                pod.UppdateringsTid = frekvens;
                feed.Create(pod);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("URL-fel");

            }


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

        public void ChangeKategori(string kategori, string old)
        {
            feed.ChangeKategori(kategori, old);
        }

        public void DeleteByKategori(string kategori)
        {

            List<Feed> feedDelete = new List<Feed>();
            for (int i = 0; i < feed.GetAll().Count; i++)
            {
                if (string.Equals(feed.GetAll()[i].Kategorier, kategori, StringComparison.OrdinalIgnoreCase))
                    feedDelete.Add(feed.GetAll()[i]);
            }
            foreach (Feed f in feedDelete)
            {
                DeleteFeed(f.Url);

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

        public List<Feed> GetAllExceptThisOne(string url)
        {
            return (from Feed feed in feed.GetAll()
                    where !string.Equals(feed.Url, url, StringComparison.OrdinalIgnoreCase)
                    select feed).ToList();
        }

        public void UpdateFeed(string url)
        {
            GetFeed(url).NestaUppdatering = DateTime.Now.AddMinutes(Int32.Parse(GetFeed(url).UppdateringsTid));
            Feed ny = GetFeed(url);
            DeleteFeed(url);
            SkapaFeedObjekt(ny.Namn, ny.Url, ny.UppdateringsTid, ny.Kategorier);
            feed.SaveChanges();
        }
        public void BehovsFeedsUppdatera()
        {
            
            foreach (Feed pod in feed.GetAll())
            {
                
                if (pod.BehovsUpdatera)
                {
                    
                    UpdateFeed(pod.Url);
                   
                    
                }
            }

           
        }

    }
}
