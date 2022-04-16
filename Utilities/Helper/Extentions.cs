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

        public static int TryParse(string input)
        {
            int result = 0;
            bool IsNum = int.TryParse(input, out result);
            return result;
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
