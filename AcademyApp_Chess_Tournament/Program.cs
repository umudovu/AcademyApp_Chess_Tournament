using AcademyApp_Chess_Tournament.Controller;
using Business.Services;
using Entities.Models;
using System;
using Utilities.Helper;

namespace AcademyApp_Chess_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Extentions.Print(ConsoleColor.Cyan, "Welcome to Chess Championship");
            while (true)
            {
                PlayerController playerController = new PlayerController();
                TournamentController tournamentController = new TournamentController();
                string select;
                int input;

                do
                {
                    Extentions.Print(ConsoleColor.Cyan, "1-Create a new tournament\n" +
                    "0-Watch top player list");
                    Extentions.PrintTo(ConsoleColor.Cyan, "Select:");
                    select = Console.ReadLine();
                    input = Extentions.TryParse(select);

                    switch (input)
                    {
                        case (int)Extentions.TourMenu.CreateTournament:
                            tournamentController.CreatTournament();

                            break;

                        case (int)Extentions.PlayerMenu.AllPlayer:
                            playerController.GMPlayer();
                            playerController.GetAllPlayers();
                            break;



                        default:
                            break;
                    }


                } while (input!=0 || input!=1);

                break;
            }




        }
    }
}
