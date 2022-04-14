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
        Player Delete(Player player);   
        Player Update(Player player);

        Player OnePlayer(string name);
        List<Player> EloPlayer();
    }
}
