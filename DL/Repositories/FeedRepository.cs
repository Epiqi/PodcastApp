using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
