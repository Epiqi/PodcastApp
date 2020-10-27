using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entities.Interfaces;

namespace Entities
{
    public class FeedSamling : List<Feed>, ISerialize<FeedSamling>
    {
        public FeedSamling()
        {

        }
        public FeedSamling Deserialize()
        {
            FeedSamling attReturnera;
            XmlSerializer serializer = new XmlSerializer(typeof(FeedSamling));
            using (FileStream streamIn = new FileStream("podcast.xml", FileMode.Open, FileAccess.Read))
            {
                attReturnera = (FeedSamling)serializer.Deserialize(streamIn);
            }
            return attReturnera;
        }

        public void CreateFileIfNeeded(string filename)
        {
            if (!File.Exists(filename))
            {
                File.Create(filename);
            }
        }

        public void Serialize()
        {
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            using (FileStream streamUt = new FileStream("podcast.xml", FileMode.Append, FileAccess.Write))
            {
                serializer.Serialize(streamUt, this);
            }
        }

        public override bool Equals(object obj)
        {
            FeedSamling podcasts = obj as FeedSamling;
            if (podcasts == null || this == null)
                return false;
            if (podcasts.Count != this.Count)
                return false;

            for (int i = 0; i < this.Count; i++)
            {
                if (!this[i].Equals(podcasts[i]))
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
