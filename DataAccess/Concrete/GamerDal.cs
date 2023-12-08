using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GamerDal : IGamerDal
    {
        private readonly InMemory _inMemory;

        public GamerDal(InMemory inMemory)
        {
            _inMemory = inMemory;
        }

        public void Add(Gamer entity)
        {
           _inMemory.GetGamers.Add(entity);
        }

        public void Delete(Gamer entity)
        {
            _inMemory.GetGamers.Remove(entity);
        }

        public List<Gamer> GetAll()
        {
            return _inMemory.GetGamers;
        }

        public void Update(Gamer entity)
        {
            var gamer = _inMemory.GetGamers.FirstOrDefault(g=>g.IdentityNumber == entity.IdentityNumber);
            if (gamer != null)
            {
                gamer.FirstName = entity.FirstName;
                gamer.LastName = entity.LastName;

                _inMemory.GetGamers.Remove(gamer);
                _inMemory.GetGamers.Add(entity);
            }
        }
    }
}
