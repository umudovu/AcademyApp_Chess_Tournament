using Business.Services;
using DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;
using Utilities.Interfaces;

namespace AcademyApp_Chess_Tournament.Controller
{
    public class GameConroller : IStruggle
    {
        public PlayerService playerService = new PlayerService();
        public int Size()
        {
            int size = DataContext.Players.Count;
            if (size%2==1)
            {
                size-=1;
            }
            return size;
        }
	
        public async void Plays()
        {
            List<Player> players = playerService.AllPlayer();

            for (int i = 0; i < Size()-1; i++)
            {
                Extentions.Print(ConsoleColor.Yellow,
                    $"{i+1}. table plays: \n"+
                    $"White- {players[i].FIDE_titles} {players[i].Name } {players[i].Surname} {players[i].Rating} \n" +
                    $"Black- {players[i+1].FIDE_titles} {players[i+1].Name} {players[i+1].Surname} {players[i+1].Rating}\n");
            }
        }
	
        public void Struggle(List<Player> players)
        {
            
        }


    }
}
