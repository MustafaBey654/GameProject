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
    public class GameManager : IGamesService
    {
        private readonly IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Add(Game entity)
        {
            _gameDal.Add(entity);
        }

        public void Delete(Game entity)
        {
            _gameDal.Delete(entity);
        }

        public List<Game> GetAll()
        {
           return _gameDal.GetAll();
        }

        public void Update(Game entity)
        {
            _gameDal.Update(entity);
        }
    }
}
