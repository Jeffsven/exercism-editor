using System.Collections;
using System.Collections.Generic;

namespace Flatten_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new object[] { 1, new object[] { 2, 3, 4, 5, 6, 7 }, 8 };
            var s = FlattenArray.Flatten(array);
            Console.WriteLine(s);
        }
    }
    public static class FlattenArray
    {
        static List<object> oo;

        public static IEnumerable Flatten(IEnumerable input)
        {
            oo = new List<object>();
            return Flatten2(input);
        }
        private static IEnumerable Flatten2(IEnumerable input)
        {
            foreach (var a in input)
            {
                switch (a)
                {
                    default:
                    case null: break;

                    case IEnumerable ievalue: Flatten2(ievalue); break;
                    case object ovalue: oo.Add(ovalue); break;
                }
            }

            return oo;
        }
    }
}