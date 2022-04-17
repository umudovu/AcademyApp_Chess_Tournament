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
        public Player OnePlayer(int id)
        {
            return _playerRepository.GetOne(p => p.Id==id);
        }

        public Player Update(string name, Player player)
        {
            player = _playerRepository.GetOne(p => p.Name==name);
            if (player==null)
            {
                return null;
            }
            _playerRepository.Update(player);
            return player;
        }

        public List<Player> AllPlayer()
        {
            return _playerRepository.GetAll();
        }

        public List<Player> PlayerTitle(string title)
        {
            return _playerRepository.GetAll(p=>p.FIDE_titles==title);
        }

        
    }
}
