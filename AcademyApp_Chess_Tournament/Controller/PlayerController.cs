using Business.Interfaces;
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
    public class PlayerController
    {

        private  PlayerService _playerServices;

        public PlayerController()
        {
            _playerServices=new PlayerService();
        }


        public void CreatePlayer()
        {
            Extentions.PrintTo(ConsoleColor.Blue, "Player name:");
            string Pname=Console.ReadLine();
            Extentions.PrintTo(ConsoleColor.Blue, "Player surname:");
            string Psurname = Console.ReadLine();
            
            bool isnum; int Page;
            do
            {
                Extentions.PrintTo(ConsoleColor.Blue, "Player age:");
                string age = Console.ReadLine();
                isnum = int.TryParse(age, out Page);

            } while (!isnum);

            Extentions.PrintTo(ConsoleColor.Blue, "Player country:");
            string Pcountry = Console.ReadLine();
            
            int Prating;
            do
            {
                Extentions.PrintTo(ConsoleColor.Blue, "Player Rating:");
                string rating = Console.ReadLine();
                isnum=int.TryParse(rating, out Prating);
            } while (!isnum);
            

            Player player = new Player()
            {
                Name=Pname,
                Surname=Psurname,
                Age=Page,
                Country=Pcountry,
                Rating=Prating
            };
            _playerServices.Creat(player);

            Extentions.Print(ConsoleColor.Green, "Player created");

        }

        public void GetAllPlayers()
        {
            Extentions.PlayerInfo(_playerServices.AllPlayer());
        }

        public void RemovePlayer()
        {
            bool isnum = false;
            int id;
            do
            {
                Extentions.PrintTo(ConsoleColor.Red, "Enter the player id: ");
                string isid=Console.ReadLine();
                isnum=int.TryParse(isid, out id);
            } while (!isnum);
            _playerServices.Delete(id);
            Extentions.PrintTo(ConsoleColor.Red, "Player removed ");
        }

        public void UpdatePlayer()
        {
            Extentions.PrintTo(ConsoleColor.Yellow, "Enter the player name: ");
            string NewName=Console.ReadLine();
            Extentions.PrintTo(ConsoleColor.Yellow, "Which player do you want to change?: ");
            string OldName=Console.ReadLine();
            Player updateplayer=_playerServices.OnePlayer(OldName);
            _playerServices.Update(NewName, updateplayer);
            Extentions.PrintTo(ConsoleColor.Yellow, "Player updated ");
        }

        public void FindPlayerElo()
        {
            Extentions.PrintTo(ConsoleColor.Green, "Enter minimum rating: ");
            string minrating=Console.ReadLine();
            int Minrating = Extentions.TryParse(minrating);
            Extentions.PrintTo(ConsoleColor.Green, "Enter maximum rating: ");
            string maxrating = Console.ReadLine();
            int Maxrating = Extentions.TryParse(minrating);
            foreach (var item in _playerServices.EloPlayer(Minrating,Maxrating))
            {
                Extentions.PrintTo(ConsoleColor.Green, $"Player name: {item.Name} \n" +
                    $"Player rating: {item.Rating}\n" +
                    $"---------------- ");
            }
        }

        public void FindPlayerByName()
        {
            Extentions.PrintTo(ConsoleColor.Green, "Enter the player name: ");
            string name = Console.ReadLine();
            Player pl = _playerServices.OnePlayer(name);
            Extentions.PlayerInfo(pl);
        }

        public void FintPlayersTitle()
        {
            Extentions.PrintTo(ConsoleColor.Green, "Enter the FIDE title: ");
            string title = Console.ReadLine();
            Extentions.PlayerInfo(_playerServices.PlayerTitle(title));
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
                Country="Azerbaijan",
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
