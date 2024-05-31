using System;
using System.Linq;

namespace övning_list._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "a", "b", "b", "c", "hej" };
            string[] array2 = { "hej", "a", "a", "b", "programmering" };

            string[] gemensammaSträngar = FinnsIBåda(array1, array2);

            Console.WriteLine("Gemensamma strängar:");
            foreach (string sträng in gemensammaSträngar)
            {
                Console.WriteLine(sträng);
            }
        }

        static string[] FinnsIBåda(string[] array1, string[] array2)
        {
            var gemensamma = array1.Intersect(array2).Distinct().ToArray();
            return gemensamma;
        }
    }
}
