using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DL.Repositories
{
    public class KategoriRepository : IRepository<Kategori>
    {

        DataManager dataManager;
        List<Kategori> kategorier;
        public KategoriRepository()
        {
            kategorier = new List<Kategori>();
            dataManager = new DataManager();
            kategorier = GetAll();
        }

        public void Create(Kategori entity)
        {
            kategorier.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            kategorier.RemoveAt(index);
            SaveChanges();
        }

        public List<Kategori> GetAll()
        {
            List<Kategori> savedKategorier = new List<Kategori>();
            try
            {
                savedKategorier = dataManager.KategoriDeserialize();
            }
            catch (Exception ex)
            {

            }

            return savedKategorier;
        }

        public void SaveChanges()
        {
            dataManager.Serialize(kategorier);
        }

        public void Update(int index, Kategori entity)
        {
            if (index >= 0)
            {
                kategorier[index] = entity;
            }
            SaveChanges();
        }


    }
}
