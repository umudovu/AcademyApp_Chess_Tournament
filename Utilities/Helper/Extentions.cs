using System;

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
                    "0-Watch top player list");
            Extentions.PrintTo(ConsoleColor.Cyan, "Select:");

        }
        public static void Select2()
        {
            Extentions.Print(ConsoleColor.Cyan, "1-Creat Player\n" +
                    "2-Remove player by id \n" +
                    "3-Update player \n" +
                    "4-Find players to the rating \n" +
                    "5-Find player by name \n" +
                    "6-Find player to the title " +
                    "7-Start tournament\n" +
                    "8-Add Top 10 Grandmaster \n");
            Extentions.PrintTo(ConsoleColor.Cyan, "Select:");

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
            AllPlayer,
            CreatePlayer ,
            RemovePlayer,
            UpdatePlayer,
            EloPlayer,
            OnePlayer,
            PlayerTitle,
            
            
            
        }
    }
}
