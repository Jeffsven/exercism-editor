using System.Text.RegularExpressions;

namespace Squeaky_Clean
{
    using System.Linq;
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Identifier.Clean("9 -abcĐ😀ω\0"));
        }
    }

    public static class Identifier
    {

        public static string Clean(string identifier)
        {
            string s1 = "";
            if (identifier.Contains("-")) foreach (var s in identifier.Split('-')) s1 += char.ToUpperInvariant(s[0]) + s.Remove(0);
            else s1 = identifier;

            string s2 = s1.Replace(" ", "_");
            string s3 = string.Join("", s2.Select(x => char.IsControl(x) ? "CTRL" : x.ToString()).ToArray());


            string[] greeks = "α β γ δ ε ζ η θ ι κ λ μ ν ξ ο π ρ σ τ υ φ χ ψ ω".Split(" ");
            string s4 = string.Join("", s3.Where(c => !greeks.Contains<string>(c.ToString())));

            string s5 = string.Join("", identifier.Where(c => char.IsLetter(c)));

            return s5;
        }
    }
}