using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entities;

namespace DL
{
    internal class DataManager
    {
        public void Serialize(List<Feed> feedList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(feedList.GetType());

            using (FileStream utFile = new FileStream("pod.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(utFile, feedList);
            }
        }

        public List<Feed> Deserialize()
        {
            List<Feed> toBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Feed>));

            using (FileStream inFile = new FileStream("pod.xml", FileMode.Open, FileAccess.Read))
            {
                toBeReturned = (List<Feed>)xmlSerializer.Deserialize(inFile);
            }

            return toBeReturned;
        }

        public void Serialize(List<Kategori> kategoriList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(kategoriList.GetType());

            using (FileStream utFile = new FileStream("pod.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(utFile, kategoriList);
            }
        }

        public List<Kategori> KategoriDeserialize()
        {
            List<Kategori> toBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Kategori>));

            using (FileStream inFile = new FileStream("pod.xml", FileMode.Open, FileAccess.Read))
            {
                toBeReturned = (List<Kategori>)xmlSerializer.Deserialize(inFile);
            }

            return toBeReturned;
        }

        public void Serialize(List<Avsnitt> avsnittList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(avsnittList.GetType());

            using (FileStream utFile = new FileStream("pod.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(utFile, avsnittList);
            }
        }

        public List<Avsnitt> AvsnittDeserialize()
        {
            List<Avsnitt> toBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Avsnitt>));

            using (FileStream inFile = new FileStream("pod.xml", FileMode.Open, FileAccess.Read))
            {
                toBeReturned = (List<Avsnitt>)xmlSerializer.Deserialize(inFile);
            }

            return toBeReturned;
        }
    }
}
