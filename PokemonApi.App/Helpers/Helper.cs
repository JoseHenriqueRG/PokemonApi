namespace PokemonApi.App.Helpers
{
    public static class Helper
    {
        public static string ToUpperFirstLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
