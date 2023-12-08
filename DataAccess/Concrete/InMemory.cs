using Entities.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemory
    {
        public List<Game> GetGames;
        public List<Gamer> GetGamers;
        public List<Company> GetCompanies;

        public InMemory()
        {
            GetGames = new List<Game>();
            GetGamers = new List<Gamer>();
            GetCompanies = new List<Company>();
        }
    }
}
