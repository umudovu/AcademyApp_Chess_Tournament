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
                    Extentions.Select();
                    select = Console.ReadLine();
                    input = Extentions.TryParse(select);

                    switch (input)
                    {
                        case (int)Extentions.TourMenu.CreateTournament:
                            tournamentController.CreatTournament();
                            
                            do
                            {
                                //Console.Clear();
                                Extentions.Select2();
                                select = Console.ReadLine();
                                input = Extentions.TryParse(select);
                                switch (input)
                                {
                                    case (int)Extentions.PlayerMenu.CreatePlayer:
                                        playerController.CreatePlayer();
                                        break;
                                    case (int)Extentions.PlayerMenu.RemovePlayer:
                                        playerController.RemovePlayer();
                                        break;
                                    case (int)Extentions.PlayerMenu.UpdatePlayer:
                                        playerController.UpdatePlayer();
                                        break;
                                    case (int)Extentions.PlayerMenu.EloPlayer:
                                        playerController.FindPlayerElo();
                                        break;
                                    case (int)Extentions.PlayerMenu.OnePlayer:
                                        playerController.FindPlayerByName();
                                        break;
                                    case (int)Extentions.PlayerMenu.PlayerTitle:
                                        playerController.FintPlayersTitle();
                                        break;

                                }

                            } while (input>=1 || input<=8);






                            break;

                        case (int)Extentions.PlayerMenu.AllPlayer:
                            playerController.GMPlayer();
                            playerController.GetAllPlayers();
                            break;
                    }


                } while (input!=0 || input!=1);

                break;
            }




        }
    }
}
