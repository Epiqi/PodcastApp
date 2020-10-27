using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Validering
{
    [Serializable]
    public class UserException : Exception
    {
        public UserException(string meddelande)
            : base(meddelande)
        {}
    }
}
