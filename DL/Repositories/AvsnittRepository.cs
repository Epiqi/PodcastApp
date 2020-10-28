using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DL.Repositories
{
    public class AvsnittRepository : IRepository<Avsnitt>
    {
        DataManager dataManager;
        List<Avsnitt> avsnitt;

        public AvsnittRepository()
        {
            avsnitt = new List<Avsnitt>();
            dataManager = new DataManager();
            avsnitt = GetAll();
        }

        public void Create(Avsnitt entity)
        {
            avsnitt.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {

        }

        public List<Avsnitt> GetAll()
        {
            List<Avsnitt> savedFeeds = new List<Avsnitt>();
            try
            {
                savedFeeds = dataManager.AvsnittDeserialize();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return savedFeeds;
        }

        public void SaveChanges()
        {
            dataManager.Serialize(avsnitt);
        }

        public void Update(int index, Avsnitt entity)
        {
            if (index >= 0)
            {
                avsnitt[index] = entity;
            }
            SaveChanges();
        }

    }
}
