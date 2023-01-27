namespace Tracks_on_Tracks_on_Tracks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Languages
    {
        static List<string> Strings;
        public static List<string> NewList()
        {
            Strings = new List<string>();
            return Strings;
        }

        public static List<string> GetExistingLanguages()
        {
            return new List<string> { "C#", "Clojure", "Elm" };
        }

        public static List<string> AddLanguage(List<string> languages, string language)
        {
            Strings = new List<string>(languages);
            Strings.Add(language);
            return Strings;
        }

        public static int CountLanguages(List<string> languages)
        {
            return languages.Count;
        }

        public static bool HasLanguage(List<string> languages, string language)
        {
            return languages.Contains(language);
        }

        public static List<string> ReverseList(List<string> languages)
        {
            return languages.Reverse<string>().ToList();
        }

        public static bool IsExciting(List<string> languages)
        {
            if (languages.Count is 0) return false;
            if (languages[0] is "C#") return true;
            if (languages[1] is "C#" && (languages.Count is 2 || languages.Count is 3)) return true;
            return false;
        }

        public static List<string> RemoveLanguage(List<string> languages, string language)
        {
            languages.Remove(language);
            return languages;
        }

        public static bool IsUnique(List<string> languages)
        {
            return languages.Count == languages.Distinct().ToList().Count;
        }
    }

}