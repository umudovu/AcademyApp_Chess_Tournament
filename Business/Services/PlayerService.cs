using Business.Interfaces;
using DataAccess.Repository;
using Entities.Models;
using System.Collections.Generic;
using Utilities.Helper;

namespace Business.Services
{
    public class PlayerService : IPlayer
    {
        public static int Count { get; set; }
        private PlayerRepository _playerRepository;

        public PlayerService()
        {
            _playerRepository=new PlayerRepository();
        }




        public Player Creat(Player player)
        {
            Count++;
            player.Id=Count;
            player.FIDE_titles=player.Rating.Check();
            _playerRepository.Create(player);
            return player;
        }

        public Player Delete(int id)
        {
            Player IsExsist = _playerRepository.GetOne(p => p.Id==id);
            if (IsExsist==null)
            {
                return null;
            }
            _playerRepository.Delete(IsExsist);
            return IsExsist;
        }

        public List<Player> EloPlayer(int elomin, int elomax)
        {
            return _playerRepository.GetAll(p => p.Rating>=elomin && p.Rating<=elomax);
        }

        public Player OnePlayer(string name)
        {
            return _playerRepository.GetOne(p => p.Name==name);
        }

        public Player Update(string name, Player player)
        {
            Player Exsist = _playerRepository.GetOne(p => p.Name==name);
            if (Exsist==null)
            {
                return null;
            }
            _playerRepository.Update(Exsist);
            return Exsist;
        }

        public List<Player> AllPlayer()
        {
            return _playerRepository.GetAll();
        }

     
    }
}
