using Entities.Models;
using System;
using System.Collections.Generic;

namespace Utilities.Helper
{
    public static class Extentions
    {

        public static string Check(this int rating)
        {
            string result = "";

            if (rating<2200)
            {
                result = "Amateur";
            }
            if (rating>=2200 && rating<2300)
            {
                result="CM";
            }
            if (rating>=2300 && rating<2400)
            {
                result="FM";
            }
            if (rating>=2400)
            {
                result="GM";
            }

            return result;

        }

        public static void Print(ConsoleColor color, string message)
        {
            Console.ForegroundColor= color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void PrintTo(ConsoleColor color, string message)
        {
            Console.ForegroundColor= color;
            Console.Write(message);
            Console.ResetColor();
        }
        public static void Select()
        {
            Extentions.Print(ConsoleColor.Cyan, "1-Create a new tournament\n" +
                    "2-Watch top player list");
            Extentions.PrintTo(ConsoleColor.Cyan, "Select:");

        }
        public static void Select2()
        {
            Extentions.Print(ConsoleColor.Cyan, "1-Creat Player\n" +
                    "2-Remove player by id \n" +
                    "3-Update player \n" +
                    "4-Find players to the rating \n" +
                    "5-Find player by id \n" +
                    "6-Find player to the title \n" +
                    "7-Start tournament\n" +
                    "8-Add Top 10 Grandmaster \n" +
                    "9-All Players ");
            Extentions.PrintTo(ConsoleColor.Cyan, "Select:");

        }

        public static void PlayerInfo(List<Player> player)
        {
            foreach (var item in player)
            {
                Extentions.Print(ConsoleColor.Green, $"Player id: {item.Id}\n" +
                                                     $"Name: {item.Name} \n" +
                                                     $"Surname: {item.Surname} \n" +
                                                     $"Age: {item.Age} \n" +
                                                     $"Country: {item.Country} \n" +
                                                     $"Player rating: {item.Rating} \n" +
                                                     $"FIFE title: {item.FIDE_titles}\n" +
                                                     $"----------------------");
            }
        }
        public static void PlayerInfo(Player player)
        {
            Extentions.Print(ConsoleColor.Green, $"Player id: {player.Id}\n" +
                                                 $"Name: {player.Name} \n" +
                                                 $"Surname: {player.Surname} \n" +
                                                 $"Age: {player.Age} \n" +
                                                 $"Country: {player.Country} \n" +
                                                 $"Player rating: {player.Rating} \n" +
                                                 $"FIFE title: {player.FIDE_titles}\n" +
                                                 $"----------------------");
        }

        public static int TryParse(string input)
        {
            bool IsNum;
            int result;
            do
            {
                IsNum = int.TryParse(input, out result);
                return result;
            } while (!IsNum);
        }

        public enum TourMenu
        {
            CreateTournament = 1,
            RemoveTournament,
            UpdateTournament,
            GetTournametById,
            GetAllTournament
        }

        public enum PlayerMenu
        {

            CreatePlayer = 1,
            RemovePlayer,
            UpdatePlayer,
            EloPlayer,
            OnePlayer,
            PlayerTitle,
            AllPlayer = 9,
        }

        public enum Event
        {
            Start = 7,
            TopPlayer
        }
    }
}
