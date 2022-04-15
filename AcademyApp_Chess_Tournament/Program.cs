using Business.Services;
using Entities.Models;
using System;

namespace AcademyApp_Chess_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerService playerService = new PlayerService();


            Player player1 = new Player()
            {
                Name="Umud",
                Surname="Umudov",
                Age=26,
                Country="Azerbaijan",
                Rating=2232
            };
            Player player2 = new Player()
            {
                Name="Lorem",
                Surname="falan",
                Age=22,
                Country="Azerbaijan",
                Rating=2370
            };
            Player player3 = new Player()
            {
                Name="Sade",
                Surname="falan",
                Age=22,
                Country="Azerbaijan",
                Rating=2500
            };


            playerService.Creat(player1);
            playerService.Creat(player2);
            playerService.Creat(player3);

            playerService.Update("Umud",player2);

            foreach (var item in playerService.AllPlayer())
            {
                Console.WriteLine($" Id: {item.Id} \n" +
                    $"Name: {item.Name} \n" +
                    $"Country: {item.Country} \n" +
                    $"Rating: {item.Rating} \n" +
                    $"FIDE Title: {item.FIDE_titles}");
            }

           


        }
    }
}
