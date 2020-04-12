using System.Linq;

namespace Strings
{
    public class Strings
    {
        public static string ConvertToLowerCaseAndUnderscore(string text)
        {
            if (text == null)
            {
                return null;
            }

            var texts = text.Split(" ")
                .Select(t =>
                {
                    return char.ToLower(t[0]) + t.Substring(1);
                })
                .ToList();

            return string.Join("_", texts.Select(t => t));
        }
    }
}
