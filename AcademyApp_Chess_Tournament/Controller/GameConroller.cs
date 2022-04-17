using Business.Services;
using DataAccess;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Utilities.Helper;

namespace AcademyApp_Chess_Tournament.Controller
{
    public class GameConroller
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

        public void Plays()
        {
            List<Player> players = playerService.AllPlayer();
            Random random = new Random();
            
            int[]arry=new int[Size()+1];

            for (int i = 0; i < Size()-1; i++)
            {
                
                int rnd = random.Next(0, Size()-1);
                if (!arry.Contains(rnd))
                {
                    Extentions.Print(ConsoleColor.Yellow,
                    $"{i+1}. table plays: \n");
                    Extentions.Print(ConsoleColor.Yellow, 
                        $"White- {players[rnd].FIDE_titles} {players[rnd].Name } {players[rnd].Surname} {players[rnd].Rating} \n" +
                        $"Black- {players[rnd+1].FIDE_titles} {players[rnd+1].Name} {players[rnd+1].Surname} {players[rnd+1].Rating}\n");
                    arry[i]=rnd;
                }
            }

            //for (int i = 0; i < Size()-1; i++)
            //{
            //    int result = random.Next(arry[i],arry[i+1]);
            //    if (!arry.Contains(result))
            //    {
            //        Extentions.Print(ConsoleColor.Yellow,
            //            $"{i+1}. table win: \n");
            //        Extentions.Print(ConsoleColor.Yellow, $"{players[result].FIDE_titles} {players[result].Name } {players[result].Surname} {players[result].Rating}");

            //    }
            //}
        }



    }
}
