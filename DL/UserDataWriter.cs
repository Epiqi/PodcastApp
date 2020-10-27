using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class UserDataWriter
    {
        public UserDataWriter()
        {

        }

        public void WritePodcasts(FeedSamling feeds)
        {
            feeds.Serialize();
        }


    }
}
