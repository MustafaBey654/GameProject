using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GamerManager : IGamerService
    {
        private readonly IGamerDal _gamerDal;

        public GamerManager(IGamerDal gamerDal)
        {
            _gamerDal = gamerDal;
        }

        public void Add(Gamer entity)
        {
            _gamerDal.Add(entity);
        }

        public void Delete(Gamer entity)
        {
           _gamerDal.Delete(entity);
        }

        public List<Gamer> GetAll()
        {
           return _gamerDal.GetAll();
        }

        public void Update(Gamer entity)
        {
            _gamerDal.Update(entity);
        }
    }
}
