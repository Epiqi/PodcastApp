using BL.Validering;
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
        private readonly FeedRepository feedRepository = new FeedRepository();

        public FeedController()
        {

        }

        public async void SkapaFeedObjekt(string namn, string url, string frekvens, string kategori)
        {
            try
            {
                Feed pod = await reader.Read(url);
                pod.Namn = namn;
                pod.Kategorier = kategori;
                pod.UppdateringsTid = frekvens;
                feedRepository.Create(pod);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("URL-fel");

            }


        }

        public Feed GetFeed(string url)
        {
            return feedRepository.GetAll().Where(feed => string.Equals(feed.Url, url, StringComparison.OrdinalIgnoreCase)).First();
        }

        public List<Feed> GetAll()
        {
            return feedRepository.GetAll();
        }

        public List<Feed> GetAllKategori(string kategori)
        {
            return (feedRepository.GetAll().Where(feed => string.Equals(feed.Kategorier, kategori, StringComparison.OrdinalIgnoreCase))).ToList();
        }

        public void ChangeKategori(string kategori, string old)
        {
            feedRepository.ChangeKategori(kategori, old);
        }

        public void DeleteByKategori(string kategori)
        {

            List<Feed> feedDelete = new List<Feed>();
            for (int i = 0; i < feedRepository.GetAll().Count; i++)
            {
                if (string.Equals(feedRepository.GetAll()[i].Kategorier, kategori, StringComparison.OrdinalIgnoreCase))
                    feedDelete.Add(feedRepository.GetAll()[i]);
            }
            foreach (Feed feed in feedDelete)
            {
                DeleteFeed(feed.Url);

            }
        }

        public void DeleteFeed(string url)
        {
            int indexDelete = -1;
            for (int i = 0; i < feedRepository.GetAll().Count; i++)
            {
                if (string.Equals(feedRepository.GetAll()[i].Url, url, StringComparison.OrdinalIgnoreCase))
                    indexDelete = i;
            }

            if (indexDelete > -1)
                feedRepository.Delete(indexDelete);

        }

        public List<Feed> GetAllExceptThisOne(string url)
        {
            return (from Feed feed in feedRepository.GetAll()
                    where !string.Equals(feed.Url, url, StringComparison.OrdinalIgnoreCase)
                    select feed).ToList();
        }

        public void UpdateFeed(string url)
        {
            GetFeed(url).NestaUppdatering = DateTime.Now.AddMinutes(Int32.Parse(GetFeed(url).UppdateringsTid));
            Feed ny = GetFeed(url);
            DeleteFeed(url);
            SkapaFeedObjekt(ny.Namn, ny.Url, ny.UppdateringsTid, ny.Kategorier);
            feedRepository.SaveChanges();
        }
        public void BehovsFeedsUppdatera()
        {
            foreach (Feed pod in feedRepository.GetAll())
            {
                if (pod.BehovsUpdatera)
                {
                    UpdateFeed(pod.Url);
                }
            }
        }

    }
}
