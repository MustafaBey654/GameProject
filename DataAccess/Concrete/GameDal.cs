using DataAccess.Abstracts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GameDal : IGameDal
    {
        private readonly InMemory _inMemory;

        public GameDal(InMemory inMemory)
        {
            _inMemory = inMemory;
        }

        public void Add(Game entity)
        {
          _inMemory.GetGames.Add(entity);
        }

        public void Delete(Game entity)
        {
            _inMemory.GetGames.Remove(entity);
        }

        public List<Game> GetAll()
        {
            return _inMemory.GetGames;
        }

        public void Update(Game entity)
        {
            var game = _inMemory.GetGames.Where(g => g.GameId == entity.GameId).SingleOrDefault();
            if (game != null)
            {
                _inMemory.GetGames.Remove(game);
                _inMemory.GetGames.Add(entity);
            }
        }
    }
}
