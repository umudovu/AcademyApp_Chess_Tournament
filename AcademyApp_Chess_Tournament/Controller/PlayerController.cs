using Business.Interfaces;
using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp_Chess_Tournament.Controller
{
    public class PlayerController
    {

        private  PlayerService _playerServices;

        public PlayerController()
        {
            _playerServices=new PlayerService();
        }


        public void GetAllPlayers()
        {
            foreach (var item in _playerServices.AllPlayer())
            {
                Console.WriteLine($"Player id: {item.Id}\n" +
                    $"Name: {item.Name} \n" +
                    $"Surname: {item.Surname} \n" +
                    $"Age: {item.Age} \n" +
                    $"Country: {item.Country} \n" +
                    $"FIFE title: {item.FIDE_titles}");
            }
        }



        public  void GMPlayer()
        {
            Player player1 = new Player()
            {
                Name = "Magnus",
                Surname= "Carlsen",
                Age=35,
                Country="Norway",
                Rating=2862
            };
            Player player2 = new Player()
            {
                Name = "Fabiano",
                Surname= "Caruana",
                Age=30,
                Country="Italy",
                Rating=2823
            };
            Player player3 = new Player()
            {
                Name = "Shakhriyar",
                Surname= "Mamedyarov",
                Age=38,
                Country="Azerbaijan",
                Rating=2770
            };
            Player player4 = new Player()
            {
                Name = "Teimour",
                Surname= "Radjabov",
                Age=30,
                Country="Norway",
                Rating=2765
            };
            Player player5 = new Player()
            {
                Name = "Ian",
                Surname= "Nepomniachtchi",
                Age=33,
                Country="Russia",
                Rating=2789
            };
            Player player6 = new Player()
            {
                Name = "Wesley",
                Surname= "So",
                Age=31,
                Country="Norway",
                Rating=2770
            };
            Player player7 = new Player()
            {
                Name = "Hikaru",
                Surname= "Nakamura",
                Age=35,
                Country="USA",
                Rating=2736

            };
            Player player8 = new Player()
            {
                Name = "Anish",
                Surname= "Giri",
                Age=28,
                Country="France",
                Rating=2764
            };
            Player player9 = new Player()
            {
                Name = "Maxime",
                Surname= "Vachier-Lagrave",
                Age=30,
                Country="France",
                Rating=2784
            };
            Player player10 = new Player()
            {
                Name = "Wang",
                Surname= "Hao",
                Age=34,
                Country="China",
                Rating=2763
            };

            _playerServices.Creat(player1);
            _playerServices.Creat(player2);
            _playerServices.Creat(player3);
            _playerServices.Creat(player4);
            _playerServices.Creat(player5);
            _playerServices.Creat(player6);
            _playerServices.Creat(player7);
            _playerServices.Creat(player8);
            _playerServices.Creat(player8);
            _playerServices.Creat(player10);
        }

    }
}
