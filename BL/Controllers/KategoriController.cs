using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using DL.Repositories;
using Entities;

namespace BL.Controllers
{
    public class KategoriController
    {
        private readonly RSSReader reader = new RSSReader();
        private readonly KategoriRepository kategori = new KategoriRepository();
        FeedController feedController = new FeedController();
        
        public KategoriController()
        {
            

        }

        public void SkapaKategoriObjekt(string namn)
        {
            Kategori nyKategori = new Kategori();
            nyKategori.Namn = namn;
            kategori.Create(nyKategori);

        }

        public List<Kategori> GetAll()
        {
            return kategori.GetAll();
        }

        public void DeleteKategori(string namn)
        {
            feedController.DeleteByKategori(namn);

            int indexDelete = -1;
            for (int i = 0; i < kategori.GetAll().Count; i++)
            {
                if (string.Equals(kategori.GetAll()[i].Namn, namn, StringComparison.OrdinalIgnoreCase))
                    indexDelete = i;
            }

            if (indexDelete > -1)
                kategori.Delete(indexDelete);


        }

    }

}
