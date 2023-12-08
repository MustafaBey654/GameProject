using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Gamer:IEntity
    {
        public int IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime GamerDateOfBirth { get; set; }


    }
}
