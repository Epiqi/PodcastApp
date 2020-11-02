using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class GeneralReader<T> where T : new()
    {
        public GeneralReader()
        {

        }

        public virtual T ReadPodcastRSS()
        {
            T obj = new T();
            return obj;
        }

        public virtual Task<T> ReadPodcastRSSAsync(string url)
        {
            return null;
        }
    }
}
