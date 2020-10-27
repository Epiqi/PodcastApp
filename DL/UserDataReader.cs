using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class UserDataReader : GeneralReader<FeedSamling>
    {
        public UserDataReader()
        {

        }

        public override FeedSamling Read()
        {
            return GetPodcasts();
        }

        public FeedSamling GetPodcasts()
        {
            FeedSamling feeds = new FeedSamling();
            return feeds.Deserialize();
        }
    }
}
