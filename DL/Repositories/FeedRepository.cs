using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Entities;



namespace DL.Repositories
{
    public class FeedRepository : IRepository<Feed>
    {
        DataManager dataManager;
        List<Feed> feeds;
        public FeedRepository()
        {
            feeds = new List<Feed>();
            dataManager = new DataManager();

            feeds = GetAll();
        }

        public void Create(Feed entity)
        {
            feeds.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            feeds.RemoveAt(index);
            SaveChanges();
        }

        public void ChangeKategori(string nyKat, string oldKat)
        {
            foreach (Feed feed in feeds)
                if (feed.Kategorier == oldKat)
                    feed.Kategorier = nyKat;

            SaveChanges();
        }

        public List<Feed> GetAll()
        {
            List<Feed> savedFeeds = new List<Feed>();
            try
            {
                savedFeeds = dataManager.Deserialize();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return savedFeeds;
        }

        public void SaveChanges()
        {
            dataManager.Serialize(feeds);
        }

        public void Update(int index, Feed entity)
        {
            if (index >= 0)
            {
                feeds[index] = entity;
            }
            SaveChanges();
        }

    }
}
