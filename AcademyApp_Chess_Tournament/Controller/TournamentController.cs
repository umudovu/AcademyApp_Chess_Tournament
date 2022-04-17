using Business.Services;
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
    public class TournamentController
    {
        private TournamnetService _tournamentService;

        public TournamentController()
        {
            _tournamentService=new TournamnetService();
        }  
        
        public void CreatTournament()
        {
            Extentions.PrintTo(ConsoleColor.Yellow, "Tournament name: ");
            string Tname=Console.ReadLine();
            bool isnum; int Tdegree;string degree="";
            do
            {
                Extentions.PrintTo(ConsoleColor.Yellow, "Tournament degree (1-GM,2-IM,3-FM,4-CM):");
                string result = Console.ReadLine();
                isnum = int.TryParse(result, out Tdegree);

            } while (!(isnum && Tdegree>0 && Tdegree<5));
            switch (Tdegree)
            {
                case 1:
                    degree ="GM";
                    break;
                case 2:
                    degree ="IM";
                    break;
                case 3:
                    degree ="FM";
                    break;
                case 4:
                    degree ="CM";
                    break;
            }
            Tournament tournament = new Tournament()
            {
                Name=Tname,
                Degree=degree
            };
            Extentions.Print(ConsoleColor.Green, $"{tournament.Name} ({tournament.Degree}) Tournament created ");
        }

    }
}
