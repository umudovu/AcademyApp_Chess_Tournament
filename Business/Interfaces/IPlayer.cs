using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IPlayer
    {
        Player Creat(Player player);
        Player Delete(int id);   
        Player Update(string name,Player player);

        Player OnePlayer(string name);
        List<Player> EloPlayer(int elo1,int elo2);

        List<Player> AllPlayer();

    }
}
