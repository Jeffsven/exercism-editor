namespace ProteinTranslation
{
    using System.Linq;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProteinTranslation.Proteins("AUGUUUUCUUAAAUG"));
        }
        public static class ProteinTranslation
        {
            static string[] Methionine = new string[] { "AUG" };
            static string[] Phenylalanine = new string[] { "UUU", "UUC" };
            static string[] Leucine = new string[] { "UUA", "UUG" };
            static string[] Serine = new string[] { "UCU", "UCC", "UCA", "UCG" };
            static string[] Tyrosine = new string[] { "UAU", "UAC" };
            static string[] Cysteine = new string[] { "UGU", "UGC" };
            static string[] Tryptophan = new string[] { "UGG" };
            static string[] STOP = new string[] { "UAA", "UAG", "UGA" };

            public static string[] Proteins(string strand)
            {
                var acids = Enumerable.Range(0, strand.Length / 3).Select(x => strand.Substring(x * 3, 3)).ToArray();

                List<string> res = new List<string>();

                foreach (var a in acids)
                {

                    if (Methionine.Contains(a)) res.Add(nameof(Methionine));
                    else if (Phenylalanine.Contains(a)) res.Add(nameof(Phenylalanine));
                    else if (Leucine.Contains(a)) res.Add(nameof(Leucine));
                    else if (Serine.Contains(a)) res.Add(nameof(Serine));
                    else if (Tyrosine.Contains(a)) res.Add(nameof(Tyrosine));
                    else if (Cysteine.Contains(a)) res.Add(nameof(Cysteine));
                    else if (Tryptophan.Contains(a)) res.Add(nameof(Tryptophan));
                    if (STOP.Contains(a)) break;
                }

                return res.ToArray(); ;
            }
        }
    }
}