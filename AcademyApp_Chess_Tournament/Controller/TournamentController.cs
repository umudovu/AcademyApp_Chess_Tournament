using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Helper;

namespace AcademyApp_Chess_Tournament.Controller
{
    public class TournamentController
    {
        private TournamnetService _tournamentService;

        public TournamentController()
        {
            _tournamentService=new TournamnetService();
        }  
        
        public void CreatTournament()
        {
            Extentions.PrintTo(ConsoleColor.Green, "Tournament name: ");
            string Tname=Console.ReadLine();
            Extentions.PrintTo(ConsoleColor.Green, "Tournament degree (GM,IM,FM,CM): ");
            string TDegree = Console.ReadLine();
            Tournament tournament = new Tournament()
            {
                Name=Tname,
                Degree=TDegree
            };
            Extentions.Print(ConsoleColor.Yellow, "Tournament created ");
        }

      


    }
}
