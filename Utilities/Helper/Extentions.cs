namespace Utilities.Helper
{
    public static class Extentions
    {

        public static string Check(this int rating)
        {
            string result="";

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
    }
}
